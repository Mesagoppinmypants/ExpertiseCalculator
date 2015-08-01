﻿using System;
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
            add.Checked = true;
        }

        public int totalPoints = 45;
        public int strpoints = 0;

        private void Jedi_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartUpPage start = new StartUpPage();
            start.Visible = true;
        }

        private void strength_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox15.Visible = true;
        }

        private void strength_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox15.Visible = false;
        }

        private void strength_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox15.Visible = true;
        }

        private void strengthgrayed_MouseHover(object sender, EventArgs e)
        {
            pictureBox15.Visible = true;
        }

        private void strengthgrayed_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
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
                strength2.Visible = true;
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
                strength2.Visible = false;
            }

            if (strpoints == 2)
            {
                strength1.Visible = false;
                strength2.Visible = true;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }
    }
}
