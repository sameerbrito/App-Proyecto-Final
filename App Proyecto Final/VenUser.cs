using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace App_Proyecto_Final
{
    public partial class VenUser : Form
    {
        public VenUser()
        {
            InitializeComponent();
        }
        private void Datos() 
        {
            lblNombre.Text = Common.Nom_user;
            lblApellido.Text = Common.Ape_user;
            lblUsuario.Text = Common.Usuario;
            lblEmail.Text = Common.Email;
            lblVac.Text = Common.Cen_vac;
        }
        private void VenUser_Load(object sender, EventArgs e)
        {
            Datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs==DialogResult.OK) 
            {
                ImagenCli.Image = Image.FromFile(fo.FileName);
            }
        }
    }
}
