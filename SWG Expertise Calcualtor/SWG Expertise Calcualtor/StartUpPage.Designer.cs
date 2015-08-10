namespace SWG_Expertise_Calcualtor
{
    partial class StartUpPage
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
            this.OpenExpertiseCalculatorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenExpertiseCalculatorButton
            // 
            this.OpenExpertiseCalculatorButton.Font = new System.Drawing.Font("Star Jedi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenExpertiseCalculatorButton.Location = new System.Drawing.Point(72, 24);
            this.OpenExpertiseCalculatorButton.Name = "OpenExpertiseCalculatorButton";
            this.OpenExpertiseCalculatorButton.Size = new System.Drawing.Size(134, 63);
            this.OpenExpertiseCalculatorButton.TabIndex = 0;
            this.OpenExpertiseCalculatorButton.Text = "expertise calculator";
            this.OpenExpertiseCalculatorButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "v0.1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Star Jedi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "swg soundtrack";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Star Jedi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(72, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "project swg information";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenExpertiseCalculatorButton);
            this.Name = "StartUp";
            this.Text = "Project SWG Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenExpertiseCalculatorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}