﻿namespace projectAdo
{
    partial class Bail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bail));
            System.Windows.Forms.Label bailIDLabel;
            System.Windows.Forms.Label bailCodeLabel;
            System.Windows.Forms.Label baildateLabel;
            System.Windows.Forms.Label apartementodeLabel;
            System.Windows.Forms.Label locatairecodeLabel;
            System.Windows.Forms.Label baildureeLabel;
            System.Windows.Forms.Label baildebutLabel;
            System.Windows.Forms.Label montantloyerLabel;
            this.amrDBDataSet1 = new projectAdo.AmrDBDataSet1();
            this.bailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bailTableAdapter = new projectAdo.AmrDBDataSet1TableAdapters.bailTableAdapter();
            this.tableAdapterManager = new projectAdo.AmrDBDataSet1TableAdapters.TableAdapterManager();
            this.bailBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bailBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bailIDTextBox = new System.Windows.Forms.TextBox();
            this.bailCodeTextBox = new System.Windows.Forms.TextBox();
            this.baildateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.apartementodeTextBox = new System.Windows.Forms.TextBox();
            this.locatairecodeTextBox = new System.Windows.Forms.TextBox();
            this.baildureeTextBox = new System.Windows.Forms.TextBox();
            this.baildebutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.montantloyerTextBox = new System.Windows.Forms.TextBox();
            this.paiementTableAdapter = new projectAdo.AmrDBDataSet1TableAdapters.paiementTableAdapter();
            this.paiementDataGridView = new System.Windows.Forms.DataGridView();
            this.bailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            bailIDLabel = new System.Windows.Forms.Label();
            bailCodeLabel = new System.Windows.Forms.Label();
            baildateLabel = new System.Windows.Forms.Label();
            apartementodeLabel = new System.Windows.Forms.Label();
            locatairecodeLabel = new System.Windows.Forms.Label();
            baildureeLabel = new System.Windows.Forms.Label();
            baildebutLabel = new System.Windows.Forms.Label();
            montantloyerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amrDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingNavigator)).BeginInit();
            this.bailBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paiementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // amrDBDataSet1
            // 
            this.amrDBDataSet1.DataSetName = "AmrDBDataSet1";
            this.amrDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bailBindingSource
            // 
            this.bailBindingSource.DataMember = "bail";
            this.bailBindingSource.DataSource = this.amrDBDataSet1;
            // 
            // bailTableAdapter
            // 
            this.bailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.appartementTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bailTableAdapter = this.bailTableAdapter;
            this.tableAdapterManager.LocatairesTableAdapter = null;
            this.tableAdapterManager.paiementTableAdapter = this.paiementTableAdapter;
            this.tableAdapterManager.UpdateOrder = projectAdo.AmrDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bailBindingNavigator
            // 
            this.bailBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bailBindingNavigator.BindingSource = this.bailBindingSource;
            this.bailBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bailBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bailBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bailBindingNavigatorSaveItem});
            this.bailBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bailBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bailBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bailBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bailBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bailBindingNavigator.Name = "bailBindingNavigator";
            this.bailBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bailBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.bailBindingNavigator.TabIndex = 0;
            this.bailBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bailBindingNavigatorSaveItem
            // 
            this.bailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bailBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bailBindingNavigatorSaveItem.Image")));
            this.bailBindingNavigatorSaveItem.Name = "bailBindingNavigatorSaveItem";
            this.bailBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bailBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.bailBindingNavigatorSaveItem.Click += new System.EventHandler(this.bailBindingNavigatorSaveItem_Click);
            // 
            // bailIDLabel
            // 
            bailIDLabel.AutoSize = true;
            bailIDLabel.Location = new System.Drawing.Point(27, 39);
            bailIDLabel.Name = "bailIDLabel";
            bailIDLabel.Size = new System.Drawing.Size(40, 13);
            bailIDLabel.TabIndex = 1;
            bailIDLabel.Text = "bail ID:";
            // 
            // bailIDTextBox
            // 
            this.bailIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "bailID", true));
            this.bailIDTextBox.Location = new System.Drawing.Point(114, 36);
            this.bailIDTextBox.Name = "bailIDTextBox";
            this.bailIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.bailIDTextBox.TabIndex = 2;
            // 
            // bailCodeLabel
            // 
            bailCodeLabel.AutoSize = true;
            bailCodeLabel.Location = new System.Drawing.Point(27, 65);
            bailCodeLabel.Name = "bailCodeLabel";
            bailCodeLabel.Size = new System.Drawing.Size(54, 13);
            bailCodeLabel.TabIndex = 3;
            bailCodeLabel.Text = "bail Code:";
            // 
            // bailCodeTextBox
            // 
            this.bailCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "bailCode", true));
            this.bailCodeTextBox.Location = new System.Drawing.Point(114, 62);
            this.bailCodeTextBox.Name = "bailCodeTextBox";
            this.bailCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.bailCodeTextBox.TabIndex = 4;
            // 
            // baildateLabel
            // 
            baildateLabel.AutoSize = true;
            baildateLabel.Location = new System.Drawing.Point(27, 92);
            baildateLabel.Name = "baildateLabel";
            baildateLabel.Size = new System.Drawing.Size(47, 13);
            baildateLabel.TabIndex = 5;
            baildateLabel.Text = "baildate:";
            // 
            // baildateDateTimePicker
            // 
            this.baildateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bailBindingSource, "baildate", true));
            this.baildateDateTimePicker.Location = new System.Drawing.Point(114, 88);
            this.baildateDateTimePicker.Name = "baildateDateTimePicker";
            this.baildateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.baildateDateTimePicker.TabIndex = 6;
            // 
            // apartementodeLabel
            // 
            apartementodeLabel.AutoSize = true;
            apartementodeLabel.Location = new System.Drawing.Point(27, 117);
            apartementodeLabel.Name = "apartementodeLabel";
            apartementodeLabel.Size = new System.Drawing.Size(81, 13);
            apartementodeLabel.TabIndex = 7;
            apartementodeLabel.Text = "apartementode:";
            // 
            // apartementodeTextBox
            // 
            this.apartementodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "apartementode", true));
            this.apartementodeTextBox.Location = new System.Drawing.Point(114, 114);
            this.apartementodeTextBox.Name = "apartementodeTextBox";
            this.apartementodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.apartementodeTextBox.TabIndex = 8;
            // 
            // locatairecodeLabel
            // 
            locatairecodeLabel.AutoSize = true;
            locatairecodeLabel.Location = new System.Drawing.Point(27, 143);
            locatairecodeLabel.Name = "locatairecodeLabel";
            locatairecodeLabel.Size = new System.Drawing.Size(74, 13);
            locatairecodeLabel.TabIndex = 9;
            locatairecodeLabel.Text = "locatairecode:";
            // 
            // locatairecodeTextBox
            // 
            this.locatairecodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "locatairecode", true));
            this.locatairecodeTextBox.Location = new System.Drawing.Point(114, 140);
            this.locatairecodeTextBox.Name = "locatairecodeTextBox";
            this.locatairecodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.locatairecodeTextBox.TabIndex = 10;
            // 
            // baildureeLabel
            // 
            baildureeLabel.AutoSize = true;
            baildureeLabel.Location = new System.Drawing.Point(27, 169);
            baildureeLabel.Name = "baildureeLabel";
            baildureeLabel.Size = new System.Drawing.Size(53, 13);
            baildureeLabel.TabIndex = 11;
            baildureeLabel.Text = "bailduree:";
            // 
            // baildureeTextBox
            // 
            this.baildureeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "bailduree", true));
            this.baildureeTextBox.Location = new System.Drawing.Point(114, 166);
            this.baildureeTextBox.Name = "baildureeTextBox";
            this.baildureeTextBox.Size = new System.Drawing.Size(200, 20);
            this.baildureeTextBox.TabIndex = 12;
            // 
            // baildebutLabel
            // 
            baildebutLabel.AutoSize = true;
            baildebutLabel.Location = new System.Drawing.Point(27, 196);
            baildebutLabel.Name = "baildebutLabel";
            baildebutLabel.Size = new System.Drawing.Size(53, 13);
            baildebutLabel.TabIndex = 13;
            baildebutLabel.Text = "baildebut:";
            // 
            // baildebutDateTimePicker
            // 
            this.baildebutDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bailBindingSource, "baildebut", true));
            this.baildebutDateTimePicker.Location = new System.Drawing.Point(114, 192);
            this.baildebutDateTimePicker.Name = "baildebutDateTimePicker";
            this.baildebutDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.baildebutDateTimePicker.TabIndex = 14;
            // 
            // montantloyerLabel
            // 
            montantloyerLabel.AutoSize = true;
            montantloyerLabel.Location = new System.Drawing.Point(27, 221);
            montantloyerLabel.Name = "montantloyerLabel";
            montantloyerLabel.Size = new System.Drawing.Size(70, 13);
            montantloyerLabel.TabIndex = 15;
            montantloyerLabel.Text = "montantloyer:";
            // 
            // montantloyerTextBox
            // 
            this.montantloyerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bailBindingSource, "montantloyer", true));
            this.montantloyerTextBox.Location = new System.Drawing.Point(114, 218);
            this.montantloyerTextBox.Name = "montantloyerTextBox";
            this.montantloyerTextBox.Size = new System.Drawing.Size(200, 20);
            this.montantloyerTextBox.TabIndex = 16;
            // 
            // paiementTableAdapter
            // 
            this.paiementTableAdapter.ClearBeforeFill = true;
            // 
            // paiementDataGridView
            // 
            this.paiementDataGridView.AutoGenerateColumns = false;
            this.paiementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paiementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.paiementDataGridView.DataSource = this.paiementBindingSource;
            this.paiementDataGridView.Location = new System.Drawing.Point(12, 283);
            this.paiementDataGridView.Name = "paiementDataGridView";
            this.paiementDataGridView.Size = new System.Drawing.Size(469, 220);
            this.paiementDataGridView.TabIndex = 17;
            // 
            // bailDataGridView
            // 
            this.bailDataGridView.AutoGenerateColumns = false;
            this.bailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.bailDataGridView.DataSource = this.bailBindingSource;
            this.bailDataGridView.Location = new System.Drawing.Point(354, 18);
            this.bailDataGridView.Name = "bailDataGridView";
            this.bailDataGridView.Size = new System.Drawing.Size(300, 220);
            this.bailDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "bailID";
            this.dataGridViewTextBoxColumn8.HeaderText = "bailID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "bailCode";
            this.dataGridViewTextBoxColumn9.HeaderText = "bailCode";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "baildate";
            this.dataGridViewTextBoxColumn10.HeaderText = "baildate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "apartementode";
            this.dataGridViewTextBoxColumn11.HeaderText = "apartementode";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "locatairecode";
            this.dataGridViewTextBoxColumn12.HeaderText = "locatairecode";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "bailduree";
            this.dataGridViewTextBoxColumn13.HeaderText = "bailduree";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "baildebut";
            this.dataGridViewTextBoxColumn14.HeaderText = "baildebut";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "montantloyer";
            this.dataGridViewTextBoxColumn15.HeaderText = "montantloyer";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "paiementID";
            this.dataGridViewTextBoxColumn1.HeaderText = "paiementID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numrecu";
            this.dataGridViewTextBoxColumn2.HeaderText = "numrecu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datepaiement";
            this.dataGridViewTextBoxColumn3.HeaderText = "datepaiement";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bailcode";
            this.dataGridViewTextBoxColumn4.HeaderText = "bailcode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Paiementdumois";
            this.dataGridViewTextBoxColumn5.HeaderText = "Paiementdumois";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Paiementdeannee";
            this.dataGridViewTextBoxColumn6.HeaderText = "Paiementdeannee";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "montantpaiement";
            this.dataGridViewTextBoxColumn7.HeaderText = "montantpaiement";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // paiementBindingSource
            // 
            this.paiementBindingSource.DataMember = "FK_paiement_ToTable";
            this.paiementBindingSource.DataSource = this.bailBindingSource;
            // 
            // Bail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.bailDataGridView);
            this.Controls.Add(this.paiementDataGridView);
            this.Controls.Add(bailIDLabel);
            this.Controls.Add(this.bailIDTextBox);
            this.Controls.Add(bailCodeLabel);
            this.Controls.Add(this.bailCodeTextBox);
            this.Controls.Add(baildateLabel);
            this.Controls.Add(this.baildateDateTimePicker);
            this.Controls.Add(apartementodeLabel);
            this.Controls.Add(this.apartementodeTextBox);
            this.Controls.Add(locatairecodeLabel);
            this.Controls.Add(this.locatairecodeTextBox);
            this.Controls.Add(baildureeLabel);
            this.Controls.Add(this.baildureeTextBox);
            this.Controls.Add(baildebutLabel);
            this.Controls.Add(this.baildebutDateTimePicker);
            this.Controls.Add(montantloyerLabel);
            this.Controls.Add(this.montantloyerTextBox);
            this.Controls.Add(this.bailBindingNavigator);
            this.Name = "Bail";
            this.Text = "Bail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bail_FormClosing);
            this.Load += new System.EventHandler(this.Bail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amrDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailBindingNavigator)).EndInit();
            this.bailBindingNavigator.ResumeLayout(false);
            this.bailBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paiementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paiementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AmrDBDataSet1 amrDBDataSet1;
        private System.Windows.Forms.BindingSource bailBindingSource;
        private AmrDBDataSet1TableAdapters.bailTableAdapter bailTableAdapter;
        private AmrDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bailBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bailBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bailIDTextBox;
        private System.Windows.Forms.TextBox bailCodeTextBox;
        private System.Windows.Forms.DateTimePicker baildateDateTimePicker;
        private System.Windows.Forms.TextBox apartementodeTextBox;
        private System.Windows.Forms.TextBox locatairecodeTextBox;
        private System.Windows.Forms.TextBox baildureeTextBox;
        private System.Windows.Forms.DateTimePicker baildebutDateTimePicker;
        private System.Windows.Forms.TextBox montantloyerTextBox;
        private AmrDBDataSet1TableAdapters.paiementTableAdapter paiementTableAdapter;
        private System.Windows.Forms.BindingSource paiementBindingSource;
        private System.Windows.Forms.DataGridView paiementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView bailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}