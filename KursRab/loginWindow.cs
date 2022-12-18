using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursRab
{
    public partial class loginWindow : Form
    {
        public loginWindow()
        {
            InitializeComponent();
            loginTextBox.Text = "admin";
            passwordTextBox.Text = "admin";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.Equals(loginTextBox.Text, "admin") && string.Equals(passwordTextBox.Text, "admin"))
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Closed += delegate(object o, EventArgs args) { Close(); };
                adminWindow.Show();
                Visible = false;
            }
            if (string.Equals(loginTextBox.Text, "user") && string.Equals(passwordTextBox.Text, "user"))
            {
                UserWindow userWindow = new UserWindow();
                userWindow.Closed += delegate(object o, EventArgs args) { Close(); };
                userWindow.Show();
                Visible = false;
            }
        }
    }
}
