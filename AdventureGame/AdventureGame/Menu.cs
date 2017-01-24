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
    public partial class Menu : Form
    {
        DatabaseCalls data = new DatabaseCalls();

        private bool hasCharacter;

        public Menu()
        {
            InitializeComponent();
        }

        private void playGame()
        {
            hasCharacter = data.userHasCharacter();

            if (!hasCharacter)
            {
                continueButton.Enabled = false;
            }
            else
            {
                continueButton.Enabled = true;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            playGame();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Adventure game = new Adventure();
            game.Show();
            game.FormClosed += new FormClosedEventHandler(game_FormClosed);
            this.Hide();
        }

        private void newCharacterButton_Click(object sender, EventArgs e)
        {
            if(hasCharacter)
            {
                DialogResult result = MessageBox.Show("You already have a character. Creating a new character will delete your current one. Do you wish to continue?", "Caution!!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        data.deleteCharacter();
                        CreateCharacter createCharacter = new CreateCharacter();
                        createCharacter.Show();
                        createCharacter.FormClosed += new FormClosedEventHandler(createCharacter_FormClosed);
                        this.Hide();
                        playGame();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something happened!!! oops!\n\n" + ex.Message + "",
                            "Character creation unsuccesful", MessageBoxButtons.OK);
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Continue Adventuring and May Glory come to thy name", "Glad to see you stay", MessageBoxButtons.OK);
                }
            }
            else
            {
                CreateCharacter createCharacter = new CreateCharacter();
                createCharacter.Show();
                createCharacter.FormClosed += new FormClosedEventHandler(createCharacter_FormClosed);
                this.Hide();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        void createCharacter_FormClosed(object sender, FormClosedEventArgs e)
        {
            playGame();
            this.Show();
        }
    }

}
