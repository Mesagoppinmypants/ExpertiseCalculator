using System;
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
            gc.ProgramButtonSound();
            GameArt ga = new GameArt();
            ga.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuiController gc = new GuiController();
            gc.ProgramButtonSound();
            GameMusic gm = new GameMusic();
            gm.Show();
            Visible = false;
        }
    }
}
