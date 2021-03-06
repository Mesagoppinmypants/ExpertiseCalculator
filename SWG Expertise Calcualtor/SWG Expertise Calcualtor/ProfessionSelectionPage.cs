﻿using SWG_Expertise_Calcualtor.Controllers.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SWG_Expertise_Calcualtor
{
    public partial class ProfessionSelectionPage : Form
    {
        GuiController gc = new GuiController();

        public ProfessionSelectionPage()
        {
            InitializeComponent();
            ProfessionSelection.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProfessionSelection.SelectedIndex != 0)
            {
                gc.ProgramButtonSound();
            }

            if (ProfessionSelection.SelectedIndex == 1)
            {
                Jedi jedi = new Jedi();
                jedi.Show();
                Visible = false;
            }

            MessageBoxService mbs = new MessageBoxService();

            if (ProfessionSelection.SelectedIndex == 2)
            {
                mbs.BountyHunterDisabled();
                ProfessionSelection.SelectedIndex = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void ExpertiseCalcStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartUpPage sup = new StartUpPage();
        }
    }
}
