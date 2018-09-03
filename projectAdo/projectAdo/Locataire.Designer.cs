namespace projectAdo
{
    partial class Locataire
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
            this.components = new System.ComponentModel.Container();
            this.bindingSourceLocataire = new System.Windows.Forms.BindingSource(this.components);
            this.amrDBDataSet = new projectAdo.AmrDBDataSet();
            this.locatairesTableAdapter = new projectAdo.AmrDBDataSetTableAdapters.LocatairesTableAdapter();
            this.dataGridLocataire = new System.Windows.Forms.DataGridView();
            this.locataireIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locataireCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomprenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutmariageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocataire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amrDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocataire)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceLocataire
            // 
            this.bindingSourceLocataire.DataMember = "Locataires";
            this.bindingSourceLocataire.DataSource = this.amrDBDataSet;
            // 
            // amrDBDataSet
            // 
            this.amrDBDataSet.DataSetName = "AmrDBDataSet";
            this.amrDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatairesTableAdapter
            // 
            this.locatairesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridLocataire
            // 
            this.dataGridLocataire.AutoGenerateColumns = false;
            this.dataGridLocataire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocataire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locataireIDDataGridViewTextBoxColumn,
            this.locataireCodeDataGridViewTextBoxColumn,
            this.nomprenomDataGridViewTextBoxColumn,
            this.statutmariageDataGridViewTextBoxColumn,
            this.numerocontactDataGridViewTextBoxColumn});
            this.dataGridLocataire.DataSource = this.bindingSourceLocataire;
            this.dataGridLocataire.Location = new System.Drawing.Point(129, 12);
            this.dataGridLocataire.Name = "dataGridLocataire";
            this.dataGridLocataire.Size = new System.Drawing.Size(544, 150);
            this.dataGridLocataire.TabIndex = 0;
            // 
            // locataireIDDataGridViewTextBoxColumn
            // 
            this.locataireIDDataGridViewTextBoxColumn.DataPropertyName = "locataireID";
            this.locataireIDDataGridViewTextBoxColumn.HeaderText = "locataireID";
            this.locataireIDDataGridViewTextBoxColumn.Name = "locataireIDDataGridViewTextBoxColumn";
            this.locataireIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locataireCodeDataGridViewTextBoxColumn
            // 
            this.locataireCodeDataGridViewTextBoxColumn.DataPropertyName = "locataireCode";
            this.locataireCodeDataGridViewTextBoxColumn.HeaderText = "locataireCode";
            this.locataireCodeDataGridViewTextBoxColumn.Name = "locataireCodeDataGridViewTextBoxColumn";
            // 
            // nomprenomDataGridViewTextBoxColumn
            // 
            this.nomprenomDataGridViewTextBoxColumn.DataPropertyName = "Nomprenom";
            this.nomprenomDataGridViewTextBoxColumn.HeaderText = "Nomprenom";
            this.nomprenomDataGridViewTextBoxColumn.Name = "nomprenomDataGridViewTextBoxColumn";
            // 
            // statutmariageDataGridViewTextBoxColumn
            // 
            this.statutmariageDataGridViewTextBoxColumn.DataPropertyName = "Statutmariage";
            this.statutmariageDataGridViewTextBoxColumn.HeaderText = "Statutmariage";
            this.statutmariageDataGridViewTextBoxColumn.Name = "statutmariageDataGridViewTextBoxColumn";
            // 
            // numerocontactDataGridViewTextBoxColumn
            // 
            this.numerocontactDataGridViewTextBoxColumn.DataPropertyName = "numerocontact";
            this.numerocontactDataGridViewTextBoxColumn.HeaderText = "numerocontact";
            this.numerocontactDataGridViewTextBoxColumn.Name = "numerocontactDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(129, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 156);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num contact";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom prenom ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quiter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Effacer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Enregistrer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Locataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridLocataire);
            this.Name = "Locataire";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Locataire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocataire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amrDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocataire)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceLocataire;
        private AmrDBDataSet amrDBDataSet;
        private AmrDBDataSetTableAdapters.LocatairesTableAdapter locatairesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridLocataire;
        private System.Windows.Forms.DataGridViewTextBoxColumn locataireIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locataireCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomprenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutmariageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

