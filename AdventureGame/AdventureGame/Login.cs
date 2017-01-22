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

        public Login()
        {
            InitializeComponent();
        }

        private void getUser(string userName, string userPassword)
        {
           AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            var idQuery = (from user in dbcontext.userTables
                             where user.username == userName &&
                                   user.password == userPassword
                             select user).SingleOrDefault();

            var objectQuery = (from obj in dbcontext.idTables
                               where obj.objectID == "userID"
                               select obj).SingleOrDefault();

            objectQuery.ID = idQuery.ID;

            dbcontext.SaveChanges();

            dbcontext.Dispose();
        }

        private bool isUserValid(string userName, string userPassword)
        {
              AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

               var loginQuery = from valid in dbcontext.userTables
                                 where valid.username == userName &&
                                       valid.password == userPassword
                                 select valid;

            if (loginQuery.Any())
            {
                dbcontext.Dispose();
                getUser(userName, userPassword);
                return true;

            }
            else
            {
                return false;
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isUserValid(userNameTextBox.Text, passwordTextBox.Text))
            {
                Adventure game = new Adventure();
                game.Show();
                game.FormClosed += new FormClosedEventHandler(game_FormClosed);
                this.Hide();

                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password","Login Unsuccesful",MessageBoxButtons.OK);

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

        void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        void account_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
