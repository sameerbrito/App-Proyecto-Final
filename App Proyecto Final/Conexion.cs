using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace App_Proyecto_Final
{
    class Conexion
    {
        public static SqlConnection conectar() 
        {
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-ACV7CIRP;DATABASE=App;" +
                "INTEGRATED SECURITY=true");
            cn.Open();
            return cn;
        }
    }
}
