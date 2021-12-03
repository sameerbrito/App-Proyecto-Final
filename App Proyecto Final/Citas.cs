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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }
        public DataTable LlenarTable()
        {
            Conexion.conectar();
            DataTable dt = new DataTable();
            string Consulta = "SELECT * FROM Citas";
            SqlCommand cmd = new SqlCommand(Consulta, Conexion.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }
        private void Citas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarTable();
        }
    }
}
