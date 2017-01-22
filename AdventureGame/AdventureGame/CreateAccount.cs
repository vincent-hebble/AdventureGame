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
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && password1TextBox.Text != "" && password2TextBox.Text != "")
            {
                if (password1TextBox.Text == password2TextBox.Text)
                {
                    AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

                    var checkQuery = from check in dbcontext.userTables
                                     where check.username == usernameTextBox.Text
                                     select check;

                    if (!checkQuery.Any())
                    {
                        userTable data = new userTable
                        {
                            password = password1TextBox.Text,
                            username = usernameTextBox.Text
                        };

                        try
                        {
                            dbcontext.userTables.Add(data);
                            dbcontext.SaveChanges();
                            dbcontext.Dispose();
                            MessageBox.Show("Congratulations!!!", "Account Creation Succesful", MessageBoxButtons.OK);
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Something Happened", "Account Creation Unsuccesful", MessageBoxButtons.OK);
                            password1TextBox.Text = "";
                            password2TextBox.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Name already exists", "Account Creation Unsuccesful", MessageBoxButtons.OK);
                        usernameTextBox.Text = "";
                        password1TextBox.Text = "";
                        password2TextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Passwords did not match", "Account Creation Unsuccesful", MessageBoxButtons.OK);
                    password1TextBox.Text = "";
                    password2TextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty", "Account Creation Unsuccesful", MessageBoxButtons.OK);
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
    }
}
