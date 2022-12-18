using System;
using System.Data.OleDb;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KursRab
{
    public partial class AddNewCustomerWindow : Form
    {
        private const string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = kursRab.mdb;";
        private OleDbConnection conn = new OleDbConnection(connectionString);

        private string regexStringName = "([А-ЯЁ][а-яё]+[\\-\\s]?){3,}";
        private string regexStringPhone = "^((\\+7|7|8)+([0-9]){10})$";

        public bool IsCreatedNewCustomer;

        private AdminWindow adminWindow;

        public AddNewCustomerWindow(AdminWindow adminWindow)
        {
            this.adminWindow = adminWindow;
            conn.Open();
            InitializeComponent();
        }

        public void FillNameTextBox(string name)
        {
            NameTextBox.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsCreatedNewCustomer = false;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Regex.Match(NameTextBox.Text, regexStringName).Success)
            {
                if (Regex.Match(PhoneTextBox.Text, regexStringPhone).Success)
                {
                    if (AddressTextBox.Text != string.Empty)
                    {
                        new OleDbCommand(
                            $"INSERT INTO customers(fio, telephone, address) VALUES(\"{NameTextBox.Text}\", " +
                            $"\"{PhoneTextBox.Text}\", " +
                            $"\"{AddressTextBox.Text}\")", conn).ExecuteNonQuery();
                        IsCreatedNewCustomer = true;

                        OleDbDataReader CustomerNameReader =
                            new OleDbCommand($"SELECT id, fio FROM customers WHERE fio = \"{NameTextBox.Text}\"", conn)
                                .ExecuteReader();
                        CustomerNameReader.Read();
                        adminWindow.id = CustomerNameReader.GetInt32(0);
                        adminWindow.name = NameTextBox.Text;
                        adminWindow.phone = PhoneTextBox.Text;
                        adminWindow.address = AddressTextBox.Text;

                        CustomerNameReader.Dispose();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Не заполнен адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неправильно указан номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неправильно указано имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
