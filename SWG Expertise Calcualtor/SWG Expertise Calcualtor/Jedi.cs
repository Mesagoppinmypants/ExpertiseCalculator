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

        // First Row
        public int strpoints = 0;
        public int conpoints = 0;
        public int agipoints = 0;
        public int stapoints = 0;

        // Second Row
        public int hspoints = 0;

        // Third Row
        public int swpoints = 0;

        private void Jedi_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartUpPage start = new StartUpPage();
            start.Visible = true;
        }

        // Page Functions

        // Makes sure that the required level is correct -- Finish this
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
        }

        // Changes the backgrounds for each row when the user hits a certain amount of totalPoints -- Fix this
        private void CheckSecondRowBackgrounds()
        {
            if (totalPoints <= 40)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBox;
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

        private void EnhancedStrength_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedStrengthBackground.Image = Properties.Resources.aSkillBoxGreen;
        }

        private void EnhancedStrength_MouseHover(object sender, EventArgs e)
        {
            EnhancedStrengthBackground.Image = Properties.Resources.aSkillBoxGreen;
        }

        private void EnhancedStrength_MouseLeave(object sender, EventArgs e)
        {
            EnhancedStrengthBackground.Image = Properties.Resources.aSkillBox;
        }

        private void Jedi_Load(object sender, EventArgs e)
        {

        }

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
        }

        private void EnhancedConstitution_MouseHover(object sender, EventArgs e)
        {
            EnhancedConstitutionBackground.Image = Properties.Resources.aSkillBoxGreen;
        }

        private void EnhancedConstitution_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedConstitutionBackground.Image = Properties.Resources.aSkillBoxGreen;
        }

        private void EnhancedConstitution_MouseLeave(object sender, EventArgs e)
        {
            EnhancedConstitutionBackground.Image = Properties.Resources.aSkillBox;
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
        }

        private void EnhancedAgility_MouseHover(object sender, EventArgs e)
        {
            EnhancedAgilityBackground.Image = Properties.Resources.aSkillBoxGreen;
        }

        private void EnhancedAgility_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedAgilityBackground.Image = Properties.Resources.aSkillBoxGreen;
        }

        private void EnhancedAgility_MouseLeave(object sender, EventArgs e)
        {
            EnhancedAgilityBackground.Image = Properties.Resources.aSkillBox;
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
        }

        private void EnhancedStamina_MouseHover(object sender, EventArgs e)
        {
            EnhancedStaminaBackground.Image = Properties.Resources.aSkillBoxGreen;
        }

        private void EnhancedStamina_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedStaminaBackground.Image = Properties.Resources.aSkillBoxGreen;
        }

        private void EnhancedStamina_MouseLeave(object sender, EventArgs e)
        {
            EnhancedStaminaBackground.Image = Properties.Resources.aSkillBox;
        }

        // Heightened Speed
        private void HeightenedSpeed_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && hspoints <= 2 && hspoints > 0)
            {
                totalPoints++;
                hspoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && hspoints >= 0 && hspoints < 2)
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
        }

        private void HeightenedSpeed_MouseLeave(object sender, EventArgs e)
        {
            if (totalPoints <= 40)
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
            if (totalPoints <= 40)
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
            if (totalPoints <= 40)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void windgrayed_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && swpoints <= 2 && swpoints > 0)
            {
                totalPoints++;
                swpoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && swpoints >= 0 && swpoints < 2 && hspoints == 4)
            {
                totalPoints--;
                swpoints++;
            }

            if (swpoints >= 1)
            {
                SecondWind.Visible = false;
            }

            if (swpoints == 1)
            {
                sw1.Visible = true;
            }

            if (swpoints == 2)
            {

            }

            if (swpoints == 0)
            {
                sw1.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
        }

        private void wind_Click(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true && swpoints <= 2 && swpoints > 0 && totalPoints >= 40)
            {
                totalPoints++;
                swpoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && swpoints >= 0 && swpoints < 2)
            {
                totalPoints--;
                swpoints++;
            }

            if (swpoints >= 1)
            {
                SecondWind.Visible = false;
            }

            if (swpoints == 0)
            {
                SecondWind.Visible = true;
                sw1.Visible = false;
            }

            if (swpoints == 1)
            {

            }

            if (swpoints == 2)
            {
                sw1.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
        }

        private void windgrayed_MouseHover(object sender, EventArgs e)
        {
            if (hspoints == 4)
            {

            }
            else
            {

            }
        }

        private void windgrayed_MouseMove(object sender, MouseEventArgs e)
        {
            if (hspoints == 4)
            {

            }
            else
            {

            }
        }

        private void windgrayed_MouseLeave(object sender, EventArgs e)
        {

        }

        private void wind_MouseHover(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing the save button function. This button isn't implemented yet.");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing the reset button function. This button isn't implemented yet.");
        }       
    }
}
