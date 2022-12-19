using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types;
using Message = Telegram.Bot.Types.Message;

namespace KursRab
{
    public partial class AdminWindow : Form
    {
        ITelegramBotClient client = new TelegramBotClient("5987835393:AAErTC9VQEk0-i6AUN1Zy5D7-nq3czyqSc8");
        Message message = new Message();

        private const string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = kursRab.mdb;";
        private OleDbConnection conn = new OleDbConnection(connectionString);

        private string regexString = "([А-ЯЁ][а-яё]+[\\-\\s]?){3,}";

        public int id;
        public string name;
        public string phone;
        public string address;


        private AddNewCustomerWindow addNewCustomerWindow;
        public AdminWindow()
        {
            //client.StartReceiving(Update, Error);
            InitializeComponent();
            addNewCustomerWindow = new AddNewCustomerWindow(this);
            conn.Open();
        }

        // запонение ComboBox
        private void FillComboBoxes()
        {
            CompliteDayDateTimePicker.MinDate = DateTime.Now;

            string strSql = "SELECT id, name FROM pricelist";
            OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ServiceComboBox.DataSource = ds.Tables[0];
            ServiceComboBox.DisplayMember = "name";
            ServiceComboBox.ValueMember = "id";


            strSql = "SELECT id, fio FROM workers";
            adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
            ds = new DataSet();
            adapter.Fill(ds);
            WorkerComboBox.DataSource = ds.Tables[0];
            WorkerComboBox.DisplayMember = "fio";
            WorkerComboBox.ValueMember = "id";

            adapter.Dispose();

            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            List<string> TableNames = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                TableNames.Add((string)dr["TABLE_NAME"]);
            }

            dt.Dispose();
            comboBox1.DataSource = TableNames;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            FillComboBoxes();
            UpdateDataGridView();

            dataGridView1.ClearSelection();
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

        // проверка на наличие ФИО клиента в базе
        private bool IsHaveMatches(OleDbDataReader reader, string textBoxName)
        {
            while (reader.Read())
            {
                if (string.Equals(reader[0].ToString(), textBoxName))
                {
                    reader.Dispose();
                    return true;
                }
            }
            reader.Dispose();
            return false;
        }

        private async void AddButton_Click(object sender, System.EventArgs e)
        {
            if (Regex.Match(NameTextBox.Text, regexString).Success)
            {

                if (!IsHaveMatches(new OleDbCommand("SELECT fio FROM customers", conn).ExecuteReader(), NameTextBox.Text))
                {
                    addNewCustomerWindow.FillNameTextBox(NameTextBox.Text);
                    addNewCustomerWindow.ShowDialog();
                    if (!addNewCustomerWindow.IsCreatedNewCustomer) return;
                    addNewCustomerWindow.IsCreatedNewCustomer = false;
                }
                else
                {
                    var CustomerReader = new OleDbCommand($"SELECT id, fio, telephone, address FROM customers WHERE fio = \"{NameTextBox.Text}\"", conn)
                        .ExecuteReader();
                    CustomerReader.Read();
                    id = CustomerReader.GetInt32(0);
                    name = CustomerReader.GetString(1);
                    phone = CustomerReader.GetString(2);
                    address = CustomerReader.GetString(3);
                    CustomerReader.Close();
                    CustomerReader.Dispose();
                }
                new OleDbCommand($"INSERT INTO applications (customer_id, price_id, counters, cost, create_date, half_day, complete_date, [note], status, worker_id ) " +
                                 $"VALUES (" +
                                 $"({id})," +
                                 $"({ServiceComboBox.SelectedValue})," +
                                 $"({CountersNumericUpDown.Value})," +
                                 $"(0)," +
                                 $"(\"{DateTime.Now.ToShortDateString()}\")," +
                                 $"({HalfDayNumericUpDown.Value})," +
                                 $"(\"{CompliteDayDateTimePicker.Value.ToShortDateString()}\")," +
                                 $"(\"{NoteTextBox.Text}\")," +
                                 $"(1)," +
                                 $"({WorkerComboBox.SelectedValue}))", conn).ExecuteNonQuery();
                new OleDbCommand(
                    "UPDATE pricelist INNER JOIN applications ON pricelist.id = applications.price_id SET applications.cost = [pricelist]![price]*[applications]![counters];", conn).ExecuteNonQuery();

                var reader = new OleDbCommand($"SELECT id, chat_id FROM workers WHERE id = {WorkerComboBox.SelectedValue}", conn).ExecuteReader();
                reader.Read();



                try
                {
                    await client.SendTextMessageAsync(reader.GetInt32(1), $"Вам поступил новый заказ:\nдата выполнения: {CompliteDayDateTimePicker.Value.ToShortDateString()} \n{name}\nпо адресу: {address}\n" +
                                                                          $"телефон: {phone}");
                }
                catch (Exception exception)
                {

                }

                reader.Dispose();

                UpdateDataGridView();

                NameTextBox.Text = string.Empty;
                NoteTextBox.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Неправильно указано имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                new OleDbCommand(
                    $"DELETE FROM applications WHERE id = {row.Cells[0].Value}", conn).ExecuteNonQuery();
            }

            UpdateDataGridView();
        }

        // установка статуса СОЗДАНА для выбранного заказа
        private void button1_Click(object sender, EventArgs e)
        {

            new OleDbCommand(
                $"UPDATE applications set status = 1 WHERE id = {dataGridView1.SelectedRows[0].Cells[0].Value}", conn).ExecuteNonQuery();

            UpdateDataGridView();
        }

        // установка статуса ОТМЕНЕНА для выбранного заказа
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                new OleDbCommand(
                    $"UPDATE applications set status = 2 WHERE id = {row.Cells[0].Value}", conn).ExecuteNonQuery();
            }
            UpdateDataGridView();
        }

        // установка статуса ВЫПОЛНЕНА для выбранного заказа
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                new OleDbCommand(
                    $"UPDATE applications set status = 3 WHERE id = {row.Cells[0].Value}", conn).ExecuteNonQuery();
            }
            UpdateDataGridView();
        }

        // установка статуса НЕ ОТРАБОТАНА для выбранного заказа
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                new OleDbCommand(
                    $"UPDATE applications set status = 4 WHERE id = {row.Cells[0].Value}", conn).ExecuteNonQuery();
            }
            UpdateDataGridView();
        }

        // вывод данных о клиенте у выбраного заказа
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var reader1 = new OleDbCommand($"SELECT id, customer_id FROM applications WHERE id = {dataGridView1.SelectedRows[0].Cells[0].Value}", conn).ExecuteReader();
            reader1.Read();
            var reader2 = new OleDbCommand($"SELECT id, fio, telephone, address FROM customers WHERE id = {reader1[1]}", conn).ExecuteReader();
            reader2.Read();



            CustomerNameTextBox.Text = reader2.GetString(1);
            CustomerPhoneTextBox.Text = reader2.GetString(2);
            CustomerAddressTextBox.Text = reader2.GetString(3);
            reader1.Dispose();
            reader2.Dispose();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            new OleDbCommand($"DROP TABLE {comboBox1.SelectedValue}", conn).ExecuteNonQuery();
            FillComboBoxes();
        }

        private void AddNewTableButton_Click(object sender, EventArgs e)
        {
            AddNewTableWindow addNewTableWindow = new AddNewTableWindow();
            addNewTableWindow.FormClosed += (o, args) =>
            {
                FillComboBoxes();
                UpdateDataGridView();
            };
            addNewTableWindow.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void EditTableButton_Click(object sender, EventArgs e)
        {
            EditTableWindow editTableWindow = new EditTableWindow();
            editTableWindow.FormClosed += (o, args) => { FillComboBoxes(); UpdateDataGridView(); };
            editTableWindow.ShowDialog();

        }

        // ТелеграммБот
        async static Task Error(ITelegramBotClient botClient, Exception exception, CancellationToken token)
        {
            MessageBox.Show(exception.Message, "Telegram Bot");
        }
        async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {

            string regexStringName = "([А-ЯЁ][а-яё]+[\\-\\s]?){3,}";
            string regexStringPhone = "^((\\+7|7|8)+([0-9]){10})$";
            message = update.Message;
            if (string.Equals(message?.Text, "/start"))
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "Введите имя и телефон в формате ФИО:Телефон");
            }

            if (message != null)
            {
                if (message.Text.Contains(":"))
                {
                    var splitText = message.Text.Split(':');
                    if (Regex.Match(splitText[0], regexStringName).Success &&
                        Regex.Match(splitText[1], regexStringPhone).Success)
                    {
                        var reader = new OleDbCommand($"SELECT fio, telephone, email FROM workers WHERE fio = \"{splitText[0]}\" and telephone = \"{splitText[1]}\"", conn)
                            .ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            new OleDbCommand(
                                $"UPDATE workers SET chat_id = {message.Chat.Id} WHERE fio = \"{reader[0]}\"",
                                conn).ExecuteNonQuery();
                            await botClient.SendTextMessageAsync(message.Chat.Id, $"Успех - {message.Chat.Id}", cancellationToken: token);
                        }
                        else
                        {
                            await botClient.SendTextMessageAsync(message.Chat.Id, "Неправильное имя или номер.\nВведите имя и телефон в формате ФИО:Телефон");
                        }
                        reader.Dispose();
                    }
                }
            }

        }
    }
}
