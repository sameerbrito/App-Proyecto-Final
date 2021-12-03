
namespace App_Proyecto_Final
{
    partial class VenCentros
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
            this.navegador1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(643, 513);
            this.navegador1.TabIndex = 0;
            this.navegador1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.navegador1_DocumentCompleted);
            // 
            // VenCentros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 513);
            this.Controls.Add(this.navegador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenCentros";
            this.Text = "VenCentros";
            this.Load += new System.EventHandler(this.VenCentros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser navegador1;
    }
}