﻿using SWG_Expertise_Calcualtor.Controllers.Services;
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
    public partial class ExpertiseCalcStart : Form
    {
        public ExpertiseCalcStart()
        {
            InitializeComponent();
            ProfessionSelection.SelectedIndex = 0;
            var pos = PointToScreen(ExitButton.Location);
            pos = TopRightCornerGraphic.PointToClient(pos);
            ExitButton.Parent = TopRightCornerGraphic;
            ExitButton.Location = pos;
            ExitButton.BackColor = Color.Transparent;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
