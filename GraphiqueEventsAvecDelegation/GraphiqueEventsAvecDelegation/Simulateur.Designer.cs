using AquaControls;

namespace GraphiqueEventsAvecDelegation
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.Location = new System.Drawing.Point(84, 70);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(37, 13);
            this.output1.TabIndex = 0;
            this.output1.Text = "Valeur";
            // 
            // output2
            // 
            this.output2.AutoSize = true;
            this.output2.Location = new System.Drawing.Point(84, 133);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(37, 13);
            this.output2.TabIndex = 1;
            this.output2.Text = "Valeur";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Incrémenter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Simulateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 424);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

