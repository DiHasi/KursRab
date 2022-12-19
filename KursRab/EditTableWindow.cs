using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KursRab
{
    public partial class EditTableWindow : Form
    {
        private const string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = kursRab.mdb;";
        private OleDbConnection conn = new OleDbConnection(connectionString);
        private int newRowId = 0;

        List<string> ColumnNames = new List<string>();
        List<object> ColumnTypes = new List<object>();

        public EditTableWindow()
        {
            conn.Open();
            InitializeComponent();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            List<string> TableNames = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                TableNames.Add((string)dr["TABLE_NAME"]);
            }
            comboBox1.DataSource = TableNames;
        }

        private void UpdateDataGridView()
        {
            OleDbDataReader reader = new OleDbCommand($"SELECT * FROM {comboBox1.SelectedValue}", conn).ExecuteReader();

            dataGridView1.Rows.Clear();
            int i = 0;
            while (reader.Read())
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = reader.GetValue(j);
                }
                i++;
            }
            reader.Dispose();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == newRowId - 1) return;
            try
            {
                new OleDbCommand(
                    $"UPDATE {comboBox1.SelectedValue} set [{ColumnNames[e.ColumnIndex]}] = \"{dataGridView1[e.ColumnIndex, e.RowIndex].Value}\" WHERE id = {dataGridView1[0, e.RowIndex].Value}",
                    conn).ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //UpdateDataGridView();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.Columns.Clear();
            ColumnNames.Clear();
            ColumnTypes.Clear();

            var reader =
                new OleDbCommand($"SELECT * FROM {comboBox1.SelectedValue}", conn).ExecuteReader(CommandBehavior
                    .SchemaOnly);

            var table = reader.GetSchemaTable();
            var nameColumn = table.Columns["ColumnName"];
            var typeColumn = table.Columns["DataType"];

            foreach (DataRow row in table.Rows)
            {
                ColumnNames.Add(row[nameColumn].ToString());
                ColumnTypes.Add(row[typeColumn]);
            }

            for (int i = 0; i < ColumnNames.Count; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
                dataGridView1.Columns[i].Name = ColumnNames[i];
                if (string.Equals(ColumnNames[i], "id")) dataGridView1.Columns[i].ReadOnly = true;
            }

            UpdateDataGridView();
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                int value = 0;
                if (dataGridView1[0, 0].Value.ToString() == "id")
                {
                    value = 1;
                }
                var sql = $"INSERT INTO {comboBox1.SelectedValue} (";
                for (int i = value; i < ColumnNames.Count; i++)
                {
                    sql += $"[{ColumnNames[i]}]";
                    if (i < ColumnNames.Count - 1) sql += ", ";
                }
                sql += ") VALUES (";
                for (int i = 0; i < dataGridView1.Rows[newRowId - 1].Cells.Count; i++)
                {
                    var x = dataGridView1.Rows[newRowId - 1].Cells[i].Value;
                    if (ColumnTypes[i].ToString() == "System.Int32")
                        sql += $"({x})";
                    else
                        sql += $"(\"{x}\")";
                    if (i < dataGridView1.Rows[newRowId - 1].Cells.Count - 1) sql += ",";
                }
                sql += ")";
                MessageBox.Show(sql);
                new OleDbCommand(sql, conn).ExecuteNonQuery();
                UpdateDataGridView();
                dataGridView1.AllowUserToAddRows = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                new OleDbCommand($"DELETE FROM {comboBox1.SelectedValue} WHERE id = {dataGridView1.CurrentRow.Cells[0].Value}", conn).ExecuteNonQuery();
            }
            catch (Exception exception) { MessageBox.Show(exception.Message); }
            UpdateDataGridView();
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            newRowId = e.Row.Index;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
