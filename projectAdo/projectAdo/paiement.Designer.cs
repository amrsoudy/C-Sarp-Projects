namespace projectAdo
{
    partial class paiement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paiement));
            System.Windows.Forms.Label paiementIDLabel;
            System.Windows.Forms.Label numrecuLabel;
            System.Windows.Forms.Label datepaiementLabel;
            System.Windows.Forms.Label bailcodeLabel;
            System.Windows.Forms.Label paiementdumoisLabel;
            System.Windows.Forms.Label paiementdeanneeLabel;
            System.Windows.Forms.Label montantpaiementLabel;
            this.amrDBDataSet1 = new projectAdo.AmrDBDataSet1();
            this.paiementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paiementTableAdapter = new projectAdo.AmrDBDataSet1TableAdapters.paiementTableAdapter();
            this.tableAdapterManager = new projectAdo.AmrDBDataSet1TableAdapters.TableAdapterManager();
            this.paiementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.paiementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paiementIDTextBox = new System.Windows.Forms.TextBox();
            this.numrecuTextBox = new System.Windows.Forms.TextBox();
            this.datepaiementDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paiementdumoisTextBox = new System.Windows.Forms.TextBox();
            this.paiementdeanneeTextBox = new System.Windows.Forms.TextBox();
            this.montantpaiementTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.amrDBDataSet = new projectAdo.AmrDBDataSet();
            this.bailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bailTableAdapter = new projectAdo.AmrDBDataSetTableAdapters.bailTableAdapter();
            paiementIDLabel = new System.Windows.Forms.Label();
            numrecuLabel = new System.Windows.Forms.Label();
            datepaiementLabel = new System.Windows.Forms.Label();
            bailcodeLabel = new System.Windows.Forms.Label();
            paiementdumoisLabel = new System.Windows.Forms.Label();
            paiementdeanneeLabel = new System.Windows.Forms.Label();
            montantpaiementLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amrDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementBindingNavigator)).BeginInit();
            this.paiementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amrDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // amrDBDataSet1
            // 
            this.amrDBDataSet1.DataSetName = "AmrDBDataSet1";
            this.amrDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paiementBindingSource
            // 
            this.paiementBindingSource.DataMember = "paiement";
            this.paiementBindingSource.DataSource = this.amrDBDataSet1;
            // 
            // paiementTableAdapter
            // 
            this.paiementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appartementTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bailTableAdapter = null;
            this.tableAdapterManager.LocatairesTableAdapter = null;
            this.tableAdapterManager.paiementTableAdapter = this.paiementTableAdapter;
            this.tableAdapterManager.UpdateOrder = projectAdo.AmrDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paiementBindingNavigator
            // 
            this.paiementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paiementBindingNavigator.BindingSource = this.paiementBindingSource;
            this.paiementBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paiementBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paiementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.paiementBindingNavigatorSaveItem});
            this.paiementBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paiementBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paiementBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paiementBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paiementBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paiementBindingNavigator.Name = "paiementBindingNavigator";
            this.paiementBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paiementBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.paiementBindingNavigator.TabIndex = 0;
            this.paiementBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // paiementBindingNavigatorSaveItem
            // 
            this.paiementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paiementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paiementBindingNavigatorSaveItem.Image")));
            this.paiementBindingNavigatorSaveItem.Name = "paiementBindingNavigatorSaveItem";
            this.paiementBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.paiementBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.paiementBindingNavigatorSaveItem.Click += new System.EventHandler(this.paiementBindingNavigatorSaveItem_Click);
            // 
            // paiementIDLabel
            // 
            paiementIDLabel.AutoSize = true;
            paiementIDLabel.Location = new System.Drawing.Point(23, 40);
            paiementIDLabel.Name = "paiementIDLabel";
            paiementIDLabel.Size = new System.Drawing.Size(67, 13);
            paiementIDLabel.TabIndex = 1;
            paiementIDLabel.Text = "paiement ID:";
            // 
            // paiementIDTextBox
            // 
            this.paiementIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paiementBindingSource, "paiementID", true));
            this.paiementIDTextBox.Location = new System.Drawing.Point(125, 37);
            this.paiementIDTextBox.Name = "paiementIDTextBox";
            this.paiementIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.paiementIDTextBox.TabIndex = 2;
            // 
            // numrecuLabel
            // 
            numrecuLabel.AutoSize = true;
            numrecuLabel.Location = new System.Drawing.Point(23, 66);
            numrecuLabel.Name = "numrecuLabel";
            numrecuLabel.Size = new System.Drawing.Size(51, 13);
            numrecuLabel.TabIndex = 3;
            numrecuLabel.Text = "numrecu:";
            // 
            // numrecuTextBox
            // 
            this.numrecuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paiementBindingSource, "numrecu", true));
            this.numrecuTextBox.Location = new System.Drawing.Point(125, 63);
            this.numrecuTextBox.Name = "numrecuTextBox";
            this.numrecuTextBox.Size = new System.Drawing.Size(200, 20);
            this.numrecuTextBox.TabIndex = 4;
            // 
            // datepaiementLabel
            // 
            datepaiementLabel.AutoSize = true;
            datepaiementLabel.Location = new System.Drawing.Point(23, 93);
            datepaiementLabel.Name = "datepaiementLabel";
            datepaiementLabel.Size = new System.Drawing.Size(74, 13);
            datepaiementLabel.TabIndex = 5;
            datepaiementLabel.Text = "datepaiement:";
            // 
            // datepaiementDateTimePicker
            // 
            this.datepaiementDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paiementBindingSource, "datepaiement", true));
            this.datepaiementDateTimePicker.Location = new System.Drawing.Point(125, 89);
            this.datepaiementDateTimePicker.Name = "datepaiementDateTimePicker";
            this.datepaiementDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datepaiementDateTimePicker.TabIndex = 6;
            // 
            // bailcodeLabel
            // 
            bailcodeLabel.AutoSize = true;
            bailcodeLabel.Location = new System.Drawing.Point(23, 118);
            bailcodeLabel.Name = "bailcodeLabel";
            bailcodeLabel.Size = new System.Drawing.Size(50, 13);
            bailcodeLabel.TabIndex = 7;
            bailcodeLabel.Text = "bailcode:";
            // 
            // paiementdumoisLabel
            // 
            paiementdumoisLabel.AutoSize = true;
            paiementdumoisLabel.Location = new System.Drawing.Point(23, 144);
            paiementdumoisLabel.Name = "paiementdumoisLabel";
            paiementdumoisLabel.Size = new System.Drawing.Size(87, 13);
            paiementdumoisLabel.TabIndex = 9;
            paiementdumoisLabel.Text = "Paiementdumois:";
            // 
            // paiementdumoisTextBox
            // 
            this.paiementdumoisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paiementBindingSource, "Paiementdumois", true));
            this.paiementdumoisTextBox.Location = new System.Drawing.Point(125, 141);
            this.paiementdumoisTextBox.Name = "paiementdumoisTextBox";
            this.paiementdumoisTextBox.Size = new System.Drawing.Size(200, 20);
            this.paiementdumoisTextBox.TabIndex = 10;
            // 
            // paiementdeanneeLabel
            // 
            paiementdeanneeLabel.AutoSize = true;
            paiementdeanneeLabel.Location = new System.Drawing.Point(23, 170);
            paiementdeanneeLabel.Name = "paiementdeanneeLabel";
            paiementdeanneeLabel.Size = new System.Drawing.Size(96, 13);
            paiementdeanneeLabel.TabIndex = 11;
            paiementdeanneeLabel.Text = "Paiementdeannee:";
            // 
            // paiementdeanneeTextBox
            // 
            this.paiementdeanneeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paiementBindingSource, "Paiementdeannee", true));
            this.paiementdeanneeTextBox.Location = new System.Drawing.Point(125, 167);
            this.paiementdeanneeTextBox.Name = "paiementdeanneeTextBox";
            this.paiementdeanneeTextBox.Size = new System.Drawing.Size(200, 20);
            this.paiementdeanneeTextBox.TabIndex = 12;
            // 
            // montantpaiementLabel
            // 
            montantpaiementLabel.AutoSize = true;
            montantpaiementLabel.Location = new System.Drawing.Point(23, 196);
            montantpaiementLabel.Name = "montantpaiementLabel";
            montantpaiementLabel.Size = new System.Drawing.Size(91, 13);
            montantpaiementLabel.TabIndex = 13;
            montantpaiementLabel.Text = "montantpaiement:";
            // 
            // montantpaiementTextBox
            // 
            this.montantpaiementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paiementBindingSource, "montantpaiement", true));
            this.montantpaiementTextBox.Location = new System.Drawing.Point(125, 193);
            this.montantpaiementTextBox.Name = "montantpaiementTextBox";
            this.montantpaiementTextBox.Size = new System.Drawing.Size(200, 20);
            this.montantpaiementTextBox.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bailBindingSource, "bailCode", true));
            this.comboBox1.DataSource = this.bailBindingSource;
            this.comboBox1.DisplayMember = "bailcode";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "bailcode";
            // 
            // amrDBDataSet
            // 
            this.amrDBDataSet.DataSetName = "AmrDBDataSet";
            this.amrDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bailBindingSource
            // 
            this.bailBindingSource.DataMember = "bail";
            this.bailBindingSource.DataSource = this.amrDBDataSet;
            // 
            // bailTableAdapter
            // 
            this.bailTableAdapter.ClearBeforeFill = true;
            // 
            // paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(paiementIDLabel);
            this.Controls.Add(this.paiementIDTextBox);
            this.Controls.Add(numrecuLabel);
            this.Controls.Add(this.numrecuTextBox);
            this.Controls.Add(datepaiementLabel);
            this.Controls.Add(this.datepaiementDateTimePicker);
            this.Controls.Add(bailcodeLabel);
            this.Controls.Add(paiementdumoisLabel);
            this.Controls.Add(this.paiementdumoisTextBox);
            this.Controls.Add(paiementdeanneeLabel);
            this.Controls.Add(this.paiementdeanneeTextBox);
            this.Controls.Add(montantpaiementLabel);
            this.Controls.Add(this.montantpaiementTextBox);
            this.Controls.Add(this.paiementBindingNavigator);
            this.Name = "paiement";
            this.Text = "paiement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.paiement_FormClosing);
            this.Load += new System.EventHandler(this.paiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amrDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementBindingNavigator)).EndInit();
            this.paiementBindingNavigator.ResumeLayout(false);
            this.paiementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amrDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AmrDBDataSet1 amrDBDataSet1;
        private System.Windows.Forms.BindingSource paiementBindingSource;
        private AmrDBDataSet1TableAdapters.paiementTableAdapter paiementTableAdapter;
        private AmrDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paiementBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton paiementBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox paiementIDTextBox;
        private System.Windows.Forms.TextBox numrecuTextBox;
        private System.Windows.Forms.DateTimePicker datepaiementDateTimePicker;
        private System.Windows.Forms.TextBox paiementdumoisTextBox;
        private System.Windows.Forms.TextBox paiementdeanneeTextBox;
        private System.Windows.Forms.TextBox montantpaiementTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private AmrDBDataSet amrDBDataSet;
        private System.Windows.Forms.BindingSource bailBindingSource;
        private AmrDBDataSetTableAdapters.bailTableAdapter bailTableAdapter;
    }
}