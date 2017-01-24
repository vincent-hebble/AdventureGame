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
    public partial class CreateCharacter : Form
    {
        DatabaseCalls data = new DatabaseCalls();

        private int[] standardArray = new int[6];

        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void reset()
        {
            characterNameTextBox.Text = "";
            raceComboBox.Text = "Human";
            classComboBox.Text = "Warrior";
            strengthComboBox.Text = "16";
            constitutionComboBox.Text = "14";
            dexterityComboBox.Text = "13";
            charismaComboBox.Text = "12";
            wisdomComboBox.Text = "11";
            intelligenceComboBox.Text = "10";
        }

        private bool isStandardArray()
        {
            int[] test = { 0, 0, 0, 0, 0, 0 };

            bool isStandardArray = true;

            standardArray[0] = Convert.ToInt32(strengthComboBox.Text);
            standardArray[1] = Convert.ToInt32(constitutionComboBox.Text);
            standardArray[2] = Convert.ToInt32(dexterityComboBox.Text);
            standardArray[3] = Convert.ToInt32(charismaComboBox.Text);
            standardArray[4] = Convert.ToInt32(wisdomComboBox.Text);
            standardArray[5] = Convert.ToInt32(intelligenceComboBox.Text);

            for(int i = 0; i < 6; ++i)
            {
                switch(standardArray[i])
                {
                    case 16: test[0]++; break;
                    case 14: test[1]++; break;
                    case 13: test[2]++; break;
                    case 12: test[3]++; break;
                    case 11: test[4]++; break;
                    case 10: test[5]++; break;
                }
            }

            for(int i = 0; i <6; ++i)
            {
                if(test[i] != 1)
                {
                    isStandardArray = false;
                }
            }

            return isStandardArray;
        }

        private void raceInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void classInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void CreateCharacter_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (characterNameTextBox.Text != "")
            {
                if(isStandardArray())
                {
                    string name = characterNameTextBox.Text;
                    string race = raceComboBox.Text;
                    string characterClass = classComboBox.Text;

                    try {
                        data.createCharacter(name, race, characterClass, standardArray[0], standardArray[1], standardArray[2],
                            standardArray[3], standardArray[4], standardArray[5]);

                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Something happened!!! oops!\n\n" + ex.Message + "",
                            "Character creation unsuccesful", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("The stat values are not entered correctly make sure there is a unique value in each fied and resubmit", "Stats entered incorrectly!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Name field cannot be empty", "Name field blank", MessageBoxButtons.OK);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = raceComboBox.Text;

            if(selection == "Human")
            {
                charismaLabel.Text = "+2";
                strengthLabel.Text = "";
                wisdomLabel.Text = "";
            }
            else if (selection == "Elf")
            {
                charismaLabel.Text = "";
                strengthLabel.Text = "";
                wisdomLabel.Text = "+2";
            }
            else if (selection == "Orc")
            {
                charismaLabel.Text = "";
                strengthLabel.Text = "+2";
                wisdomLabel.Text = "";
            }
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = classComboBox.Text;

            if (selection == "Warrior")
            {
                constitutionLabel.Text = "+2";
                intelligenceLabel.Text = "";
                dexterityLabel.Text = "";
            }
            else if (selection == "Sorcerer")
            {
                constitutionLabel.Text = "";
                intelligenceLabel.Text = "+2";
                dexterityLabel.Text = "";
            }
            else if (selection == "Ranger")
            {
                constitutionLabel.Text = "";
                intelligenceLabel.Text = "";
                dexterityLabel.Text = "+2";
            }
        }
    }
}
