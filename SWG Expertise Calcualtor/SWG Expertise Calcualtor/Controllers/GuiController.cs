using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
    }
}
