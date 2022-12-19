using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KursRab
{
    public partial class AddNewTableWindow : Form
    {
        private const string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = kursRab.mdb;";
        private OleDbConnection conn = new OleDbConnection(connectionString);

        List<string> TableNames = new List<string>();

        public AddNewTableWindow()
        {
            conn.Open();
            InitializeComponent();
            TableNames = GetTableNames();
        }

        private void FillComboBoxes(List<int> list)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!Convert.ToBoolean(dataGridView1[3, i].Value))
                {
                    dataGridView1[4, i].Value = null;
                    dataGridView1[4, i].ReadOnly = true;

                    dataGridView1[5, i].Value = null;
                    dataGridView1[5, i].ReadOnly = true;
                }
            }

            foreach (var rowIndex in list)
            {
                if (dataGridView1[4, rowIndex].ReadOnly)
                {
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1[4, rowIndex];
                    dataGridView1[4, rowIndex].ReadOnly = false;
                    cell.DataSource = GetTableNames();
                    dataGridView1[4, rowIndex].Value = ((DataGridViewComboBoxCell)dataGridView1[4, rowIndex]).Items[0];
                }

                if (dataGridView1[5, rowIndex].ReadOnly)
                {
                    DataGridViewComboBoxCell fieldComboBoxCell = (DataGridViewComboBoxCell)dataGridView1[5, rowIndex];
                    dataGridView1[5, rowIndex].ReadOnly = false;
                    fieldComboBoxCell.DataSource = GetColumnNames(dataGridView1[4, rowIndex].Value.ToString());
                    dataGridView1[5, rowIndex].Value = ((DataGridViewComboBoxCell)dataGridView1[5, rowIndex]).Items[0];
                }
                
            }
        }

        public List<string> GetTableNames()
        {
            List<string> tableNames = new List<string>();

            DataSet dataSet = new DataSet();
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            foreach (DataRow dr in dt.Rows)
            {
                tableNames.Add((string)dr["TABLE_NAME"]);
            }

            return tableNames;
        }

        public List<string> GetColumnNames(string tableName)
        {
            List<string> ColumnNames = new List<string>();
            using (var reader = new OleDbCommand($"SELECT * FROM {tableName}", conn).ExecuteReader(CommandBehavior
                       .SchemaOnly))
            {
                var table = reader.GetSchemaTable();
                var columnNames = table.Columns["ColumnName"];
                foreach (DataRow row in table.Rows)
                {
                    ColumnNames.Add(row[columnNames].ToString());
                }
            }
            return ColumnNames;
        }

        private List<int> GetCheckedRow()
        {
            List<int> checkBoxList = new List<int>();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1[3, i].Value))
                {
                    checkBoxList.Add(i);
                }
            }
            
            return checkBoxList;
        }

        private void AddNewTableButton_Click(object sender, EventArgs e)
        {
            var CommandString = $"CREATE TABLE {textBox1.Text} (\n";

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    if (i == 0)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "id" &&
                            dataGridView1.Rows[i].Cells[2].Value.ToString() == "Int")
                        {
                            CommandString += $"{dataGridView1.Rows[i].Cells[1].Value} counter CONSTRAINT i PRIMARY KEY,\n";
                            continue;
                        }
                    }

                    CommandString += $"{dataGridView1.Rows[i].Cells[1].Value} {dataGridView1.Rows[i].Cells[2].Value} CONSTRAINT i PRIMARY KEY,\n";
                    

                }
                else
                {
                    CommandString += $"{dataGridView1.Rows[i].Cells[1].Value} {dataGridView1.Rows[i].Cells[2].Value},\n";
                }
            }

            foreach (var rowIndex in GetCheckedRow())
            {
                CommandString +=
                    $"FOREIGN KEY ({dataGridView1[1, rowIndex].Value}) REFERENCES {dataGridView1[4, rowIndex].Value}([{dataGridView1[5, rowIndex].Value}]),\n";
            }

            CommandString = CommandString.Remove(CommandString.Length - 2);
            CommandString += ")";

            try
            {
                new OleDbCommand(CommandString, conn).ExecuteNonQuery();
                textBox1.Text = string.Empty;
                dataGridView1.Rows.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void AddNewTableWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].Value = false;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1[4, e.RowIndex];

                    if (cell.DataSource != null)
                    {
                        DataGridViewComboBoxCell fieldComboBoxCell = (DataGridViewComboBoxCell)dataGridView1[5, e.RowIndex];
                        fieldComboBoxCell.DataSource = GetColumnNames(dataGridView1[4, e.RowIndex].Value.ToString());
                        dataGridView1[5, e.RowIndex].Value = ((DataGridViewComboBoxCell)dataGridView1[5, e.RowIndex]).Items[0];
                    }
                }
            }
                
        }



        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 3)
                {
                    if (!GetCheckedRow().Contains(-1))
                    {
                        FillComboBoxes(GetCheckedRow());
                    }
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"col={e.ColumnIndex} row={e.RowIndex}");
        }
    }
}
