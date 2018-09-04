namespace projectAdo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locataireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paiementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bailToolStripMenuItem,
            this.locataireToolStripMenuItem,
            this.paiementToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // bailToolStripMenuItem
            // 
            this.bailToolStripMenuItem.Name = "bailToolStripMenuItem";
            resources.ApplyResources(this.bailToolStripMenuItem, "bailToolStripMenuItem");
            this.bailToolStripMenuItem.Click += new System.EventHandler(this.bailToolStripMenuItem_Click);
            // 
            // locataireToolStripMenuItem
            // 
            this.locataireToolStripMenuItem.Name = "locataireToolStripMenuItem";
            resources.ApplyResources(this.locataireToolStripMenuItem, "locataireToolStripMenuItem");
            this.locataireToolStripMenuItem.Click += new System.EventHandler(this.locataireToolStripMenuItem_Click);
            // 
            // paiementToolStripMenuItem
            // 
            this.paiementToolStripMenuItem.Name = "paiementToolStripMenuItem";
            resources.ApplyResources(this.paiementToolStripMenuItem, "paiementToolStripMenuItem");
            this.paiementToolStripMenuItem.Click += new System.EventHandler(this.paiementToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locataireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paiementToolStripMenuItem;
    }
}