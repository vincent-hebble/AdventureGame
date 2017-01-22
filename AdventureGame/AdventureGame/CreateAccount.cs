using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(password1TextBox.Text == password2TextBox.Text)
            {

            }
            else
            {
                MessageBox.Show("Passwords did not match", "Account Creation Unsuccesful", MessageBoxButtons.OK);
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
