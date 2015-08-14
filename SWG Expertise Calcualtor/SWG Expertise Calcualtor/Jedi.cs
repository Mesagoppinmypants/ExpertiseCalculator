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

namespace SWG_Expertise_Calcualtor
{
    public partial class Jedi : Form
    {
        public Jedi()
        {
            InitializeComponent();
            AddPoints.Checked = true;
        }

        GuiController gc = new GuiController();
        MessageBoxService mbs = new MessageBoxService();
        TotalPointsService tps = new TotalPointsService();

        public int totalPoints = 45;

        // Mouse Hover Status
        // First Row
        public bool EnhancedStrengthHover = false;
        public bool EnhancedConstitutionHover = false;
        public bool EnhancedAgilityHover = false;
        public bool EnhancedStaminaHover = false;

        // Second Row
        public bool HeightenedSpeedHover = false;
        public bool ExactingStrikesHover = false;
        public bool AlacrityHover = false;
        public bool ImprovedForceThrowHover = false;

        // Third Row
        public bool SecondWindHover = false;
        public bool GraceInMotionHover = false;
        public bool ForceCloakHover = false;
        public bool PremonitionHover = false;
        public bool ImprovedCripplingAccuracyHover = false;

        // Fourth Row
        public bool FidelityHover = false;
        public bool ImprovedSaberBlockHover = false;
        public bool DefensiveFightingHover = false;

        // Fifth Row
        public bool IncisivenessHover = false;
        public bool ImprovedForceCloakHover = false;
        public bool ImprovedForceShockwaveHover = false;
        public bool ForceShockwaveHover = false;

        // Skill Tree Tabs
        public bool GeneralTabHover = false;

        // Skill Points
        // First Row
        public int strpoints = 0;
        public int conpoints = 0;
        public int agipoints = 0;
        public int stapoints = 0;

        // Second Row
        public int hspoints = 0;
        public int espoints = 0;
        public int apoints = 0;
        public int iftpoints = 0;

        // Third Row
        public int swpoints = 0;
        public int gimpoints = 0;
        public int fcpoints = 0;
        public int ppoints = 0;
        public int icapoints = 0;

        // Fourth Row
        public int fpoints = 0;
        public int isbpoints = 0;
        public int dfpoints = 0;

        // Fifth Row
        public int ipoints = 0;
        public int ifcpoints = 0;
        public int ifspoints = 0;
        public int fspoints = 0;

        private void Jedi_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExpertiseCalcStart start = new ExpertiseCalcStart();
            start.Visible = true;
        }

        private void Jedi_Load(object sender, EventArgs e)
        {
            SkillPicture.Visible = false;
        }

        // Page Functions

        private void PageFunctions()
        {
            CheckLevel();
            CheckBackgrounds();
            CheckSkillRank();
            CheckBackgroundsHover();
            SkillDescriptionVisiblity();
            SkillDescription();
            CheckRequirements();
            HideSecondRankRow();
        }

        // Save Button and Reset Button Functions
        private void SaveButton_Click(object sender, EventArgs e)
        {
            mbs.SaveButton();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            mbs.ResetButton();
        }

        // Makes sure that the required level is correct
        private void CheckLevel()
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
            
            //tps.CheckLevelTest();
        }

        // Changes the backgrounds for each row when the user hits a certain amount of totalPoints -- Finish this for the other rows
        private void CheckBackgrounds()
        {
            // Second Row
            if (totalPoints <= 41)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBox;
                ExactingStrikesBackground.Image = Properties.Resources.aSkillBox;
                AlacrityBackground.Image = Properties.Resources.aSkillBox;
                ImprovedForceThrowBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBox;
                ExactingStrikesBackground.Image = Properties.Resources.iSkillBox;
                AlacrityBackground.Image = Properties.Resources.iSkillBox;
                ImprovedForceThrowBackground.Image = Properties.Resources.iSkillBox;
            }

            // Third Row
            if (totalPoints <= 37)
            {
                GraceInMotionBackground.Image = Properties.Resources.aSkillBox;
                ForceCloakBackground.Image = Properties.Resources.aSkillBox;
                PremonitionBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                GraceInMotionBackground.Image = Properties.Resources.iSkillBox;
                ForceCloakBackground.Image = Properties.Resources.iSkillBox;
                PremonitionBackground.Image = Properties.Resources.iSkillBox;
            }

            // Second Wind
            if (totalPoints <= 37 && hspoints == 4)
            {
                SecondWindBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                SecondWindBackground.Image = Properties.Resources.iSkillBox;
            }

            // Improved Crippling Accuracy
            if (totalPoints <= 37 && iftpoints == 2)
            {
                ImprovedCripplingAccuracyBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                ImprovedCripplingAccuracyBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        // This controls the skill description visibility
        private void SkillDescriptionVisiblity()
        {
            // Enables the general titles and descriptions that all skills use -- Basically dump all hovers here
            if (EnhancedStrengthHover || EnhancedConstitutionHover || EnhancedAgilityHover || EnhancedStaminaHover || HeightenedSpeedHover || ExactingStrikesHover || AlacrityHover || ImprovedForceThrowHover || SecondWindHover || GraceInMotionHover || ForceCloakHover == true)
            {
                SkillPictureBackground.Visible = true;
                SkillPicture.Visible = true;
                SkillTitle.Visible = true;
                SkillSummary.Visible = true;
                RequiresLabel.Visible = true;
                SkillRequirements1.Visible = true;
                RankLabel.Visible = true;
                SkillRank.Visible = true;
                GrantsModifiersLabel.Visible = true;
                SkillModifierTitle1.Visible = true;
                Rank1Modifier1.Visible = true;
                Rank2Modifier1.Visible = true;
            }

            // Rank 4 Modifiers - 2 Rows
            if (ExactingStrikesHover == true)
            {
                SkillModifierTitle2.Visible = true;
                Rank1Modifier2.Visible = true;
                Rank2Modifier2.Visible = true;
                Rank3Modifier2.Visible = true;
                Rank4Modifier2.Visible = true;
            }

            // Rank 2 Modifiers - 2 Requirements
            if (SecondWindHover == true)
            {
                SkillRequirements2.Visible = true;
            }
            else
            {
                SkillRequirements2.Visible = false;
            }

            // New Abilities
            if (ForceCloakHover == true)
            {
                CommandPanel.Visible = true;
            }
            else
            {
                CommandPanel.Visible = false;
            }
        }

        private void SkillDescription()
        {
            // Enhanced Strength
            if (EnhancedStrengthHover == true)
            {
                SkillPicture.Image = Properties.Resources.aEnhancedStrength;
                SkillTitle.Text = "ENHANCED STRENGTH";
                SkillSummary.Text = "Strength increased by 25 points per point" + "\r\n" + "spent.";
                SkillRequirements1.Text = "None";
                SkillModifierTitle1.Text = "STRENGTH";
                Rank1Modifier1.Text = " 25 ";
                Rank2Modifier1.Text = " 50 ";

                TwoModifierBoxes();

                if (strpoints == 0)
                {
                    SkillRank.Text = "0/2";
                }

                if (strpoints == 1)
                {
                    SkillRank.Text = "1/2";
                }

                if (strpoints == 2)
                {
                    SkillRank.Text = "2/2";
                }
            }

            // Enhanced Constitution
            if (EnhancedConstitutionHover == true)
            {
                SkillPicture.Image = Properties.Resources.aEnhancedConstitution;
                SkillTitle.Text = "ENHANCED CONSTITUTION";
                SkillSummary.Text = "Constitution increased by 25 points per point" + "\r\n" + "spent.";
                SkillRequirements1.Text = "None";
                SkillModifierTitle1.Text = "CONSTITUTION";
                Rank1Modifier1.Text = " 25 ";
                Rank2Modifier1.Text = " 50 ";

                TwoModifierBoxes();

                if (conpoints == 0)
                {
                    SkillRank.Text = "0/2";
                }

                if (conpoints == 1)
                {
                    SkillRank.Text = "1/2";
                }

                if (conpoints == 2)
                {
                    SkillRank.Text = "2/2";
                }
            }

            // Enhanced Agility
            if (EnhancedAgilityHover == true)
            {
                SkillPicture.Image = Properties.Resources.aEnhancedAgility;
                SkillTitle.Text = "ENHANCED AGILITY";
                SkillSummary.Text = "Agility increased by 25 points per point" + "\r\n" + "spent.";
                SkillRequirements1.Text = "None";
                SkillModifierTitle1.Text = "AGILITY";
                Rank1Modifier1.Text = " 25 ";
                Rank2Modifier1.Text = " 50 ";

                TwoModifierBoxes();

                if (agipoints == 0)
                {
                    SkillRank.Text = "0/2";
                }

                if (agipoints == 1)
                {
                    SkillRank.Text = "1/2";
                }

                if (agipoints == 2)
                {
                    SkillRank.Text = "2/2";
                }
            }

            // Enhanced Stamina
            if (EnhancedStaminaHover == true)
            {
                SkillPicture.Image = Properties.Resources.aEnhancedStamina;
                SkillTitle.Text = "ENHANCED STAMINA";
                SkillSummary.Text = "Stamina increased by 25 points per point" + "\r\n" + "spent.";
                SkillRequirements1.Text = "None";
                SkillModifierTitle1.Text = "STAMINA";
                Rank1Modifier1.Text = " 25 ";
                Rank2Modifier1.Text = " 50 ";

                TwoModifierBoxes();

                if (stapoints == 0)
                {
                    SkillRank.Text = "0/2";
                }

                if (stapoints == 1)
                {
                    SkillRank.Text = "1/2";
                }

                if (stapoints == 2)
                {
                    SkillRank.Text = "2/2";
                }
            }

            // Heightened Speed
            if (HeightenedSpeedHover == true)
            {
                SkillPicture.Image = Properties.Resources.aHeightenedSpeed;
                SkillTitle.Text = "HEIGHTENED SPEED";
                SkillSummary.Text = "Force Run's speed is increased by 10% per" + "\r\n" + "point spent.";
                SkillRequirements1.Text = "4 Points In Jedi General";
                SkillModifierTitle1.Text = "FORCE RUN MOVEMENT";
                Rank1Modifier1.Text = " 10 ";
                Rank2Modifier1.Text = " 20 ";
                Rank3Modifier1.Text = " 30 ";
                Rank4Modifier1.Text = " 40 ";

                FourModifierBoxes();

                if (hspoints == 0)
                {
                    SkillRank.Text = "0/4";
                }

                if (hspoints == 1)
                {
                    SkillRank.Text = "1/4";
                }

                if (hspoints == 2)
                {
                    SkillRank.Text = "2/4";
                }

                if (hspoints == 3)
                {
                    SkillRank.Text = "3/4";
                }

                if (hspoints == 4)
                {
                    SkillRank.Text = "4/4";
                }
            }

            // Exacting Strikes
            if (ExactingStrikesHover == true)
            {
                SkillPicture.Image = Properties.Resources.aExactingStrikes;
                SkillTitle.Text = "EXACTING STRIKES";
                SkillSummary.Text = "Strike and sweep damage is increased by" + "\r\n" + "2% per point spent.";
                SkillRequirements1.Text = "4 Points In Jedi General";
                SkillModifierTitle1.Text = "SWEEP DAMAGE";
                SkillModifierTitle2.Text = "STRIKE DAMAGE";
                Rank1Modifier1.Text = " 2 ";
                Rank2Modifier1.Text = " 4 ";
                Rank3Modifier1.Text = " 6 ";
                Rank4Modifier1.Text = " 8 ";
                Rank1Modifier2.Text = " 2 ";
                Rank2Modifier2.Text = " 4 ";
                Rank3Modifier2.Text = " 6 ";
                Rank4Modifier2.Text = " 8 ";

                FourModifierBoxes();

                if (espoints == 0)
                {
                    SkillRank.Text = "0/4";
                }

                if (espoints == 1)
                {
                    SkillRank.Text = "1/4";
                }

                if (espoints == 2)
                {
                    SkillRank.Text = "2/4";
                }

                if (espoints == 3)
                {
                    SkillRank.Text = "3/4";
                }

                if (espoints == 4)
                {
                    SkillRank.Text = "4/4";
                }
            }

            // Alacrity
            if (AlacrityHover == true)
            {
                SkillPicture.Image = Properties.Resources.aAlacrity;
                SkillTitle.Text = "ALACRITY";
                SkillSummary.Text = "The chance for a blow to glance off you is" + "\r\n" + "increased by 2% per point spent.";
                SkillRequirements1.Text = "4 Points In Jedi General";
                SkillModifierTitle1.Text = "GLANCING BLOW INCREASE";
                Rank1Modifier1.Text = " 2 ";
                Rank2Modifier1.Text = " 4 ";
                Rank3Modifier1.Text = " 6 ";
                Rank4Modifier1.Text = " 8 ";

                FourModifierBoxes();

                if (apoints == 0)
                {
                    SkillRank.Text = "0/4";
                }

                if (apoints == 1)
                {
                    SkillRank.Text = "1/4";
                }

                if (apoints == 2)
                {
                    SkillRank.Text = "2/4";
                }

                if (apoints == 3)
                {
                    SkillRank.Text = "3/4";
                }

                if (apoints == 4)
                {
                    SkillRank.Text = "4/4";
                }
            }

            // Improved Force Throw
            if (ImprovedForceThrowHover == true)
            {
                SkillPicture.Image = Properties.Resources.aImprovedForceThrow;
                SkillTitle.Text = "IMPROVED FORCE THROW";
                SkillSummary.Text = "Force Throw's damage is increased by 5%" + "\r\n" + "per point spent.";
                SkillRequirements1.Text = "4 Points In Jedi General";
                SkillModifierTitle1.Text = "FORCE THROW DAMAGE";
                Rank1Modifier1.Text = " 5 ";
                Rank2Modifier1.Text = " 10 ";

                TwoModifierBoxes();

                if (iftpoints == 0)
                {
                    SkillRank.Text = "0/2";
                }

                if (iftpoints == 1)
                {
                    SkillRank.Text = "1/2";
                }

                if (iftpoints == 2)
                {
                    SkillRank.Text = "2/2";
                }
            }

            // Second Wind
            if (SecondWindHover == true)
            {
                SkillPicture.Image = Properties.Resources.aSecondWind;
                SkillTitle.Text = "SECOND WIND";
                SkillSummary.Text = "Force Run's duration is increased by 2" + "\r\n" + "seconds per point spent.";
                SkillRequirements1.Text = "8 Points In Jedi General";
                SkillRequirements2.Text = "4 Points In Heightened Speed";
                SkillModifierTitle1.Text = "FORCE RUN DURATION";
                Rank1Modifier1.Text = " 2 ";
                Rank2Modifier1.Text = " 4 ";

                TwoModifierBoxes();

                if (swpoints == 0)
                {
                    SkillRank.Text = "0/2";
                }

                if (swpoints == 1)
                {
                    SkillRank.Text = "1/2";
                }

                if (swpoints == 2)
                {
                    SkillRank.Text = "2/2";
                }
            }

            // Grace In Motion
            if (GraceInMotionHover == true)
            {
                SkillPicture.Image = Properties.Resources.aGraceInMotion;
                SkillTitle.Text = "GRACE IN MOTION";
                SkillSummary.Text = "All melee action costs are reduced by 5%" + "\r\n" + "per point spent.";
                SkillRequirements1.Text = "8 Points In Jedi General";
                SkillModifierTitle1.Text = "LIGHTSABER ACTIONS COST";
                Rank1Modifier1.Text = " 5 ";
                Rank2Modifier1.Text = " 10 ";
                Rank3Modifier1.Text = " 15 ";

                TwoModifierBoxes();

                if (gimpoints == 0)
                {
                    SkillRank.Text = "0/3";
                }

                if (gimpoints == 1)
                {
                    SkillRank.Text = "1/3";
                }

                if (gimpoints == 2)
                {
                    SkillRank.Text = "2/3";
                }

                if (gimpoints == 3)
                {
                    SkillRank.Text = "3/3";
                }
            }

            // Force Cloak
            if (ForceCloakHover == true)
            {
                SkillPicture.Image = Properties.Resources.aForceCloak;
                SkillTitle.Text = "FORCE CLOAK";
                SkillSummary.Text = "Grants the ability to use Force Cloak.";
                SkillRequirements1.Text = "8 Points In Jedi General";
                GrantsModifiersLabel.Text = "Grants Command:";
                SkillModifierTitle1.Visible = false;

                TwoModifierBoxes();

                if (fcpoints == 0)
                {
                    SkillRank.Text = "0/1";
                }

                if (fcpoints == 1)
                {
                    SkillRank.Text = "1/1";
                }
            }
        }

        private void OneRankPoints()
        {
            Rank1Modifier1.BackColor = Color.LightGray;
            Rank2Modifier1.BackColor = Color.Transparent;
            Rank3Modifier1.BackColor = Color.Transparent;
            Rank4Modifier1.BackColor = Color.Transparent;
            Rank1Modifier2.BackColor = Color.LightGray;
            Rank2Modifier2.BackColor = Color.Transparent;
            Rank3Modifier2.BackColor = Color.Transparent;
            Rank4Modifier2.BackColor = Color.Transparent;
        }

        private void TwoRankPoints()
        {
            Rank1Modifier1.BackColor = Color.LightGray;
            Rank2Modifier1.BackColor = Color.LightGray;
            Rank3Modifier1.BackColor = Color.Transparent;
            Rank4Modifier1.BackColor = Color.Transparent;
            Rank1Modifier2.BackColor = Color.LightGray;
            Rank2Modifier2.BackColor = Color.LightGray;
            Rank3Modifier2.BackColor = Color.Transparent;
            Rank4Modifier2.BackColor = Color.Transparent;
        }

        private void ThreeRankPoints()
        {
            Rank1Modifier1.BackColor = Color.LightGray;
            Rank2Modifier1.BackColor = Color.LightGray;
            Rank3Modifier1.BackColor = Color.LightGray;
            Rank4Modifier1.BackColor = Color.Transparent;
            Rank1Modifier2.BackColor = Color.LightGray;
            Rank2Modifier2.BackColor = Color.LightGray;
            Rank3Modifier2.BackColor = Color.LightGray;
            Rank4Modifier2.BackColor = Color.Transparent;
        }

        private void FourRankPoints()
        {
            Rank1Modifier1.BackColor = Color.LightGray;
            Rank2Modifier1.BackColor = Color.LightGray;
            Rank3Modifier1.BackColor = Color.LightGray;
            Rank4Modifier1.BackColor = Color.LightGray;
            Rank1Modifier2.BackColor = Color.LightGray;
            Rank2Modifier2.BackColor = Color.LightGray;
            Rank3Modifier2.BackColor = Color.LightGray;
            Rank4Modifier2.BackColor = Color.LightGray;
        }

        private void ZeroRankPoints()
        {
            Rank1Modifier1.BackColor = Color.Transparent;
            Rank2Modifier1.BackColor = Color.Transparent;
            Rank3Modifier1.BackColor = Color.Transparent;
            Rank4Modifier1.BackColor = Color.Transparent;
            Rank1Modifier2.BackColor = Color.Transparent;
            Rank2Modifier2.BackColor = Color.Transparent;
            Rank3Modifier2.BackColor = Color.Transparent;
            Rank4Modifier2.BackColor = Color.Transparent;
        }

        private void CheckSkillRank()
        {
            // Enhanced Strength
            if (strpoints == 0 && EnhancedStrengthHover == true)
            {
                Rank1Modifier1.BackColor = Color.Transparent;
                ZeroRankPoints();
            }

            if (strpoints == 1 && EnhancedStrengthHover == true)
            {
                OneRankPoints();
            }

            if (strpoints == 2 && EnhancedStrengthHover == true)
            {
                TwoRankPoints();
            }

            // Enhanced Constitution
            if (conpoints == 0 && EnhancedConstitutionHover == true)
            {
                ZeroRankPoints();
            }

            if (conpoints == 1 && EnhancedConstitutionHover == true)
            {
                OneRankPoints();
            }

            if (conpoints == 2 && EnhancedConstitutionHover == true)
            {
                TwoRankPoints();
            }

            // Enhanced Agility
            if (agipoints == 0 && EnhancedAgilityHover == true)
            {
                ZeroRankPoints();
            }

            if (agipoints == 1 && EnhancedAgilityHover == true)
            {
                OneRankPoints();
            }

            if (agipoints == 2 && EnhancedAgilityHover == true)
            {
                TwoRankPoints();
            }

            // Enhanced Stamina
            if (stapoints == 0 && EnhancedStaminaHover == true)
            {
                ZeroRankPoints();
            }

            if (stapoints == 1 && EnhancedStaminaHover == true)
            {
                OneRankPoints();
            }

            if (stapoints == 2 && EnhancedStaminaHover == true)
            {
                TwoRankPoints();
            }

            // Heightened Speed
            if (hspoints == 0 && HeightenedSpeedHover == true)
            {
                ZeroRankPoints();
            }

            if (hspoints == 1 && HeightenedSpeedHover == true)
            {
                OneRankPoints();
            }

            if (hspoints == 2 && HeightenedSpeedHover == true)
            {
                TwoRankPoints();
            }

            if (hspoints == 3 && HeightenedSpeedHover == true)
            {
                ThreeRankPoints();
            }

            if (hspoints == 4 && HeightenedSpeedHover == true)
            {
                FourRankPoints();
            }

            // Exacting Strikes
            if (espoints == 0 && ExactingStrikesHover == true)
            {
                ZeroRankPoints();
            }

            if (espoints == 1 && ExactingStrikesHover == true)
            {
                OneRankPoints();
            }

            if (espoints == 2 && ExactingStrikesHover == true)
            {
                TwoRankPoints();
            }

            if (espoints == 3 && ExactingStrikesHover == true)
            {
                ThreeRankPoints();
            }

            if (espoints == 4 && ExactingStrikesHover == true)
            {
                FourRankPoints();
            }

            // Alacrity
            if (apoints == 0 && AlacrityHover == true)
            {
                ZeroRankPoints();
            }

            if (apoints == 1 && AlacrityHover == true)
            {
                OneRankPoints();
            }

            if (apoints == 2 && AlacrityHover == true)
            {
                TwoRankPoints();
            }

            if (apoints == 3 && AlacrityHover == true)
            {
                ThreeRankPoints();
            }

            if (apoints == 4 && AlacrityHover == true)
            {
                FourRankPoints();
            }

            // Improved Force Throw
            if (iftpoints == 0 && ImprovedForceThrowHover == true)
            {
                ZeroRankPoints();
            }

            if (iftpoints == 1 && ImprovedForceThrowHover == true)
            {
                OneRankPoints();
            }

            if (iftpoints == 2 && ImprovedForceThrowHover == true)
            {
                TwoRankPoints();
            }

            // Second Wind
            if (swpoints == 0 && SecondWindHover == true)
            {
                ZeroRankPoints();
            }

            if (swpoints == 1 && SecondWindHover == true)
            {
                OneRankPoints();
            }

            if (swpoints == 2 && SecondWindHover == true)
            {
                TwoRankPoints();
            }

            // Grace In Motion
            if (gimpoints == 0 && GraceInMotionHover == true)
            {
                ZeroRankPoints();
            }

            if (gimpoints == 1 && GraceInMotionHover == true)
            {
                OneRankPoints();
            }

            if (gimpoints == 2 && GraceInMotionHover == true)
            {
                TwoRankPoints();
            }

            if (gimpoints == 3 && GraceInMotionHover == true)
            {
                ThreeRankPoints();
            }
        }
        
        private void OneModifierBoxes()
        {
            Rank1Modifier1.Visible = true;
            Rank2Modifier1.Visible = false;
            Rank3Modifier1.Visible = false;
            Rank4Modifier1.Visible = false;
        }

        private void TwoModifierBoxes()
        {
            Rank1Modifier1.Visible = true;
            Rank2Modifier1.Visible = true;
            Rank3Modifier1.Visible = false;
            Rank4Modifier1.Visible = false;
        }

        private void ThreeModifierBoxes()
        {
            Rank1Modifier1.Visible = true;
            Rank2Modifier1.Visible = true;
            Rank3Modifier1.Visible = true;
            Rank4Modifier1.Visible = false;
        }

        private void FourModifierBoxes()
        {
            Rank1Modifier1.Visible = true;
            Rank2Modifier1.Visible = true;
            Rank3Modifier1.Visible = true;
            Rank4Modifier1.Visible = true;
        }

        private void HideSecondRankRow()
        {
            if (EnhancedStrengthHover || EnhancedConstitutionHover || EnhancedAgilityHover || EnhancedStaminaHover || HeightenedSpeedHover || AlacrityHover || ImprovedForceThrowHover || SecondWindHover || GraceInMotionHover == true)
            {
                SkillModifierTitle2.Visible = false;
                Rank1Modifier2.Visible = false;
                Rank2Modifier2.Visible = false;
                Rank3Modifier2.Visible = false;
                Rank4Modifier2.Visible = false;
            }
        }

        private void CheckRequirements()
        {
            // First Row - No requirements
            if (EnhancedStrengthHover || EnhancedConstitutionHover || EnhancedAgilityHover || EnhancedStaminaHover == true)
            {
                SkillRequirements1.ForeColor = Color.White;
            }

            // Second Row - 4 General Jedi points Needs to be spent
            if (SkillRequirements1.Text == "4 Points In Jedi General" && totalPoints <= 41 && HeightenedSpeedHover || ExactingStrikesHover || AlacrityHover || ImprovedForceThrowHover == true)
            {
                SkillRequirements1.ForeColor = Color.White;
            }

            // Second Wind - 8 Points In Jedi General Requirement
            if (SkillRequirements1.Text == "8 Points In Jedi General" && totalPoints <= 37 && SecondWindHover == true)
            {
                SkillRequirements1.ForeColor = Color.White;
            }

            if (SkillRequirements1.Text == "8 Points In Jedi General" && totalPoints > 37 && SecondWindHover == true)
            {
                SkillRequirements1.ForeColor = Color.Red;
            }

            // Second Wind - 4 Points Required in Heightened Speed
            if (SkillRequirements2.Text == "4 Points In Heightened Speed" && hspoints < 4 && SecondWindHover == true)
            {
                SkillRequirements2.ForeColor = Color.Red;
            }

            if (SkillRequirements2.Text == "4 Points In Heightened Speed" && hspoints == 4 && SecondWindHover == true)
            {
                SkillRequirements2.ForeColor = Color.White;
            }

            // Exacting Strikes
            if (SkillRequirements1.Text == "4 Points In Jedi General" && totalPoints > 41 && ExactingStrikesHover == true)
            {
                SkillRequirements1.ForeColor = Color.Red;
            }

            // Heightened Speed
            if (SkillRequirements1.Text == "4 Points In Jedi General" && totalPoints > 41 && HeightenedSpeedHover == true)
            {
                SkillRequirements1.ForeColor = Color.Red;
            }

            // Alacrity
            if (SkillRequirements1.Text == "4 Points In Jedi General" && totalPoints > 41 && AlacrityHover == true)
            {
                SkillRequirements1.ForeColor = Color.Red;
            }

            // Enhanced Force Throw
            if (SkillRequirements1.Text == "4 Points In Jedi General" && totalPoints > 41 && ImprovedForceThrowHover == true)
            {
                SkillRequirements1.ForeColor = Color.Red;
            }

            // 8 Points In Jedi General
            if (totalPoints <= 37 && ForceCloakHover || GraceInMotionHover == true)
            {
                SkillRequirements1.ForeColor = Color.White;
            }

            if (totalPoints > 37 && ForceCloakHover || GraceInMotionHover == true)
            {
                SkillRequirements1.ForeColor = Color.Red;
            }
        }

        // Changes the background for each skill if they are hovered.
        private void CheckBackgroundsHover()
        {
            // Enhanced Strength
            if (EnhancedStrengthHover == true)
            {
                EnhancedStrengthBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                EnhancedStrengthBackground.Image = Properties.Resources.aSkillBox;
            }

            // Enhanced Constitution
            if (EnhancedConstitutionHover == true)
            {
                EnhancedConstitutionBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                EnhancedConstitutionBackground.Image = Properties.Resources.aSkillBox;
            }

            // Enhanced Agility
            if (EnhancedAgilityHover == true)
            {
                EnhancedAgilityBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                EnhancedAgilityBackground.Image = Properties.Resources.aSkillBox;
            }

            // Enhanced Stamina
            if (EnhancedStaminaHover == true)
            {
                EnhancedStaminaBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                EnhancedStaminaBackground.Image = Properties.Resources.aSkillBox;
            }
        }

        // Makes sure that either add/remove points checkbox is checked
        private void AddPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (AddPoints.Checked == true)
            {
                RemovePoints.Checked = false;
            }
        }

        private void RemovePoints_CheckedChanged(object sender, EventArgs e)
        {
            if (RemovePoints.Checked == true)
            {
                AddPoints.Checked = false;
            }
        }

        // Enhanced Strength

        private void EnhancedStrength_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && strpoints <= 2 && strpoints > 0)
            {
                totalPoints++;
                strpoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && strpoints >= 0 && strpoints < 2)
            {
                totalPoints--;
                strpoints++;
            }

            if (strpoints >= 1)
            {
                EnhancedStrengthPoints.Visible = true;
                EnhancedStrength.Image = Properties.Resources.aEnhancedStrength;
            }

            if (strpoints == 1)
            {
                EnhancedStrengthPoints.Image = Properties.Resources.skillpoints1;
                Rank2Modifier1.BackColor = Color.Transparent;
            }

            if (strpoints == 2)
            {
                EnhancedStrengthPoints.Image = Properties.Resources.skillpoints2;
            }

            if (strpoints == 0)
            {
                EnhancedStrength.Image = Properties.Resources.iEnhancedStrength;
                EnhancedStrengthPoints.Visible = false;
                Rank1Modifier1.BackColor = Color.Transparent;
            }

            if (strpoints == 1 && EnhancedStrengthHover == true)
            {
                OneRankPoints();
            }

            if (strpoints == 2 && EnhancedStrengthHover == true)
            {
                TwoRankPoints();
            } 

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void EnhancedStrength_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedStrengthHover = true;
            PageFunctions();
        }

        private void EnhancedStrength_MouseHover(object sender, EventArgs e)
        {
            EnhancedStrengthHover = true;
            PageFunctions();
        }

        private void EnhancedStrength_MouseLeave(object sender, EventArgs e)
        {
            EnhancedStrengthHover = false;
            PageFunctions();
        }

        // Enhanced Constitution    
        private void EnhancedConstitution_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && conpoints <= 2 && conpoints > 0)
            {
                totalPoints++;
                conpoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && conpoints >= 0 && conpoints < 2)
            {
                totalPoints--;
                conpoints++;
            }

            if (conpoints >= 1)
            {
                EnhancedConstitutionPoints.Visible = true;
                EnhancedConstitution.Image = Properties.Resources.aEnhancedConstitution;
            }

            if (conpoints == 1)
            {
                EnhancedConstitutionPoints.Image = Properties.Resources.skillpoints1;
                Rank2Modifier1.BackColor = Color.Transparent;
            }

            if (conpoints == 2)
            {
                EnhancedConstitutionPoints.Image = Properties.Resources.skillpoints2;
            }

            if (conpoints == 0)
            {
                EnhancedConstitution.Image = Properties.Resources.iEnhancedConstitution;
                EnhancedConstitutionPoints.Visible = false;
                Rank1Modifier1.BackColor = Color.Transparent;
            }

            if (conpoints == 1 && EnhancedConstitutionHover == true)
            {
                OneRankPoints();
            }

            if (conpoints == 2 && EnhancedConstitutionHover == true)
            {
                TwoRankPoints();
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void EnhancedConstitution_MouseHover(object sender, EventArgs e)
        {
            EnhancedConstitutionHover = true;
            PageFunctions();
        }

        private void EnhancedConstitution_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedConstitutionHover = true;
            PageFunctions();
        }

        private void EnhancedConstitution_MouseLeave(object sender, EventArgs e)
        {
            EnhancedConstitutionHover = false;
            PageFunctions();
        }

        // Enhanced Agility
        private void EnhancedAgility_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && agipoints <= 2 && agipoints > 0)
            {
                totalPoints++;
                agipoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && agipoints >= 0 && agipoints < 2)
            {
                totalPoints--;
                agipoints++;
            }

            if (agipoints >= 1)
            {
                EnhancedAgilityPoints.Visible = true;
                EnhancedAgility.Image = Properties.Resources.aEnhancedAgility;
            }

            if (agipoints == 1)
            {
                EnhancedAgilityPoints.Image = Properties.Resources.skillpoints1;
            }

            if (agipoints == 2)
            {
                EnhancedAgilityPoints.Image = Properties.Resources.skillpoints2;
            }

            if (agipoints == 0)
            {
                EnhancedAgility.Image = Properties.Resources.iEnhancedAgility;
                EnhancedAgilityPoints.Visible = false;
            }

            if (agipoints == 1 && EnhancedAgilityHover == true)
            {
                OneRankPoints();
            }

            if (agipoints == 2 && EnhancedAgilityHover == true)
            {
                TwoRankPoints();
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void EnhancedAgility_MouseHover(object sender, EventArgs e)
        {
            EnhancedAgilityHover = true;
            PageFunctions();
        }

        private void EnhancedAgility_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedAgilityHover = true;
            PageFunctions();
        }

        private void EnhancedAgility_MouseLeave(object sender, EventArgs e)
        {
            EnhancedAgilityHover = false;
            PageFunctions();
        }

        // Enhanced Stamina
        private void EnhancedStamina_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && stapoints <= 2 && stapoints > 0)
            {
                totalPoints++;
                stapoints--;
            }

            if (AddPoints.Checked == true && totalPoints > 0 && stapoints >= 0 && stapoints < 2)
            {
                totalPoints--;
                stapoints++;
            }

            if (stapoints >= 1)
            {
                EnhancedStaminaPoints.Visible = true;
                EnhancedStamina.Image = Properties.Resources.aEnhancedStamina;
            }

            if (stapoints == 1)
            {
                EnhancedStaminaPoints.Image = Properties.Resources.skillpoints1;
            }

            if (stapoints == 2)
            {
                EnhancedStaminaPoints.Image = Properties.Resources.skillpoints2;
            }

            if (stapoints == 0)
            {
                EnhancedStamina.Image = Properties.Resources.iEnhancedStamina;
                EnhancedStaminaPoints.Visible = false;
            }

            if (stapoints == 1 && EnhancedStaminaHover == true)
            {
                OneRankPoints();
            }

            if (stapoints == 2 && EnhancedStaminaHover == true)
            {
                TwoRankPoints();
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void EnhancedStamina_MouseHover(object sender, EventArgs e)
        {
            EnhancedStaminaHover = true;
            PageFunctions();
        }

        private void EnhancedStamina_MouseMove(object sender, MouseEventArgs e)
        {
            EnhancedStaminaHover = true;
            PageFunctions();
        }

        private void EnhancedStamina_MouseLeave(object sender, EventArgs e)
        {
            EnhancedStaminaHover = false;
            PageFunctions();
        }

        // Heightened Speed
        private void HeightenedSpeed_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && hspoints <= 4 && hspoints > 0)
            {
                totalPoints++;
                hspoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 41 && hspoints >= 0 && hspoints < 4)
            {
                totalPoints--;
                hspoints++;
            }

            if (hspoints >= 1)
            {
                HeightenedSpeedPoints.Visible = true;
                HeightenedSpeed.Image = Properties.Resources.aHeightenedSpeed;
            }

            if (hspoints == 1)
            {
                HeightenedSpeedPoints.Image = Properties.Resources.skillpoints1;
            }

            if (hspoints == 2)
            {
                HeightenedSpeedPoints.Image = Properties.Resources.skillpoints2;
            }

            if (hspoints == 3)
            {
                HeightenedSpeedPoints.Image = Properties.Resources.skillpoints3;
            }

            if (hspoints == 4)
            {
                HeightenedSpeedPoints.Image = Properties.Resources.skillpoints4;
            }

            if (hspoints == 0)
            {
                HeightenedSpeed.Image = Properties.Resources.iHeightenedSpeed;
                HeightenedSpeedPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void HeightenedSpeed_MouseLeave(object sender, EventArgs e)
        {

            HeightenedSpeedHover = false;
            PageFunctions();
            if (totalPoints <= 41)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        private void HeightenedSpeed_MouseHover(object sender, EventArgs e)
        {
            HeightenedSpeedHover = true;
            PageFunctions();
            if (totalPoints <= 41)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void HeightenedSpeed_MouseMove(object sender, MouseEventArgs e)
        {
            HeightenedSpeedHover = true;
            PageFunctions();
            if (totalPoints <= 41)
            {
                HeightenedSpeedBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                HeightenedSpeedBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        // Exacting Strikes
        private void ExactingStrikes_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && espoints <= 4 && espoints > 0)
            {
                totalPoints++;
                espoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 41 && espoints >= 0 && espoints < 4)
            {
                totalPoints--;
                espoints++;
            }

            if (espoints >= 1)
            {
                ExactingStrikesPoints.Visible = true;
                ExactingStrikes.Image = Properties.Resources.aExactingStrikes;
            }

            if (espoints == 1)
            {
                ExactingStrikesPoints.Image = Properties.Resources.skillpoints1;
            }

            if (espoints == 2)
            {
                ExactingStrikesPoints.Image = Properties.Resources.skillpoints2;
            }

            if (espoints == 3)
            {
                ExactingStrikesPoints.Image = Properties.Resources.skillpoints3;
            }

            if (espoints == 4)
            {
                ExactingStrikesPoints.Image = Properties.Resources.skillpoints4;
            }

            if (espoints == 0)
            {
                ExactingStrikes.Image = Properties.Resources.iExactingStrikes;
                ExactingStrikesPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void ExactingStrikes_MouseHover(object sender, EventArgs e)
        {
            ExactingStrikesHover = true;
            PageFunctions();
            if (totalPoints <= 41)
            {
                ExactingStrikesBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ExactingStrikesBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ExactingStrikes_MouseMove(object sender, MouseEventArgs e)
        {
            ExactingStrikesHover = true;
            PageFunctions();
            if (totalPoints <= 41)
            {
                ExactingStrikesBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ExactingStrikesBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ExactingStrikes_MouseLeave(object sender, EventArgs e)
        {
            ExactingStrikesHover = false;
            PageFunctions();
            if (totalPoints <= 41)
            {
                ExactingStrikesBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                ExactingStrikesBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        // Alacrity
        private void Alacrity_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && apoints <= 4 && apoints > 0)
            {
                totalPoints++;
                apoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 41 && apoints >= 0 && apoints < 4)
            {
                totalPoints--;
                apoints++;
            }

            if (apoints >= 1)
            {
                AlacrityPoints.Visible = true;
                Alacrity.Image = Properties.Resources.aAlacrity;
            }

            if (apoints == 1)
            {
                AlacrityPoints.Image = Properties.Resources.skillpoints1;
            }

            if (apoints == 2)
            {
                AlacrityPoints.Image = Properties.Resources.skillpoints2;
            }

            if (apoints == 3)
            {
                AlacrityPoints.Image = Properties.Resources.skillpoints3;
            }

            if (apoints == 4)
            {
                AlacrityPoints.Image = Properties.Resources.skillpoints4;
            }

            if (apoints == 0)
            {
                Alacrity.Image = Properties.Resources.iAlacrity;
                AlacrityPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void Alacrity_MouseHover(object sender, EventArgs e)
        {
            AlacrityHover = true;
            PageFunctions();
            if (totalPoints <= 41)
            {
                AlacrityBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                AlacrityBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void Alacrity_MouseMove(object sender, MouseEventArgs e)
        {
            if (totalPoints <= 41)
            {
                AlacrityBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                AlacrityBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void Alacrity_MouseLeave(object sender, EventArgs e)
        {
            AlacrityHover = false;
            PageFunctions();
            if (totalPoints <= 41)
            {
                AlacrityBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                AlacrityBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        // Improved Force Throw
        private void ImprovedForceThrow_MouseMove(object sender, MouseEventArgs e)
        {
            ImprovedForceThrowHover = true;
            PageFunctions();
            if (totalPoints <= 41)
            {
                ImprovedForceThrowBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ImprovedForceThrowBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ImprovedForceThrow_MouseHover(object sender, EventArgs e)
        {
            ImprovedForceThrowHover = true;
            PageFunctions();
            if (totalPoints <= 41)
            {
                ImprovedForceThrowBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ImprovedForceThrowBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ImprovedForceThrow_MouseLeave(object sender, EventArgs e)
        {
            ImprovedForceThrowHover = false;
            PageFunctions();
            if (totalPoints <= 41)
            {
                ImprovedForceThrowBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                ImprovedForceThrowBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        private void ImprovedForceThrow_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && ifspoints <= 2 && iftpoints > 0)
            {
                totalPoints++;
                iftpoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 41 && iftpoints >= 0 && iftpoints < 2)
            {
                totalPoints--;
                iftpoints++;
            }

            if (iftpoints >= 1)
            {
                ImprovedForceThrowPoints.Visible = true;
                ImprovedForceThrow.Image = Properties.Resources.aImprovedForceThrow;
            }

            if (iftpoints == 1)
            {
                ImprovedForceThrowPoints.Image = Properties.Resources.skillpoints1;
            }

            if (iftpoints == 2)
            {
                ImprovedForceThrowPoints.Image = Properties.Resources.skillpoints2;
            }

            if (iftpoints == 0)
            {
                ImprovedForceThrow.Image = Properties.Resources.iImprovedForceThrow;
                ImprovedForceThrowPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void SecondWind_MouseHover(object sender, EventArgs e)
        {
            SecondWindHover = true;
            PageFunctions();
            if (totalPoints <= 37 && hspoints == 4)
            {
                SecondWindBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                SecondWindBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void SecondWind_MouseMove(object sender, MouseEventArgs e)
        {
            SecondWindHover = true;
            PageFunctions();
            if (totalPoints <= 37 && hspoints == 4)
            {
                SecondWindBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                SecondWindBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void SecondWind_MouseLeave(object sender, EventArgs e)
        {
            SecondWindHover = false;
            PageFunctions();
            if (totalPoints <= 37 && hspoints == 4)
            {
                SecondWindBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                SecondWindBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        private void SecondWind_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && swpoints <= 2 && swpoints > 0)
            {
                totalPoints++;
                swpoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 37 && swpoints >= 0 && swpoints < 2 && hspoints == 4)
            {
                totalPoints--;
                swpoints++;
            }

            if (swpoints >= 1)
            {
                SecondWindPoints.Visible = true;
                SecondWind.Image = Properties.Resources.aSecondWind;
            }

            if (swpoints == 1)
            {
                SecondWindPoints.Image = Properties.Resources.skillpoints1;
            }

            if (swpoints == 2)
            {
                SecondWindPoints.Image = Properties.Resources.skillpoints2;
            }

            if (swpoints == 0)
            {
                SecondWind.Image = Properties.Resources.iSecondWind;
                SecondWindPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void ImprovedCripplingAccuracy_MouseHover(object sender, EventArgs e)
        {
            ImprovedCripplingAccuracyHover = true;
            PageFunctions();
            if (totalPoints <= 37 && iftpoints == 2)
            {
                ImprovedCripplingAccuracyBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ImprovedCripplingAccuracyBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ImprovedCripplingAccuracy_MouseMove(object sender, MouseEventArgs e)
        {
            ImprovedCripplingAccuracyHover = true;
            PageFunctions();
            if (totalPoints <= 37 && iftpoints == 2)
            {
                ImprovedCripplingAccuracyBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ImprovedCripplingAccuracyBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ImprovedCripplingAccuracy_MouseLeave(object sender, EventArgs e)
        {
            ImprovedCripplingAccuracyHover = false;
            PageFunctions();
            if (totalPoints <= 37 && iftpoints == 2)
            {
                ImprovedCripplingAccuracyBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                ImprovedCripplingAccuracyBackground.Image = Properties.Resources.iSkillBox;
            }
        }      

        private void Premonition_MouseMove(object sender, MouseEventArgs e)
        {
            PremonitionHover = true;
            PageFunctions();
            if (totalPoints <= 37)
            {
                PremonitionBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                PremonitionBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void Premonition_MouseHover(object sender, EventArgs e)
        {
            PremonitionHover = true;
            PageFunctions();
            if (totalPoints <= 37)
            {
                PremonitionBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                PremonitionBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void Premonition_MouseLeave(object sender, EventArgs e)
        {
            PremonitionHover = false;
            PageFunctions();
            if (totalPoints <= 37)
            {
                PremonitionBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                PremonitionBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        private void JediGeneral_MouseMove(object sender, MouseEventArgs e)
        {
            GeneralTabHover = true;
            gc.TabHoverControls();
        }

        private void JediGeneral_MouseHover(object sender, EventArgs e)
        {
            GeneralTabHover = true;
            gc.TabHoverControls();
        }

        // Grace In Motion
        private void GraceInMotion_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && gimpoints <= 3 && gimpoints > 0)
            {
                totalPoints++;
                gimpoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 37 && gimpoints >= 0 && gimpoints < 3)
            {
                totalPoints--;
                gimpoints++;
            }

            if (gimpoints >= 1)
            {
                GraceInMotionPoints.Visible = true;
                GraceInMotion.Image = Properties.Resources.aGraceInMotion;
            }

            if (gimpoints == 1)
            {
                GraceInMotionPoints.Image = Properties.Resources.skillpoints1;
            }

            if (gimpoints == 2)
            {
                GraceInMotionPoints.Image = Properties.Resources.skillpoints2;
            }

            if (gimpoints == 3)
            {
                GraceInMotionPoints.Image = Properties.Resources.skillpoints3;
            }

            if (gimpoints == 0)
            {
                GraceInMotion.Image = Properties.Resources.iGraceInMotion;
                GraceInMotionPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void GraceInMotion_MouseHover(object sender, EventArgs e)
        {
            GraceInMotionHover = true;
            PageFunctions();
            if (totalPoints <= 37)
            {
                GraceInMotionBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                GraceInMotionBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void GraceInMotion_MouseMove(object sender, MouseEventArgs e)
        {
            GraceInMotionHover = true;
            PageFunctions();
            if (totalPoints <= 37)
            {
                GraceInMotionBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                GraceInMotionBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void GraceInMotion_MouseLeave(object sender, EventArgs e)
        {
            GraceInMotionHover = false;
            PageFunctions();
            if (totalPoints <= 37)
            {
                GraceInMotionBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                GraceInMotionBackground.Image = Properties.Resources.iSkillBox;
            }
        }
        
        // Force Cloak
        private void ForceCloak_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && fcpoints == 1)
            {
                totalPoints++;
                fcpoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 37 && fcpoints == 0)
            {
                totalPoints--;
                fcpoints++;
            }

            if (fcpoints == 1)
            {
                ForceCloakPoints.Visible = true;
                ForceCloak.Image = Properties.Resources.aForceCloak;
                ForceCloakPoints.Image = Properties.Resources.skillpoints1;
            }

            if (fcpoints == 0)
            {
                ForceCloak.Image = Properties.Resources.iForceCloak;
                ForceCloakPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            //PageFunctions();
        }

        private void ForceCloak_MouseHover(object sender, EventArgs e)
        {
            ForceCloakHover = true;
            //PageFunctions();
            if (totalPoints <= 37)
            {
                ForceCloakBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ForceCloakBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ForceCloak_MouseMove(object sender, MouseEventArgs e)
        {
            ForceCloakHover = true;
            //PageFunctions();
            if (totalPoints <= 37)
            {
                ForceCloakBackground.Image = Properties.Resources.aSkillBoxGreen;
            }
            else
            {
                ForceCloakBackground.Image = Properties.Resources.iSkillBoxRed;
            }
        }

        private void ForceCloak_MouseLeave(object sender, EventArgs e)
        {
            ForceCloakHover = false;
            //PageFunctions();
            if (totalPoints <= 37)
            {
                ForceCloakBackground.Image = Properties.Resources.aSkillBox;
            }
            else
            {
                ForceCloakBackground.Image = Properties.Resources.iSkillBox;
            }
        }

        private void ImprovedCripplingAccuracy_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && icapoints <= 4 && icapoints > 0)
            {
                totalPoints++;
                icapoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 37 && icapoints < 2 && iftpoints == 2)
            {
                totalPoints--;
                icapoints++;
            }

            if (icapoints >= 1)
            {
                ImprovedCripplingAccuracyPoints.Visible = true;
                ImprovedCripplingAccuracy.Image = Properties.Resources.aPremonition;
            }

            if (icapoints == 1)
            {
                ImprovedCripplingAccuracyPoints.Image = Properties.Resources.skillpoints1;
            }

            if (icapoints == 2)
            {
                ImprovedCripplingAccuracyPoints.Image = Properties.Resources.skillpoints2;
            }

            if (icapoints == 3)
            {
                ImprovedCripplingAccuracyPoints.Image = Properties.Resources.skillpoints3;
            }

            if (icapoints == 0)
            {
                ImprovedCripplingAccuracy.Image = Properties.Resources.iPremonition;
                ImprovedCripplingAccuracyPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }

        private void Premonition_Click(object sender, EventArgs e)
        {
            gc.ExpertiseButtonSound();
            if (RemovePoints.Checked == true && ppoints <= 4 && ppoints > 0)
            {
                totalPoints++;
                ppoints--;
            }

            if (AddPoints.Checked == true && totalPoints <= 37 && ppoints < 4)
            {
                totalPoints--;
                ppoints++;
            }

            if (ppoints >= 1)
            {
                PremonitionPoints.Visible = true;
                Premonition.Image = Properties.Resources.aPremonition;
            }

            if (ppoints == 1)
            {
                PremonitionPoints.Image = Properties.Resources.skillpoints1;
            }

            if (ppoints == 2)
            {
                PremonitionPoints.Image = Properties.Resources.skillpoints2;
            }

            if (ppoints == 3)
            {
                PremonitionPoints.Image = Properties.Resources.skillpoints3;
            }

            if (ppoints == 4)
            {
                PremonitionPoints.Image = Properties.Resources.skillpoints4;
            }

            if (ppoints == 0)
            {
                Premonition.Image = Properties.Resources.iPremonition;
                PremonitionPoints.Visible = false;
            }

            AvailablePoints.Text = totalPoints.ToString();
            PageFunctions();
        }
    }
}
