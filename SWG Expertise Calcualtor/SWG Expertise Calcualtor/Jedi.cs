using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWG_Expertise_Calcualtor
{
    public partial class Jedi : Form
    {
        public Jedi()
        {
            InitializeComponent();
            AddPoints.Checked = true;
        }

        GuiController gc = new GuiController();

        public int totalPoints = 45;

        // Mouse Hover Status
        // First Row
        public bool EnhancedStrengthHover = false;
        public bool EnhancedConstitutionHover = false;
        public bool EnhancedAgilityHover = false;
        public bool EnhancedStaminaHover = false;

        // Skill Points
        // First Row
        public int strpoints = 0;
        public int conpoints = 0;
        public int agipoints = 0;
        public int stapoints = 0;

        // Second Row
        public int hspoints = 0;
        public int espoints = 0;

        // Third Row
        public int swpoints = 0;

        private void Jedi_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartUpPage start = new StartUpPage();
            start.Visible = true;
        }

        // Page Functions

        private void CheckFunctions()
        {
            CheckLevel();
            CheckBackgrounds();
        }

        // Save Button and Reset Button Functions
        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing the save button function. This button isn't implemented yet.");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing the reset button function. This button isn't implemented yet.");
        }

        // Makes sure that the required level is correct
        private void CheckLevel()
        {
            if (totalPoints >= 40)
            {
                levelOutput.Text = "10";
            }

            if (totalPoints == 39)
            {
                levelOutput.Text = "12";
            }

            if (totalPoints == 38)
            {
                levelOutput.Text = "14";
            }

            if (totalPoints == 37)
            {
                levelOutput.Text = "16";
            }

            if (totalPoints == 36)
            {
                levelOutput.Text = "18";
            }

            if (totalPoints == 35)
            {
                levelOutput.Text = "20";
            }

            if (totalPoints == 34)
            {
                levelOutput.Text = "22";
            }

            if (totalPoints == 33)
            {
                levelOutput.Text = "24";
            }

            if (totalPoints == 32)
            {
                levelOutput.Text = "26";
            }

            if (totalPoints == 31)
            {
                levelOutput.Text = "28";
            }

            if (totalPoints == 30)
            {
                levelOutput.Text = "30";
            }

            if (totalPoints == 29)
            {
                levelOutput.Text = "32";
            }

            if (totalPoints == 28)
            {
                levelOutput.Text = "34";
            }

            if (totalPoints == 27)
            {
                levelOutput.Text = "36";
            }

            if (totalPoints == 26)
            {
                levelOutput.Text = "38";
            }

            if (totalPoints == 25)
            {
                levelOutput.Text = "40";
            }

            if (totalPoints == 24)
            {
                levelOutput.Text = "42";
            }

            if (totalPoints == 23)
            {
                levelOutput.Text = "44";
            }

            if (totalPoints == 22)
            {
                levelOutput.Text = "46";
            }

            if (totalPoints == 21)
            {
                levelOutput.Text = "48";
            }

            if (totalPoints == 20)
            {
                levelOutput.Text = "50";
            }

            if (totalPoints == 19)
            {
                levelOutput.Text = "52";
            }

            if (totalPoints == 18)
            {
                levelOutput.Text = "54";
            }

            if (totalPoints == 17)
            {
                levelOutput.Text = "56";
            }

            if (totalPoints == 16)
            {
                levelOutput.Text = "58";
            }

            if (totalPoints == 15)
            {
                levelOutput.Text = "60";
            }

            if (totalPoints == 14)
            {
                levelOutput.Text = "62";
            }

            if (totalPoints == 13)
            {
                levelOutput.Text = "64";
            }

            if (totalPoints == 12)
            {
                levelOutput.Text = "66";
            }

            if (totalPoints == 11)
            {
                levelOutput.Text = "68";
            }

            if (totalPoints == 10)
            {
                levelOutput.Text = "70";
            }

            if (totalPoints == 9)
            {
                levelOutput.Text = "72";
            }

            if (totalPoints == 8)
            {
                levelOutput.Text = "74";
            }

            if (totalPoints == 7)
            {
                levelOutput.Text = "76";
            }

            if (totalPoints == 6)
            {
                levelOutput.Text = "78";
            }

            if (totalPoints == 5)
            {
                levelOutput.Text = "80";
            }

            if (totalPoints == 4)
            {
                levelOutput.Text = "82";
            }

            if (totalPoints == 3)
            {
                levelOutput.Text = "84";
            }

            if (totalPoints == 2)
            {
                levelOutput.Text = "86";
            }

            if (totalPoints == 1)
            {
                levelOutput.Text = "88";
            }

            if (totalPoints == 0)
            {
                levelOutput.Text = "90";
            }
        }

        // Changes the backgrounds for each row when the user hits a certain amount of totalPoints -- Fix this
        private void CheckBackgrounds()
        {
            if (totalPoints <= 41)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBox;
                ExactingStrikesBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBox;
                ExactingStrikesBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        // Changes the background for each skill if they are hovered.
        private void CheckBackgroundsHover()
        {
            if (EnhancedStrengthHover == true)
            {
                EnhancedStrengthBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                EnhancedStrengthBackground.Image = Properties.Resources.aSkillBox;
            }

            if (EnhancedConstitutionHover == true)
            {
                EnhancedConstitutionBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                EnhancedConstitutionBackground.Image = Properties.Resources.aSkillBox;
            }

            if (EnhancedAgilityHover == true)
            {
                EnhancedAgilityBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                EnhancedAgilityBackground.Image = Properties.Resources.aSkillBox;
            }

            if (EnhancedStaminaHover == true)
            {
                EnhancedStaminaBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                EnhancedConstitutionBackground.Image = Properties.Resources.aSkillBox;
            }
        }

        // Makes sure that either add/remove points checkbox is checked
        private void AddPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (AddPoints.Checked == true)
            {
                RemovePoints.Checked = false;
            }
        }

        private void RemovePoints_CheckedChanged(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true)
            {
                AddPoints.Checked = false;
            }
        }

        // Enhanced Strength

        private void EnhancedStrength_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && strpoints <= 2 && strpoints > 0)
            {
                totalPoints++;
                strpoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && strpoints >= 0 && strpoints < 2)
            {
                totalPoints--;
                strpoints++;
            }

            if (strpoints >= 1)
            {
                EnhancedStrengthPoints.Visible = true;
                EnhancedStrength.Image = Properties.Resources.aEnhancedStrength;
            }

            if (strpoints == 1)
            {
                EnhancedStrengthPoints.Image = Properties.Resources.skillpoints1;
            }

            if (strpoints == 2)
            {
                EnhancedStrengthPoints.Image = Properties.Resources.skillpoints2;
            }

            if (strpoints == 0)
            {
                EnhancedStrength.Image = Properties.Resources.iEnhancedStrength;
                EnhancedStrengthPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            CheckFunctions();
        }

        private void EnhancedStrength_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedStrengthHover = true;
            CheckBackgroundsHover();
        }

        private void EnhancedStrength_MouseHover(object sender, EventArgs e)
        {
            EnhancedStrengthHover = true;
            CheckBackgroundsHover();
        }

        private void EnhancedStrength_MouseLeave(object sender, EventArgs e)
        {
            EnhancedStrengthHover = false;
            CheckBackgroundsHover();
        }

        // Enhanced Constitution    
        private void EnhancedConstitution_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && conpoints <= 2 && conpoints > 0)
            {
                totalPoints++;
                conpoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && conpoints >= 0 && conpoints < 2)
            {
                totalPoints--;
                conpoints++;
            }

            if (conpoints >= 1)
            {
                EnhancedConstitutionPoints.Visible = true;
                EnhancedConstitution.Image = Properties.Resources.aEnhancedConstitution;
            }

            if (conpoints == 1)
            {
                EnhancedConstitutionPoints.Image = Properties.Resources.skillpoints1;
            }

            if (conpoints == 2)
            {
                EnhancedConstitutionPoints.Image = Properties.Resources.skillpoints2;
            }

            if (conpoints == 0)
            {
                EnhancedConstitution.Image = Properties.Resources.iEnhancedConstitution;
                EnhancedConstitutionPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            CheckFunctions();
        }

        private void EnhancedConstitution_MouseHover(object sender, EventArgs e)
        {
            EnhancedConstitutionHover = true;
            CheckBackgroundsHover();
        }

        private void EnhancedConstitution_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedConstitutionHover = true;
            CheckBackgroundsHover();
        }

        private void EnhancedConstitution_MouseLeave(object sender, EventArgs e)
        {
            EnhancedConstitutionHover = false;
            CheckBackgroundsHover();
        }

        // Enhanced Agility
        private void EnhancedAgility_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && agipoints <= 2 && agipoints > 0)
            {
                totalPoints++;
                agipoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && agipoints >= 0 && agipoints < 2)
            {
                totalPoints--;
                agipoints++;
            }

            if (agipoints >= 1)
            {
                EnhancedAgilityPoints.Visible = true;
                EnhancedAgility.Image = Properties.Resources.aEnhancedAgility;
            }

            if (agipoints == 1)
            {
                EnhancedAgilityPoints.Image = Properties.Resources.skillpoints1;
            }

            if (agipoints == 2)
            {
                EnhancedAgilityPoints.Image = Properties.Resources.skillpoints2;
            }

            if (agipoints == 0)
            {
                EnhancedAgility.Image = Properties.Resources.iEnhancedAgility;
                EnhancedAgilityPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            CheckFunctions();
        }

        private void EnhancedAgility_MouseHover(object sender, EventArgs e)
        {
            EnhancedAgilityHover = true;
            CheckBackgroundsHover();
        }

        private void EnhancedAgility_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedAgilityHover = true;
            CheckBackgroundsHover();
        }

        private void EnhancedAgility_MouseLeave(object sender, EventArgs e)
        {
            EnhancedAgilityHover = false;
            CheckBackgroundsHover();
        }

        // Enhanced Stamina
        private void EnhancedStamina_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && stapoints <= 2 && stapoints > 0)
            {
                totalPoints++;
                stapoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && stapoints >= 0 && stapoints < 2)
            {
                totalPoints--;
                stapoints++;
            }

            if (stapoints >= 1)
            {
                EnhancedStaminaPoints.Visible = true;
                EnhancedStamina.Image = Properties.Resources.aEnhancedStamina;
            }

            if (stapoints == 1)
            {
                EnhancedStaminaPoints.Image = Properties.Resources.skillpoints1;
            }

            if (stapoints == 2)
            {
                EnhancedStaminaPoints.Image = Properties.Resources.skillpoints2;
            }

            if (stapoints == 0)
            {
                EnhancedStamina.Image = Properties.Resources.iEnhancedStamina;
                EnhancedStaminaPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            CheckFunctions();
        }

        private void EnhancedStamina_MouseHover(object sender, EventArgs e)
        {
            EnhancedStaminaHover = true;
            CheckBackgroundsHover();
        }

        private void EnhancedStamina_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedStaminaHover = true;
            CheckBackgroundsHover();
        }

        private void EnhancedStamina_MouseLeave(object sender, EventArgs e)
        {
            EnhancedStaminaHover = false;
            CheckBackgroundsHover();
        }

        // Heightened Speed
        private void HeightenedSpeed_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && hspoints <= 4 && hspoints > 0)
            {
                totalPoints++;
                hspoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && hspoints >= 0 && hspoints < 4)
            {
                totalPoints--;
                hspoints++;
            }

            if (hspoints >= 1)
            {
                HeightenedSpeedPoints.Visible = true;
                HeightenedSpeed.Image = Properties.Resources.aHeightenedSpeed;
            }

            if (hspoints == 1)
            {
                HeightenedSpeedPoints.Image = Properties.Resources.skillpoints1;
            }

            if (hspoints == 2)
            {
                HeightenedSpeedPoints.Image = Properties.Resources.skillpoints2;
            }

            if (hspoints == 3)
            {
                HeightenedSpeedPoints.Image = Properties.Resources.skillpoints3;
            }

            if (hspoints == 4)
            {
                HeightenedSpeedPoints.Image = Properties.Resources.skillpoints4;
            }

            if (hspoints == 0)
            {
                HeightenedSpeed.Image = Properties.Resources.iHeightenedSpeed;
                HeightenedSpeedPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            CheckFunctions();
        }

        private void HeightenedSpeed_MouseLeave(object sender, EventArgs e)
        {
            if (totalPoints <= 41)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        private void HeightenedSpeed_MouseHover(object sender, EventArgs e)
        {
            if (totalPoints <= 41)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void HeightenedSpeed_MouseMove(object sender, MouseEventArgs e)
        {
            if (totalPoints <= 41)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        // Exacting Strikes
        private void ExactingStrikes_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && espoints <= 4 && espoints > 0)
            {
                totalPoints++;
                espoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && espoints >= 0 && espoints < 4)
            {
                totalPoints--;
                espoints++;
            }

            if (espoints >= 1)
            {
                ExactingStrikesPoints.Visible = true;
                ExactingStrikes.Image = Properties.Resources.aExactingStrikes;
            }

            if (espoints == 1)
            {
                ExactingStrikesPoints.Image = Properties.Resources.skillpoints1;
            }

            if (espoints == 2)
            {
                ExactingStrikesPoints.Image = Properties.Resources.skillpoints2;
            }

            if (espoints == 3)
            {
                ExactingStrikesPoints.Image = Properties.Resources.skillpoints3;
            }

            if (espoints == 4)
            {
                ExactingStrikesPoints.Image = Properties.Resources.skillpoints4;
            }

            if (espoints == 0)
            {
                ExactingStrikes.Image = Properties.Resources.iExactingStrikes;
                ExactingStrikesPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            CheckFunctions();
        }

        private void ExactingStrikes_MouseHover(object sender, EventArgs e)
        {
            if (totalPoints <= 41)
            {
                ExactingStrikesBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ExactingStrikesBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ExactingStrikes_MouseMove(object sender, MouseEventArgs e)
        {
            if (totalPoints <= 41)
            {
                ExactingStrikesBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ExactingStrikesBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ExactingStrikes_MouseLeave(object sender, EventArgs e)
        {
            if (totalPoints <= 41)
            {
                ExactingStrikesBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                ExactingStrikesBackground.Image = Properties.Resources.iSkillBox;
            }
        }
    }
}
