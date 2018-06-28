namespace WorkShopDelegate
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
            this.cb_recherche = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_resultat = new System.Windows.Forms.RichTextBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_recherche
            // 
            this.cb_recherche.FormattingEnabled = true;
            this.cb_recherche.Location = new System.Drawing.Point(164, 47);
            this.cb_recherche.Name = "cb_recherche";
            this.cb_recherche.Size = new System.Drawing.Size(206, 21);
            this.cb_recherche.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rechercher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Résultat";
            // 
            // tb_resultat
            // 
            this.tb_resultat.Location = new System.Drawing.Point(164, 119);
            this.tb_resultat.Name = "tb_resultat";
            this.tb_resultat.Size = new System.Drawing.Size(244, 243);
            this.tb_resultat.TabIndex = 3;
            this.tb_resultat.Text = "";
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(380, 47);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(75, 23);
            this.btn_recherche.TabIndex = 4;
            this.btn_recherche.Text = "Exécuter";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 408);
            this.Controls.Add(this.btn_recherche);
            this.Controls.Add(this.tb_resultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_recherche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_recherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tb_resultat;
        private System.Windows.Forms.Button btn_recherche;
    }
}

