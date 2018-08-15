namespace TestEventAvecDeligate
{
    partial class Simulateur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.output1 = new System.Windows.Forms.Label();
            this.output2 = new System.Windows.Forms.Label();
            this.jauje = new AquaControls.AquaGauge();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jauje2 = new AquaControls.AquaGauge();
            this.jauje3 = new AquaControls.AquaGauge();
            this.SuspendLayout();
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.Location = new System.Drawing.Point(84, 86);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(35, 13);
            this.output1.TabIndex = 0;
            this.output1.Text = "label1";
            // 
            // output2
            // 
            this.output2.AutoSize = true;
            this.output2.Location = new System.Drawing.Point(87, 173);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(35, 13);
            this.output2.TabIndex = 1;
            this.output2.Text = "label2";
            // 
            // jauje
            // 
            this.jauje.BackColor = System.Drawing.Color.Transparent;
            this.jauje.DialColor = System.Drawing.Color.Lavender;
            this.jauje.DialText = null;
            this.jauje.Glossiness = 11.36364F;
            this.jauje.Location = new System.Drawing.Point(30, 230);
            this.jauje.MaxValue = 100F;
            this.jauje.MinValue = 0F;
            this.jauje.Name = "jauje";
            this.jauje.RecommendedValue = 0F;
            this.jauje.Size = new System.Drawing.Size(150, 150);
            this.jauje.TabIndex = 2;
            this.jauje.ThresholdPercent = 0F;
            this.jauje.Value = 0F;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "incrementer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove observeur ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jauje2
            // 
            this.jauje2.BackColor = System.Drawing.Color.Transparent;
            this.jauje2.DialColor = System.Drawing.Color.Thistle;
            this.jauje2.DialText = null;
            this.jauje2.ForeColor = System.Drawing.Color.Red;
            this.jauje2.Glossiness = 11.36364F;
            this.jauje2.Location = new System.Drawing.Point(225, 230);
            this.jauje2.MaxValue = 200F;
            this.jauje2.MinValue = 0F;
            this.jauje2.Name = "jauje2";
            this.jauje2.RecommendedValue = 0F;
            this.jauje2.Size = new System.Drawing.Size(150, 150);
            this.jauje2.TabIndex = 5;
            this.jauje2.ThresholdPercent = 0F;
            this.jauje2.Value = 0F;
            // 
            // jauje3
            // 
            this.jauje3.BackColor = System.Drawing.Color.Transparent;
            this.jauje3.DialColor = System.Drawing.Color.DodgerBlue;
            this.jauje3.DialText = "";
            this.jauje3.Glossiness = 11.36364F;
            this.jauje3.Location = new System.Drawing.Point(424, 230);
            this.jauje3.MaxValue = 300F;
            this.jauje3.MinValue = 0F;
            this.jauje3.Name = "jauje3";
            this.jauje3.RecommendedValue = 0F;
            this.jauje3.Size = new System.Drawing.Size(150, 150);
            this.jauje3.TabIndex = 6;
            this.jauje3.ThresholdPercent = 0F;
            this.jauje3.Value = 0F;
            // 
            // Simulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 449);
            this.Controls.Add(this.jauje3);
            this.Controls.Add(this.jauje2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jauje);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Name = "Simulateur";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output1;
        private System.Windows.Forms.Label output2;
        internal AquaControls.AquaGauge jauje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        internal AquaControls.AquaGauge jauje2;
        internal AquaControls.AquaGauge jauje3;
    }
}

