namespace SWG_Expertise_Calcualtor
{
    partial class ProfessionSelectionPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProfessionSelection = new System.Windows.Forms.ComboBox();
            this.SelectionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProfessionSelection
            // 
            this.ProfessionSelection.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ProfessionSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfessionSelection.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.ProfessionSelection.FormattingEnabled = true;
            this.ProfessionSelection.Items.AddRange(new object[] {
            "Choose Profession",
            "Jedi",
            "Bounty Hunter"});
            this.ProfessionSelection.Location = new System.Drawing.Point(82, 149);
            this.ProfessionSelection.Name = "ProfessionSelection";
            this.ProfessionSelection.Size = new System.Drawing.Size(121, 21);
            this.ProfessionSelection.TabIndex = 0;
            this.ProfessionSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SelectionText
            // 
            this.SelectionText.AutoSize = true;
            this.SelectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionText.Location = new System.Drawing.Point(12, 110);
            this.SelectionText.Name = "SelectionText";
            this.SelectionText.Size = new System.Drawing.Size(260, 24);
            this.SelectionText.TabIndex = 1;
            this.SelectionText.Text = "Please select a profession.";
            // 
            // ProfessionSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.SelectionText);
            this.Controls.Add(this.ProfessionSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfessionSelectionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expertise Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpertiseCalcStart_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ProfessionSelection;
        private System.Windows.Forms.Label SelectionText;
    }
}

