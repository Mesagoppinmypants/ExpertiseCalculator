namespace SWG_Expertise_Calcualtor
{
    partial class SWGGameArchives
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new System.Drawing.Font("Star Jedi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(12, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(135, 60);
            button1.TabIndex = 0;
            button1.Text = "game music";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click);
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Star Jedi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(199, 12);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 60);
            button2.TabIndex = 1;
            button2.Text = "game art";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Font = new System.Drawing.Font("Star Jedi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(386, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(135, 60);
            button3.TabIndex = 2;
            button3.Text = "profession videos";
            button3.UseVisualStyleBackColor = true;
            // 
            // SWGGameArchives
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateGray;
            ClientSize = new System.Drawing.Size(534, 91);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SWGGameArchives";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SWG Game Archive Selection";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}