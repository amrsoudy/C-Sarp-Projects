namespace test_bouton_2015
{
    partial class Form1
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
            this.TxtMesure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Afficher = new System.Windows.Forms.Button();
            this.userBoutonfirst = new boutonuser_control_2015.UserBouton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMesure
            // 
            this.TxtMesure.Location = new System.Drawing.Point(531, 475);
            this.TxtMesure.Name = "TxtMesure";
            this.TxtMesure.Size = new System.Drawing.Size(100, 20);
            this.TxtMesure.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valeur";
            // 
            // Afficher
            // 
            this.Afficher.Location = new System.Drawing.Point(656, 475);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(75, 23);
            this.Afficher.TabIndex = 3;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // userBoutonfirst
            // 
            this.userBoutonfirst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userBoutonfirst.Location = new System.Drawing.Point(286, 105);
            this.userBoutonfirst.Mesure = 0;
            this.userBoutonfirst.Name = "userBoutonfirst";
            this.userBoutonfirst.Size = new System.Drawing.Size(326, 168);
            this.userBoutonfirst.TabIndex = 4;
            this.userBoutonfirst.Valeur_Max = 100;
            this.userBoutonfirst.Valeur_Min = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(586, 366);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(432, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 592);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.userBoutonfirst);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMesure);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtMesure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Afficher;
        internal boutonuser_control_2015.UserBouton userBoutonfirst;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

