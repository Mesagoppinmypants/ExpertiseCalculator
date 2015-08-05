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
            CheckState();
            add.Checked = true;
        }

        /*
            Available To Spec:
            aSkillBox = 1
            aSkillBoxGreen = 2
            aSkillBoxRed = 3

            Not Available to Spec:
            iSkillBox = 4
            iSkillBoxGreen = 5
            iSkillBoxRed = 6
        */
        GuiController gc = new GuiController();

        public int totalPoints = 45;

        public int strpoints = 0;
        public int conpoints = 0;
        public int agipoints = 0;
        public int stapoints = 0;

        public int hspoints = 0;

        public int swpoints = 0;

        private void Jedi_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartUpPage start = new StartUpPage();
            start.Visible = true;
        }

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

        private void CheckState()
        {
            if  (totalPoints > 40)
            {
                Speed4.Visible = true;
            }
        }

        // Enhanced Strength
        private void strength_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void strength_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void strength_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void strengthgrayed_MouseHover(object sender, EventArgs e)
        {
            strength1.Image = pictureBox40.Image = Properties.Resources.aGraceInMotion;
        }

        private void strengthgrayed_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Jedi_Load(object sender, EventArgs e)
        {

        }

        private void strengthgrayed_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && strpoints <= 2 && strpoints > 0)
                {
                    totalPoints++;
                    strpoints--;
                }
                
            if (add.Checked == true && totalPoints > 0 && strpoints >= 0 && strpoints < 2)
                {
                    totalPoints--;
                    strpoints++;
                }

            if (strpoints >= 1)
            {
                strengthgrayed.Visible = false;
            }

            if (strpoints == 1)
            {
                strength1.Visible = true;
            }

            if (strpoints == 2)
            {
                
            }

            if (strpoints == 0)
            {
                strength1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add.Checked = false;
            remove.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add.Checked = true;
            remove.Checked = false;
        }

        private void add_CheckedChanged(object sender, EventArgs e)
        {
            if (add.Checked == true)
            {
                remove.Checked = false;
            }
        }

        private void remove_CheckedChanged(object sender, EventArgs e)
        {
            if (remove.Checked == true)
            {
                add.Checked = false;
            }
        }

        private void strength_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && strpoints <= 2 && strpoints > 0)
            {
                totalPoints++;
                strpoints--;
            }

            if (add.Checked == true && totalPoints > 0 && strpoints >= 0 && strpoints < 2)
            {
                totalPoints--;
                strpoints++;
            }

            if (strpoints >= 1)
            {
                strengthgrayed.Visible = false;
            }

            if (strpoints == 0)
            {
                strengthgrayed.Visible = true;
                strength1.Visible = false;
            }

            if (strpoints == 1)
            {
                strength1.Visible = true;
            }

            if (strpoints == 2)
            {
                strength1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void CheckCheckBox()
        {
            if (add.Checked == false)
            {
                remove.Checked = true;
            }
        }

        // Enhanced Constitution    
        private void congrayed_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && conpoints <= 2 && conpoints > 0)
            {
                totalPoints++;
                conpoints--;
            }

            if (add.Checked == true && totalPoints > 0 && conpoints >= 0 && conpoints < 2)
            {
                totalPoints--;
                conpoints++;
            }

            if (conpoints >= 1)
            {
                congrayed.Visible = false;
            }

            if (conpoints == 1)
            {
                con1.Visible = true;
            }

            if (conpoints == 2)
            {
            }

            if (conpoints == 0)
            {
                con1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void congrayed_MouseHover(object sender, EventArgs e)
        {
        }

        private void congrayed_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void congrayed_MouseLeave(object sender, EventArgs e)
        {
        }

        private void strengthgrayed_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void con_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && conpoints <= 2 && conpoints > 0)
            {
                totalPoints++;
                conpoints--;
            }

            if (add.Checked == true && totalPoints > 0 && conpoints >= 0 && conpoints < 2)
            {
                totalPoints--;
                conpoints++;
            }

            if (conpoints >= 1)
            {
                congrayed.Visible = false;
            }

            if (conpoints == 0)
            {
                congrayed.Visible = true;
                con1.Visible = false;
            }

            if (conpoints == 1)
            {
                con1.Visible = true;
            }

            if (conpoints == 2)
            {
                con1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void con_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void con_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void con_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        // Enhanced Agility
        private void agilitygrayed_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && agipoints <= 2 && agipoints > 0)
            {
                totalPoints++;
                agipoints--;
            }

            if (add.Checked == true && totalPoints > 0 && agipoints >= 0 && agipoints < 2)
            {
                totalPoints--;
                agipoints++;
            }

            if (agipoints >= 1)
            {
                agilitygrayed.Visible = false;
            }

            if (agipoints == 1)
            {
                agility1.Visible = true;
            }

            if (agipoints == 2)
            {

            }

            if (agipoints == 0)
            {
                agility1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void agility_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && agipoints <= 2 && agipoints > 0)
            {
                totalPoints++;
                agipoints--;
            }

            if (add.Checked == true && totalPoints > 0 && agipoints >= 0 && agipoints < 2)
            {
                totalPoints--;
                agipoints++;
            }

            if (agipoints >= 1)
            {
                agilitygrayed.Visible = false;
            }

            if (agipoints == 0)
            {
                agilitygrayed.Visible = true;
                agility1.Visible = false;
            }

            if (agipoints == 1)
            {
                agility1.Visible = true;
            }

            if (agipoints == 2)
            {
                agility1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void agilitygrayed_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void agilitygrayed_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void agilitygrayed_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void agility_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void agility_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void agility_MouseLeave(object sender, EventArgs e)
        {
            
        }

        // Enhanced Stamina
        private void staminagrayed_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && stapoints <= 2 && stapoints > 0)
            {
                totalPoints++;
                stapoints--;
            }

            if (add.Checked == true && totalPoints > 0 && stapoints >= 0 && stapoints < 2)
            {
                totalPoints--;
                stapoints++;
            }

            if (stapoints >= 1)
            {
                staminagrayed.Visible = false;
            }

            if (stapoints == 1)
            {
                stam1.Visible = true;
            }

            if (stapoints == 2)
            {
                
            }

            if (stapoints == 0)
            {
                stam1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void stamina_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && stapoints <= 2 && stapoints > 0 && totalPoints >= 40)
            {
                totalPoints++;
                stapoints--;
            }

            if (add.Checked == true && totalPoints > 0 && stapoints >= 0 && stapoints < 2)
            {
                totalPoints--;
                stapoints++;
            }

            if (stapoints >= 1)
            {
                staminagrayed.Visible = false;
            }

            if (stapoints == 0)
            {
                staminagrayed.Visible = true;
                stam1.Visible = false;
            }

            if (stapoints == 1)
            {
                stam1.Visible = true;
            }

            if (stapoints == 2)
            {
                stam1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void staminagrayed_MouseHover(object sender, EventArgs e)
        {

        }

        private void staminagrayed_MouseLeave(object sender, EventArgs e)
        {

        }

        private void staminagrayed_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void stamina_MouseHover(object sender, EventArgs e)
        {

        }

        private void stamina_MouseLeave(object sender, EventArgs e)
        {

        }

        private void stamina_MouseMove(object sender, MouseEventArgs e)
        {

        }

        // Heightened Speed
        private void speedgrayed_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && hspoints <= 2 && hspoints > 0)
            {
                totalPoints++;
                hspoints--;
            }

            if (add.Checked == true && totalPoints > 0 && hspoints >= 0 && hspoints < 2 && totalPoints <= 40)
            {
                totalPoints--;
                hspoints++;
            }

            if (hspoints >= 1)
            {
                speedgrayed.Visible = false;
            }

            if (hspoints == 1)
            {
                hs1.Visible = true;
            }

            if (hspoints == 2)
            {

            }

            if (hspoints == 3)
            {

            }

            if (hspoints == 4)
            {

            }

            if (stapoints == 0)
            {
                hs1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void speed_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && hspoints <= 4)
            {
                totalPoints++;
                hspoints--;
            }

            if (add.Checked == true && hspoints <= 4 && hspoints < 4)
            {
                totalPoints--;
                hspoints++;
            }

            if (hspoints >= 1)
            {
                speedgrayed.Visible = false;
            }

            if (hspoints == 0)
            {
                speedgrayed.Visible = true;
                hs1.Visible = false;
            }

            if (hspoints == 1)
            {
                hs1.Visible = true;
            }

            if (hspoints == 2)
            {
                hs1.Visible = false;
            }

            if (hspoints == 3)
            {

            }

            if (hspoints == 4)
            {

            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void speedgrayed_MouseHover(object sender, EventArgs e)
        {
            if (totalPoints <= 40)
            {

            }
            else
            {

            }
        }

        private void speedgrayed_MouseMove(object sender, MouseEventArgs e)
        {
            if (totalPoints <= 40)
            {

            }
            else
            {

            }
        }

        private void speedgrayed_MouseLeave(object sender, EventArgs e)
        {

        }

        private void speed_MouseHover(object sender, EventArgs e)
        {

        }

        private void speed_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void speed_MouseLeave(object sender, EventArgs e)
        {

        }

        private void windgrayed_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && swpoints <= 2 && swpoints > 0)
            {
                totalPoints++;
                swpoints--;
            }

            if (add.Checked == true && totalPoints > 0 && swpoints >= 0 && swpoints < 2 && hspoints == 4)
            {
                totalPoints--;
                swpoints++;
            }

            if (swpoints >= 1)
            {
                windgrayed.Visible = false;
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

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void wind_Click(object sender, EventArgs e)
        {
            if (remove.Checked == true && swpoints <= 2 && swpoints > 0 && totalPoints >= 40)
            {
                totalPoints++;
                swpoints--;
            }

            if (add.Checked == true && totalPoints > 0 && swpoints >= 0 && swpoints < 2)
            {
                totalPoints--;
                swpoints++;
            }

            if (swpoints >= 1)
            {
                windgrayed.Visible = false;
            }

            if (swpoints == 0)
            {
                windgrayed.Visible = true;
                sw1.Visible = false;
            }

            if (swpoints == 1)
            {

            }

            if (swpoints == 2)
            {
                sw1.Visible = false;
            }

            TotalPointLabel.Text = totalPoints.ToString();
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
