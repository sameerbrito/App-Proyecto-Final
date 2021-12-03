using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace App_Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario") 
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Gray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SingUp(Object Form)
        {
            
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            SingUp Ven2 = new SingUp();
            Ven2.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Conexion.conectar();
            string BUSCAR = "SELECT * FROM Users " +
                "WHERE Usuario='" + txtUser.Text + "' AND Pass='" + txtPass.Text + "'";

            SqlCommand cmd = new SqlCommand(BUSCAR, Conexion.conectar());

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Common.Id_user = dr.GetInt32(0);
                Common.Nom_user = dr.GetString(1);
                Common.Ape_user = dr.GetString(2);
                Common.Usuario = dr.GetString(3);
                Common.Email = dr.GetString(5);
                Common.Cen_vac = dr.GetString(6);

                MenuPrin VenPrin = new MenuPrin();
                VenPrin.Show();
                VenPrin.FormClosed += LogOut;
                this.Hide();
            }
            else 
            {
                Error.Visible = true;
                Error.Text = "      Usuario o Contraseña son incorrectos";
            }
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.IndianRed;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnCrear_MouseEnter(object sender, EventArgs e)
        {
            btnCrear.ForeColor = Color.FromArgb(0, 122, 204);
        }

        private void btnCrear_MouseLeave(object sender, EventArgs e)
        {
            btnCrear.ForeColor = Color.White;
        }

        private void lossPass_MouseEnter(object sender, EventArgs e)
        {
            lossPass.LinkColor = Color.FromArgb(0, 122, 204);
        }

        private void lossPass_MouseLeave(object sender, EventArgs e)
        {
            lossPass.LinkColor = Color.Gray;
        }
        private void LogOut(Object Sender, FormClosedEventArgs e) 
        {
            txtUser.Text="Usuario";
            txtPass.Text="Contraseña";
            txtUser.ForeColor=Color.Gray;
            txtPass.ForeColor = Color.Gray;
            txtPass.UseSystemPasswordChar = false;
            Error.Visible = false;
            this.Show();
        }
    }
}
