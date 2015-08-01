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
        }

        public int totalPoints = 45;

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

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox15.Visible = true;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
        }

        private void Jedi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                totalPoints--;
            }
            else
            {
                totalPoints++;
            }

            TotalPointLabel.Text = totalPoints.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
