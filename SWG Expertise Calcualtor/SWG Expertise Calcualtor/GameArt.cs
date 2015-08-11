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
    public partial class GameArt : Form
    {
        public GameArt()
        {
            InitializeComponent();
        }

        GuiController gc = new GuiController();

        private void NextButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void NextButton2_Click(object sender, EventArgs e)
        {

        }

        private void GameArt_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartUpPage sup = new StartUpPage();
            sup.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void GameArt_Load(object sender, EventArgs e)
        {
            gc.GameArtMusic();
        }
    }
}
