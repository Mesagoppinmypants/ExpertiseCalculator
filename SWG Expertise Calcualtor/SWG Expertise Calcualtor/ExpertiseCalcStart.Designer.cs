namespace SWG_Expertise_Calcualtor
{
    partial class ExpertiseCalcStart
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
            ProfessionSelection = new System.Windows.Forms.ComboBox();
            TopRightCornerGraphic = new System.Windows.Forms.PictureBox();
            ExitButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(TopRightCornerGraphic)).BeginInit();
            SuspendLayout();
            // 
            // ProfessionSelection
            // 
            ProfessionSelection.BackColor = System.Drawing.Color.DarkSlateGray;
            ProfessionSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ProfessionSelection.ForeColor = System.Drawing.Color.MediumTurquoise;
            ProfessionSelection.FormattingEnabled = true;
            ProfessionSelection.Items.AddRange(new object[] {
            "Choose Profession",
            "Jedi",
            "Bounty Hunter"});
            ProfessionSelection.Location = new System.Drawing.Point(814, 9);
            ProfessionSelection.Name = "ProfessionSelection";
            ProfessionSelection.Size = new System.Drawing.Size(121, 21);
            ProfessionSelection.TabIndex = 0;
            ProfessionSelection.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
            // 
            // TopRightCornerGraphic
            // 
            TopRightCornerGraphic.Image = global::SWG_Expertise_Calcualtor.Properties.Resources.massage_top_right;
            TopRightCornerGraphic.Location = new System.Drawing.Point(771, -1);
            TopRightCornerGraphic.Name = "TopRightCornerGraphic";
            TopRightCornerGraphic.Size = new System.Drawing.Size(214, 34);
            TopRightCornerGraphic.TabIndex = 1;
            TopRightCornerGraphic.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.BackColor = System.Drawing.Color.Transparent;
            ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ExitButton.Location = new System.Drawing.Point(949, 9);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new System.Drawing.Size(36, 25);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "    ";
            ExitButton.Click += new System.EventHandler(label1_Click);
            // 
            // ExpertiseCalcStart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateGray;
            ClientSize = new System.Drawing.Size(984, 696);
            Controls.Add(ExitButton);
            Controls.Add(ProfessionSelection);
            Controls.Add(TopRightCornerGraphic);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "ExpertiseCalcStart";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Expertise Calculator";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(ExpertiseCalcStart_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(TopRightCornerGraphic)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ProfessionSelection;
        private System.Windows.Forms.PictureBox TopRightCornerGraphic;
        private System.Windows.Forms.Label ExitButton;
    }
}

