﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SWG_Expertise_Calcualtor
{
    class GuiController
    {
        public void TabHoverControls()
        {
            Jedi jedi = new Jedi();
            if (jedi.GeneralTabHover == true)
            {
                jedi.JediGeneral.BackColor = Color.Blue;
            }
        }

        public void ButtonSound()
        {
            System.Media.SoundPlayer Audio = new System.Media.SoundPlayer();
            Audio.SoundLocation = Path.Combine(Application.StartupPath, "sound\\beeping_timer.wav");
            Audio.Play();
        }

        public void ExpertiseButtonSound()
        {
            System.Media.SoundPlayer Audio = new System.Media.SoundPlayer();
            Audio.SoundLocation = Path.Combine(Application.StartupPath, "sound\\ui_select_popup.wav");
            Audio.Play();
        }
    }
}
