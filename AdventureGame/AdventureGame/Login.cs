using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace AdventureGame
{
    public partial class Login : Form
    {
        DatabaseCalls data = new DatabaseCalls();

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (data.isUserValid(userNameTextBox.Text, passwordTextBox.Text))
            {
                Menu menu = new Menu();
                menu.Show();
                menu.FormClosed += new FormClosedEventHandler(menu_FormClosed);
                this.Hide();

                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password","Login Unsuccessful",MessageBoxButtons.OK);

                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount account = new CreateAccount();
            account.Show();
            account.FormClosed += new FormClosedEventHandler(account_FormClosed);
            this.Hide();
        }

        void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        void account_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
