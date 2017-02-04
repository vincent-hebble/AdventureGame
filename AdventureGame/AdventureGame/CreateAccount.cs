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
    public partial class CreateAccount : Form
    {
        DatabaseCalls data = new DatabaseCalls();

        public CreateAccount()
        {
            InitializeComponent();
            this.AcceptButton = createButton;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && password1TextBox.Text != "" && password2TextBox.Text != "")
            {
                if (password1TextBox.Text == password2TextBox.Text)
                {
                    if (data.accountCheck(usernameTextBox.Text))
                    {
                        try
                        {
                            data.createUser(usernameTextBox.Text, password1TextBox.Text);
                            MessageBox.Show("Congratulations!!!", "Account Creation Successful", MessageBoxButtons.OK);
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Something Happened", "Account Creation Unsuccessful", MessageBoxButtons.OK);
                            password1TextBox.Text = "";
                            password2TextBox.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Name already exists", "Account Creation Unsuccessful", MessageBoxButtons.OK);
                        usernameTextBox.Text = "";
                        password1TextBox.Text = "";
                        password2TextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Passwords did not match", "Account Creation Unsuccessful", MessageBoxButtons.OK);
                    password1TextBox.Text = "";
                    password2TextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty", "Account Creation Unsuccessful", MessageBoxButtons.OK);
                usernameTextBox.Text = "";
                password1TextBox.Text = "";
                password2TextBox.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            password1TextBox.Text = "";
            password2TextBox.Text = "";
        }

        private void returnToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
