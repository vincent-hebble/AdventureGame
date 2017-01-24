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

        int[] raceStatModifier = new int[6];
        int[] classStatModifier = new int[6];
        

        private int[] standardArray = new int[6];

        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void refreshStatBonus()
        {
            strengthLabel.Text = ("+" + (raceStatModifier[0] + classStatModifier[0]));
            constitutionLabel.Text = ("+" + (raceStatModifier[1] + classStatModifier[1]));
            dexterityLabel.Text = ("+" + (raceStatModifier[2] + classStatModifier[2]));
            charismaLabel.Text = ("+" + (raceStatModifier[3] + classStatModifier[3]));
            wisdomLabel.Text = ("+" + (raceStatModifier[4] + classStatModifier[4]));
            intelligenceLabel.Text = ("+" + (raceStatModifier[5] + classStatModifier[5]));

            for (int i = 0; i < 6; ++i)
            {
                if (raceStatModifier[i] + classStatModifier[i] > 0)
                {
                    switch(i)
                    {
                        case 0: strengthLabel.Visible = true; break;
                        case 1: constitutionLabel.Visible = true; break;
                        case 2: dexterityLabel.Visible = true; break;
                        case 3: charismaLabel.Visible = true; break;
                        case 4: wisdomLabel.Visible = true; break;
                        case 5: intelligenceLabel.Visible = true; break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0: strengthLabel.Visible = false; break;
                        case 1: constitutionLabel.Visible = false; break;
                        case 2: dexterityLabel.Visible = false; break;
                        case 3: charismaLabel.Visible = false; break;
                        case 4: wisdomLabel.Visible = false; break;
                        case 5: intelligenceLabel.Visible = false; break;
                    }
                }
            }
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
            MessageBox.Show("", "Race Info", MessageBoxButtons.OK);
        }

        private void classInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", "Class Info", MessageBoxButtons.OK);
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
                            "Character creation unsuccessful", MessageBoxButtons.OK);
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

        //Strength = 0, Constitution = 1, Dexterity = 2, 
        //Charisma = 3, Wisdom = 4, Intelligence = 5

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = raceComboBox.Text;

            if(selection == "Human")
            {
                for(int i = 0; i < 6; ++i)
                {
                    if(i == 3)
                    {
                        raceStatModifier[i] = 2;
                    }
                    else
                    {
                        raceStatModifier[i] = 0;
                    }
                }
            }
            else if (selection == "Elf")
            {
                for (int i = 0; i < 6; ++i)
                {
                    if (i == 4)
                    {
                        raceStatModifier[i] = 2;
                    }
                    else
                    {
                        raceStatModifier[i] = 0;
                    }
                }
            }
            else if (selection == "Orc")
            {
                for (int i = 0; i < 6; ++i)
                {
                    if (i == 0)
                    {
                        raceStatModifier[i] = 2;
                    }
                    else
                    {
                        raceStatModifier[i] = 0;
                    }
                }
            }

            refreshStatBonus();
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = classComboBox.Text;

            if (selection == "Warrior")
            {
                for (int i = 0; i < 6; ++i)
                {
                    if (i == 1)
                    {
                        classStatModifier[i] = 2;
                    }
                    else
                    {
                        classStatModifier[i] = 0;
                    }
                }
            }
            else if (selection == "Sorcerer")
            {
                for (int i = 0; i < 6; ++i)
                {
                    if (i == 5)
                    {
                        classStatModifier[i] = 2;
                    }
                    else
                    {
                        classStatModifier[i] = 0;
                    }
                }
            }
            else if (selection == "Ranger")
            {
                for (int i = 0; i < 6; ++i)
                {
                    if (i == 2)
                    {
                        classStatModifier[i] = 2;
                    }
                    else
                    {
                        classStatModifier[i] = 0;
                    }
                }
            }

            refreshStatBonus();
        }
    }
}
