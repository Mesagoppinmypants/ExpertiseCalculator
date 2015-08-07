using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWG_Expertise_Calcualtor
{
    class TotalPointsService
    {
        private readonly object levelOutput;
        int totalPoints = 0;
        public void CheckLevel()
        {
            if (totalPoints >= 40)
            {
                levelOutput.Text = "10";
            }

            if (totalPoints == 39)
            {
                levelOutput.Text = "12";
            }

            if (totalPoints == 38)
            {
                levelOutput.Text = "14";
            }

            if (totalPoints == 37)
            {
                levelOutput.Text = "16";
            }

            if (totalPoints == 36)
            {
                levelOutput.Text = "18";
            }

            if (totalPoints == 35)
            {
                levelOutput.Text = "20";
            }

            if (totalPoints == 34)
            {
                levelOutput.Text = "22";
            }

            if (totalPoints == 33)
            {
                levelOutput.Text = "24";
            }

            if (totalPoints == 32)
            {
                levelOutput.Text = "26";
            }

            if (totalPoints == 31)
            {
                levelOutput.Text = "28";
            }

            if (totalPoints == 30)
            {
                levelOutput.Text = "30";
            }

            if (totalPoints == 29)
            {
                levelOutput.Text = "32";
            }

            if (totalPoints == 28)
            {
                levelOutput.Text = "34";
            }

            if (totalPoints == 27)
            {
                levelOutput.Text = "36";
            }

            if (totalPoints == 26)
            {
                levelOutput.Text = "38";
            }

            if (totalPoints == 25)
            {
                levelOutput.Text = "40";
            }

            if (totalPoints == 24)
            {
                levelOutput.Text = "42";
            }

            if (totalPoints == 23)
            {
                levelOutput.Text = "44";
            }

            if (totalPoints == 22)
            {
                levelOutput.Text = "46";
            }

            if (totalPoints == 21)
            {
                levelOutput.Text = "48";
            }

            if (totalPoints == 20)
            {
                levelOutput.Text = "50";
            }

            if (totalPoints == 19)
            {
                levelOutput.Text = "52";
            }

            if (totalPoints == 18)
            {
                levelOutput.Text = "54";
            }

            if (totalPoints == 17)
            {
                levelOutput.Text = "56";
            }

            if (totalPoints == 16)
            {
                levelOutput.Text = "58";
            }

            if (totalPoints == 15)
            {
                levelOutput.Text = "60";
            }

            if (totalPoints == 14)
            {
                levelOutput.Text = "62";
            }

            if (totalPoints == 13)
            {
                levelOutput.Text = "64";
            }

            if (totalPoints == 12)
            {
                levelOutput.Text = "66";
            }

            if (totalPoints == 11)
            {
                levelOutput.Text = "68";
            }

            if (totalPoints == 10)
            {
                levelOutput.Text = "70";
            }

            if (totalPoints == 9)
            {
                levelOutput.Text = "72";
            }

            if (totalPoints == 8)
            {
                levelOutput.Text = "74";
            }

            if (totalPoints == 7)
            {
                levelOutput.Text = "76";
            }

            if (totalPoints == 6)
            {
                levelOutput.Text = "78";
            }

            if (totalPoints == 5)
            {
                levelOutput.Text = "80";
            }

            if (totalPoints == 4)
            {
                levelOutput.Text = "82";
            }

            if (totalPoints == 3)
            {
                levelOutput.Text = "84";
            }

            if (totalPoints == 2)
            {
                levelOutput.Text = "86";
            }

            if (totalPoints == 1)
            {
                levelOutput.Text = "88";
            }

            if (totalPoints == 0)
            {
                levelOutput.Text = "90";
            }
        }
    }
}
