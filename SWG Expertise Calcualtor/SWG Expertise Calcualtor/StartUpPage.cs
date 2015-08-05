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
    public partial class StartUpPage : Form
    {
        public StartUpPage()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Jedi jedi = new Jedi();
                jedi.Show();
                Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartUpPage_Load(object sender, EventArgs e)
        {

        }
    }
}
