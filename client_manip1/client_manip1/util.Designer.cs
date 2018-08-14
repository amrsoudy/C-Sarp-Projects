namespace client_manip1
{
    partial class util
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
            this.contactComponent1 = new cah1_manip2.ContactComponent();
            this.SuspendLayout();
            // 
            // contactComponent1
            // 
            this.contactComponent1.NomContact = "Une exemple de contact";
            this.contactComponent1.TelephoneContact = "514-555-5555";
            this.contactComponent1.TypeContact = "Professionnel";
            // 
            // util
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "util";
            this.Text = "util";
            this.ResumeLayout(false);

        }

        #endregion

        private cah1_manip2.ContactComponent contactComponent1;
    }
}