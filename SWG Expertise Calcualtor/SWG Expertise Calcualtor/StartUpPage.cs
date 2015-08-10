using SWG_Expertise_Calcualtor.Controllers.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SWG_Expertise_Calcualtor
{
    public partial class StartUpPage : Form
    {
        public StartUpPage()
        {
            InitializeComponent();
        }

        private void OpenExpertiseCalculatorButton_Click(object sender, EventArgs e)
        {
            ExpertiseCalcStart calc = new ExpertiseCalcStart();
            calc.Show();
            //WindowState = FormWindowState.Minimized;
        }

        private void SoundtrackStart_Click(object sender, EventArgs e)
        {
            SWGGameArchives gaa = new SWGGameArchives();
            gaa.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBoxService mbs = new MessageBoxService();
            //mbs.InformationDisabled();
            PanelForInformationButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelForInformationButton.Visible = false;
        }

        private void CurrentGameFeatures_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.projectswg.com/topic/34195-status-of-implemented-features-holocore/");
        }

        private void StaffMembers_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.projectswg.com/index.php?app=forums&module=extras&section=stats&do=leaders");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.projectswg.com/topic/34114-roadmap-for-holocore-revised-roadmap-as-of-292015/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.projectswg.com/page/policies.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.projectswg.com/topic/33827-project-swg-financial-report/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.projectswg.com/page/credits.html");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://bitbucket.org/projectswg/holocore");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.projectswg.com/page/about_us.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
