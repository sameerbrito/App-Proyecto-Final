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
    public partial class VenCentros : Form
    {
        public VenCentros()
        {
            InitializeComponent();
            navegador1.ScriptErrorsSuppressed = true;
        }

        private void VenCentros_Load(object sender, EventArgs e)
        {
            String Url = "https://www.google.com/maps/d/u/0/embed?mid=1Fb7LlK3W" +
                "qGsu2l8HmHrLSg0pD4J9ICdv&ll=18.472186547942567%2C-69.90696334887465&z=14";
            navegador1.Navigate(Url);
        }

        private void navegador1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
