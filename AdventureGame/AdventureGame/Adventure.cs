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
    public partial class Adventure : Form
    {
        public Adventure()
        {
            InitializeComponent();
        }

        private int getUserID()
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();
            var idQuery = (from id in dbcontext.idTables
                                where id.objectID == "userID"
                                select id.ID).Single();

            return idQuery.Value;
        }

        private void AdventureGame_Load(object sender, EventArgs e)
        {
            int ID = getUserID();

            this.Show();
            inputTextBox.Focus();
            levelText.Text = ID.ToString();
        }

        private void inputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Input = inputTextBox.Text;
                inputTextBox.Text = "";
                nameText.Text = Input;
                commandTextBox.Text += (Input + '\n');
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
