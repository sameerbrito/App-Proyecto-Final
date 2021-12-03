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
using System.Runtime.InteropServices;

namespace App_Proyecto_Final
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 Ven1 = new Form1();
            Ven1.Show();
            this.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void SingUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.White;
            }
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtCen_Enter(object sender, EventArgs e)
        {
            if (txtCen.Text == "Centro de vacunacion")
            {
                txtCen.Text = "";
                txtCen.ForeColor = Color.White;
            }
        }
        private void txtCen_Leave(object sender, EventArgs e)
        {
            if (txtCen.Text == "")
            {
                txtCen.Text = "Centro de vacunacion";
                txtCen.ForeColor = Color.Gray;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
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

        private void txtPass2_Enter(object sender, EventArgs e)
        {
            if (txtPass2.Text == "Confirmar Contraseña")
            {
                txtPass2.Text = "";
                txtPass2.ForeColor = Color.White;
                txtPass2.UseSystemPasswordChar = true;
            }
        }
        private void txtPass2_Leave(object sender, EventArgs e)
        {
            if (txtPass2.Text == "")
            {
                txtPass2.Text = "Confirmar Contraseña";
                txtPass2.ForeColor = Color.Gray;
                txtPass2.UseSystemPasswordChar = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text == "Nombre"||
                txtApellido.Text == "" || txtApellido.Text == "Apellido"||
                txtEmail.Text == "" || txtEmail.Text == "Email"||
                txtCen.Text == "" || txtCen.Text == "Centro de vacunacion"||
                txtUsuario.Text == "" || txtUsuario.Text == "Usuario"||
                txtPass.Text == "" || txtPass.Text == "Contraseña")
            {
                if (txtNombre.Text == "" || txtNombre.Text == "Nombre")
                {
                    panel.BackColor = Color.Red;
                }
                else if (txtNombre.Text != "" || txtNombre.Text != "Nombre") 
                {
                    panel.BackColor = Color.White;
                }
                if (txtApellido.Text == "" || txtApellido.Text == "Apellido") 
                {
                    panel2.BackColor = Color.Red;
                }
                else if (txtApellido.Text != "" || txtApellido.Text != "Apellido")
                {
                    panel2.BackColor = Color.White;
                }
                if (txtEmail.Text == "" || txtEmail.Text == "Email")
                {
                    panel3.BackColor = Color.Red;
                }
                else if (txtEmail.Text != "" || txtEmail.Text != "Email") 
                {
                    panel3.BackColor = Color.White;
                }
                if (txtCen.Text == "" || txtCen.Text == "Centro de vacunacion")
                {
                    panel4.BackColor = Color.Red;
                }
                else if (txtCen.Text != "" || txtCen.Text != "Centro de vacunacion") 
                {
                    panel4.BackColor = Color.White;
                }
                if (txtUsuario.Text == "" || txtUsuario.Text == "Usuario")
                {
                    panel5.BackColor = Color.Red;
                }
                else if (txtUsuario.Text != "" || txtUsuario.Text != "Usuario") 
                {
                    panel5.BackColor = Color.White;
                }
                if (txtPass.Text == "" || txtPass.Text == "Contraseña")
                {
                    panel6.BackColor = Color.Red;
                }
                else if (txtPass.Text != "" || txtPass.Text != "Contraseña") 
                {
                    panel6.BackColor = Color.White;
                }
                if (txtPass2.Text != txtPass.Text)
                {
                    panel7.BackColor = Color.Red;
                }
                else if (txtPass2.Text == txtPass.Text)
                {
                    panel7.BackColor = Color.White;
                }
                Error.Visible = true;
                Error.Text = "      Debe de rellenar los datos";
            }
            else
            {
                if (txtPass2.Text != txtPass.Text)
                {
                    panel.BackColor = Color.White;
                    panel2.BackColor = Color.White;
                    panel3.BackColor = Color.White;
                    panel4.BackColor = Color.White;
                    panel5.BackColor = Color.White;
                    panel6.BackColor = Color.White;
                    Error.Visible = true;
                    Error.Text = "      Las contraceñas no coinciden";
                }
                else
                {
                    Conexion.conectar();
                    string INSERTAR = "INSERT INTO Users (Nom_User,Ape_User,Usuario,Pass,Email,Cen_vac) " +
                        "VALUES (@txtNombre,@txtApellido,@txtUsuario,@txtPass,@txtEmail,@txtCen)";

                    SqlCommand cmd = new SqlCommand(INSERTAR, Conexion.conectar());

                    cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@txtApellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@txtUsuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@txtPass", txtPass.Text);
                    cmd.Parameters.AddWithValue("@txtEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@txtCen", txtCen.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario creado exitosamente");

                    Form1 Ven1 = new Form1();
                    Ven1.Show();
                    this.Hide();
                }
            }
        }
    }
}
