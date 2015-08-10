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
            this.ProfessionSelection = new System.Windows.Forms.ComboBox();
            this.TopRightCornerGraphic = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightCornerGraphic)).BeginInit();
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
            this.ProfessionSelection.Location = new System.Drawing.Point(814, 9);
            this.ProfessionSelection.Name = "ProfessionSelection";
            this.ProfessionSelection.Size = new System.Drawing.Size(121, 21);
            this.ProfessionSelection.TabIndex = 0;
            this.ProfessionSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TopRightCornerGraphic
            // 
            this.TopRightCornerGraphic.Image = global::SWG_Expertise_Calcualtor.Properties.Resources.massage_top_right;
            this.TopRightCornerGraphic.Location = new System.Drawing.Point(771, -1);
            this.TopRightCornerGraphic.Name = "TopRightCornerGraphic";
            this.TopRightCornerGraphic.Size = new System.Drawing.Size(214, 34);
            this.TopRightCornerGraphic.TabIndex = 1;
            this.TopRightCornerGraphic.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(949, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(36, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "    ";
            this.ExitButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExpertiseCalcStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(984, 696);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProfessionSelection);
            this.Controls.Add(this.TopRightCornerGraphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExpertiseCalcStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expertise Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpertiseCalcStart_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TopRightCornerGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ProfessionSelection;
        private System.Windows.Forms.PictureBox TopRightCornerGraphic;
        private System.Windows.Forms.Label ExitButton;
    }
}

