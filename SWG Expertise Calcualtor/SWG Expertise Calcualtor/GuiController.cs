using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWG_Expertise_Calcualtor
{
    class GuiController
    {
        public void CheckBoxCheck()
        {
            Jedi jedi = new Jedi();
            if (jedi.AddPoints.Checked == false)
            {
                jedi.RemovePoints.Checked = true;
            }
        }
    }
}
