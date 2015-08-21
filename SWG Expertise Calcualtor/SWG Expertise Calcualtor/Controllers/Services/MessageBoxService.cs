using System.Windows.Forms;

namespace SWG_Expertise_Calcualtor.Controllers.Services
{
    class MessageBoxService
    {
        // Start Up Page
        public void SaveButton()
        {
            MessageBox.Show("Testing the save button function. This button isn't implemented yet.");
        }

        public void ResetButton()
        {
            MessageBox.Show("Testing the reset button function. This button is implemented, but very buggy and still in testing phase.");
        }

        public void BountyHunterDisabled()
        {
            MessageBox.Show("Sorry, the Bounty Hunter expertise tree isn't implemented yet.");
        }

        // StartUp
        public void SoundtrackDisabled()
        {
            MessageBox.Show("Sorry, the soundtrack part of this application isn't implemented yet.");
        }

        public void InformationDisabled()
        {
            MessageBox.Show("Sorry, this function isn't implemented yet.");
        }

        public void ExpertiseAlreadyOpen()
        {
            MessageBox.Show("The expertise calculator is already open, please use the one that's currently open.");
        }
    }
}
