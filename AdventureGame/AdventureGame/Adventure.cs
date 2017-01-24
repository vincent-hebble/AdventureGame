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
        DatabaseCalls data = new DatabaseCalls();

        string characterName = "", characterClass = "", characterRace = "";
        int strength = 0, constitution = 0, dexterity = 0, charisma = 0, wisdom = 0, intelligence = 0;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        int hp = 0, mana = 0, stamina = 0, level = 0, experience = 0;

        public Adventure()
        {
            InitializeComponent();
        }

        private void updateHUD()
        {
            nameText.Text = characterName; classText.Text = characterClass; raceText.Text = characterRace;
            levelText.Text = level.ToString(); experienceText.Text = experience.ToString(); strengthText.Text = strength.ToString();
            constitutionText.Text = constitution.ToString(); dexterityText.Text = dexterity.ToString();
            charismaText.Text = charisma.ToString(); wisdomText.Text = wisdom.ToString(); intelligenceText.Text = intelligence.ToString();
            hpText.Text = hp.ToString(); manaText.Text = mana.ToString(); staminaText.Text = stamina.ToString();
        }

        private void AdventureGame_Load(object sender, EventArgs e)
        {
            data.getCharacter(ref characterName, ref characterClass, ref characterRace, ref level, ref experience,
                              ref strength, ref constitution, ref dexterity, ref charisma, ref wisdom, ref intelligence,
                              ref hp, ref mana, ref stamina);

            updateHUD();

            this.Show();
            inputTextBox.Focus();
        }

        private void inputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Input = inputTextBox.Text;
                inputTextBox.Text = "";
                commandTextBox.Text += (Input + '\n');
                commandTextBox.SelectionStart = commandTextBox.Text.Length;
                commandTextBox.ScrollToCaret();
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
