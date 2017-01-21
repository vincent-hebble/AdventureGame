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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AdventureGame game = new AdventureGame();
            game.Show();
            game.FormClosed += new FormClosedEventHandler(game_FormClosed);
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
