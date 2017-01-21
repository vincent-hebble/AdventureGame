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
    public partial class AdventureGame : Form
    {
        public AdventureGame()
        {
            InitializeComponent();
        }

        private void AdventureGame_Load(object sender, EventArgs e)
        {
            this.Show();
            inputTextBox.Focus();
        }

        private void inputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Text = inputTextBox.Text;
                inputTextBox.Text = "";
                nameText.Text = Text;
                commandTextBox.Text += (Text + '\n');
            }
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
