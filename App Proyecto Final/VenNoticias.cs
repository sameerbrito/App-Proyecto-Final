using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Proyecto_Final
{
    public partial class VenNoticias : Form
    {
        public VenNoticias()
        {
            InitializeComponent();
            navegador.ScriptErrorsSuppressed = true;
        }
        private void VenNoticias_Load(object sender, EventArgs e)
        {
            String Url1 = "https://vacunasaep.org/profesionales/noticias";
            navegador.Navigate(Url1);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
