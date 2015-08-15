using System.Windows.Forms;

namespace SWG_Expertise_Calcualtor
{
    public partial class GameMusic : Form
    {
        public GameMusic()
        {
            InitializeComponent();
        }

        private void GameMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartUpPage sup = new StartUpPage();
            sup.Visible = true;
        }
    }
}
