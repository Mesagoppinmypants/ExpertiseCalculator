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

        public void ProgramButtonSound()
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

        public void GameArtMusic()
        {
            System.Media.SoundPlayer Audio = new System.Media.SoundPlayer();
            Audio.SoundLocation = Path.Combine(Application.StartupPath, "sound\\mus_battle_of_the_heroes.wav");
            Audio.Play();
        }

        public void DefaultHoverSound()
        {
            System.Media.SoundPlayer Audio = new System.Media.SoundPlayer();
            Audio.SoundLocation = Path.Combine(Application.StartupPath, "sound\\ui_rollover.wav");
            Audio.Play();
        }
    }
}
