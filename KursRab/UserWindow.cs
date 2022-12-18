using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types;
using Message = Telegram.Bot.Types.Message;


namespace KursRab
{

    public partial class UserWindow : Form
    {
        //ITelegramBotClient client = new TelegramBotClient("5987835393:AAErTC9VQEk0-i6AUN1Zy5D7-nq3czyqSc8");
        //Message message = new Message();


        private const string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = kursRab.mdb;";
        private OleDbConnection conn = new OleDbConnection(connectionString);


        private List<CheckBox> checkedList;
        private List<ComboBox> comboBoxList;

        public UserWindow()
        {
            InitializeComponent();
            //client.StartReceiving(Update, Error);
            checkedList = new List<CheckBox>() { checkBox1, checkBox2, checkBox4, checkBox3, checkBox5 };
            comboBoxList = new List<ComboBox>() { ServiceComboBox, StatusComboBox, WorkerComboBox };
        }

        
        private void FillComboBoxes()
        {
            string strSql = "SELECT id, name FROM pricelist";
            OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ServiceComboBox.DataSource = ds.Tables[0];
            ServiceComboBox.DisplayMember = "name";
            ServiceComboBox.ValueMember = "name";

            strSql = "SELECT id, statusName FROM statuses";
            adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
            ds = new DataSet();
            adapter.Fill(ds);
            StatusComboBox.DataSource = ds.Tables[0];
            StatusComboBox.DisplayMember = "statusName";
            StatusComboBox.ValueMember = "statusName";

            strSql = "SELECT id, fio FROM workers";
            adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
            ds = new DataSet();
            adapter.Fill(ds);
            WorkerComboBox.DataSource = ds.Tables[0];
            WorkerComboBox.DisplayMember = "fio";
            WorkerComboBox.ValueMember = "fio";

            adapter.Dispose();

            ClearBoxes();
        }

        private void ClearBoxes()
        {
            ServiceComboBox.SelectedIndex = -1;
            StatusComboBox.SelectedValue = -1;
            WorkerComboBox.SelectedValue = -1;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            conn.Open();
            FillComboBoxes();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            UpdateDataGridView(new OleDbCommand("SELECT applications.id, customers.fio, pricelist.name, applications.counters, applications.cost, applications.create_date, applications.half_day, applications.complete_date, applications.note, statuses.statusName, workers.fio " +
                                            "FROM workers INNER JOIN (statuses INNER JOIN (pricelist INNER JOIN (customers INNER JOIN applications ON customers.id = applications.customer_id) ON pricelist.id = applications.price_id) ON statuses.id = applications.status) ON workers.id = applications.worker_id;", conn).ExecuteReader());
        }

        private void UpdateDataGridView(OleDbDataReader reader)
        {
            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0].ToString(),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    reader[3].ToString(),
                    reader[4].ToString(),
                    reader[5].ToString().Split(' ')[0],
                    reader[6].ToString(),
                    reader[7].ToString().Split(' ')[0],
                    reader[8].ToString(),
                    reader[9].ToString(),
                    $"{reader[10].ToString().Split(' ')[0]} {reader[10].ToString().Split(' ')[1][0]}. {reader[10].ToString().Split(' ')[2][0]}.");
            }
            reader.Dispose();
        }

        // снять выделения с ячеек
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

        }

        // убирает выбранные параметры в ComboBox
        private void button3_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        // вызывается при вибирании какого-нибудь CheckBox, фильтрует заказы
        private void Changed(object sender, EventArgs e)
        {
            if (checkedList.All(c => !c.Checked))
            {
                UpdateDataGridView();
            }
            else
            {
                string commandString0 =
                    $"SELECT applications.id, customers.fio, pricelist.name, applications.counters, applications.cost, applications.create_date, applications.half_day, applications.complete_date, applications.note, statuses.statusName, workers.fio " +
                    $"FROM workers INNER JOIN (statuses INNER JOIN (pricelist INNER JOIN (customers INNER JOIN applications ON customers.id = applications.customer_id) ON pricelist.id = applications.price_id) ON statuses.id = applications.status) ON workers.id = applications.worker_id";
                string commandString1 = String.Empty;
                string commandString4 = String.Empty;
                string commandString5 = String.Empty;
                string commandString2 = $"{(checkBox2.Checked ? $"applications.create_date = CDate(\"{dateTimePicker1.Value.Year}-{dateTimePicker1.Value.Month}-{dateTimePicker1.Value.Day} 00:00:00\")" : "")}";
                string commandString3 = $"{(checkBox3.Checked ? $"applications.create_date = CDate(\"{dateTimePicker2.Value.Year}-{dateTimePicker2.Value.Month}-{dateTimePicker2.Value.Day} 00:00:00\")" : "")}";

                if (comboBoxList.Any(c => c.SelectedIndex != -1))
                {
                    commandString1 = $"{(checkBox1.Checked & (ServiceComboBox.SelectedIndex != -1) ? $"pricelist.name = \"{ServiceComboBox.SelectedValue}\"" : "")}";
                    commandString4 = $"{(checkBox4.Checked & (StatusComboBox.SelectedIndex != -1) ? $"statuses.statusName = \"{StatusComboBox.SelectedValue}\"" : "")}";
                    commandString5 = $"{(checkBox5.Checked & (WorkerComboBox.SelectedIndex != -1) ? $"workers.fio = \"{WorkerComboBox.SelectedValue}\"" : "")}";
                }

                List<string> values = new List<string>() { commandString0, commandString1, commandString2, commandString3, commandString4, commandString5 };
                values = values.Where(s => !string.IsNullOrEmpty(s)).ToList();
                if (values.Count > 1)
                {
                    values[0] += " WHERE " + values[1];
                    values.RemoveAt(1);
                }

                UpdateDataGridView(new OleDbCommand(string.Join(" AND ", values), conn).ExecuteReader());

            }
            
        }

        // убирает все выбранные CheckBox
        private void button2_Click(object sender, EventArgs e)
        {
            checkedList.ForEach(c => c.Checked = false);
        }

        // выбирает все CheckBox
        private void button1_Click(object sender, EventArgs e)
        {
            checkedList.ForEach(c => c.Checked = true);
        }

        // переход в админский режим
        private void AdminButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Closed += delegate
            {
                Visible = true;
                UpdateDataGridView();
            };
            adminWindow.Visible = true;
        }
    }
}
