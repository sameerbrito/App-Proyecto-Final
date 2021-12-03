
namespace App_Proyecto_Final
{
    partial class VenNoticias
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
            this.navegador = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // navegador
            // 
            this.navegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navegador.Location = new System.Drawing.Point(0, 0);
            this.navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador.Name = "navegador";
            this.navegador.Size = new System.Drawing.Size(643, 513);
            this.navegador.TabIndex = 0;
            this.navegador.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // VenNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 513);
            this.Controls.Add(this.navegador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VenNoticias";
            this.Text = "VenNoticias";
            this.Load += new System.EventHandler(this.VenNoticias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser navegador;
    }
}