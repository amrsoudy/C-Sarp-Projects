namespace Event
{
    partial class Simulateur
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
            this.outbut1 = new System.Windows.Forms.Label();
            this.outbut2 = new System.Windows.Forms.Label();
            this.jauge = new AquaControls.AquaGauge();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outbut1
            // 
            this.outbut1.AutoSize = true;
            this.outbut1.Location = new System.Drawing.Point(65, 72);
            this.outbut1.Name = "outbut1";
            this.outbut1.Size = new System.Drawing.Size(36, 13);
            this.outbut1.TabIndex = 0;
            this.outbut1.Text = "valeur";
            // 
            // outbut2
            // 
            this.outbut2.AutoSize = true;
            this.outbut2.Location = new System.Drawing.Point(65, 156);
            this.outbut2.Name = "outbut2";
            this.outbut2.Size = new System.Drawing.Size(37, 13);
            this.outbut2.TabIndex = 1;
            this.outbut2.Text = "Valeur";
            // 
            // jauge
            // 
            this.jauge.BackColor = System.Drawing.Color.Transparent;
            this.jauge.DialColor = System.Drawing.Color.Lavender;
            this.jauge.DialText = null;
            this.jauge.Glossiness = 11.36364F;
            this.jauge.Location = new System.Drawing.Point(57, 224);
            this.jauge.MaxValue = 100F;
            this.jauge.MinValue = 0F;
            this.jauge.Name = "jauge";
            this.jauge.RecommendedValue = 0F;
            this.jauge.Size = new System.Drawing.Size(149, 149);
            this.jauge.TabIndex = 2;
            this.jauge.ThresholdPercent = 0F;
            this.jauge.Value = 0F;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Incrementer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Simulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jauge);
            this.Controls.Add(this.outbut2);
            this.Controls.Add(this.outbut1);
            this.Name = "Simulateur";
            this.Text = "Simulateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outbut1;
        private System.Windows.Forms.Label outbut2;
        internal AquaControls.AquaGauge jauge;
        
        private System.Windows.Forms.Button button1;
    }
}