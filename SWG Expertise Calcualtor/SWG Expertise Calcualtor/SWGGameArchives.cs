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
    public partial class SWGGameArchives : Form
    {
        public SWGGameArchives()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuiController gc = new GuiController();
            gc.ButtonSound();
            GameArt ga = new GameArt();
            ga.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuiController gc = new GuiController();
            gc.ButtonSound();
            GameMusic gm = new GameMusic();
            gm.Show();
            Visible = false;
        }
    }
}
