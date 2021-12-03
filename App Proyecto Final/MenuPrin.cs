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

namespace App_Proyecto_Final
{
    public partial class MenuPrin : Form
    {
        public MenuPrin()
        {
            InitializeComponent();
        }
        private void Inicio(Object Form)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven = Form as Form;
            Ven.TopLevel = false;
            Ven.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven);
            this.Contenedor.Tag = Ven;
            Ven.Show();
        }
        private void MenuPrin_Load(object sender, EventArgs e)
        {
            Inicio(new Inicio());
            btnLogOut.Visible = false;
            panel1.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.IndianRed;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(0, 122, 204);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.FromArgb(21, 68, 100);
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.FromArgb(0, 122, 204);
        }
        private void VenUser(Object Form5)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven = Form5 as Form;
            Ven.TopLevel = false;
            Ven.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven);
            this.Contenedor.Tag = Ven;
            Ven.Show();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            VenUser(new VenUser());

            btnLogOut.Visible = true;
            panel1.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Info(Object Form)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven = Form as Form;
            Ven.TopLevel = false;
            Ven.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven);
            this.Contenedor.Tag = Ven;
            Ven.Show();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            Info(new Info());
            btnLogOut.Visible = false;
            panel1.Visible = false;
        }
        private void VenVac(Object Form)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven = Form as Form;
            Ven.TopLevel = false;
            Ven.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven);
            this.Contenedor.Tag = Ven;
            Ven.Show();
        }
        private void btnVac_Click(object sender, EventArgs e)
        {
            VenVac(new VenVac());
            btnLogOut.Visible = false;
            panel1.Visible = false;
        }
        private void VenNoticias(Object Form)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven = Form as Form;
            Ven.TopLevel = false;
            Ven.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven);
            this.Contenedor.Tag = Ven;
            Ven.Show();
        }
        private void btnNot_Click(object sender, EventArgs e)
        {
            VenNoticias(new VenNoticias());
            btnLogOut.Visible = false;
            panel1.Visible = false;
        }
        private void VenCentros(Object Form)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven = Form as Form;
            Ven.TopLevel = false;
            Ven.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven);
            this.Contenedor.Tag = Ven;
            Ven.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            VenCentros(new VenCentros());
            btnLogOut.Visible = false;
            panel1.Visible = false;
        }
        private void Citas(Object Form)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven = Form as Form;
            Ven.TopLevel = false;
            Ven.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven);
            this.Contenedor.Tag = Ven;
            Ven.Show();
        }
        private void btnCitas_Click(object sender, EventArgs e)
        {
            Citas(new Citas());
            btnLogOut.Visible = false;
            panel1.Visible = false;
        }
        private void Ajustes(Object Form)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            Form Ven = Form as Form;
            Ven.TopLevel = false;
            Ven.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(Ven);
            this.Contenedor.Tag = Ven;
            Ven.Show();
        }
        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Ajustes(new Ajustes());
            btnLogOut.Visible = false;
            panel1.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio(new Inicio());
            btnLogOut.Visible = false;
            panel1.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(21, 68, 100);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(0, 122, 204);
        }
    }
}
