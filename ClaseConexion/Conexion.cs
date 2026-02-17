using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ClaseConexion
{
    public class Conexion
    {
        private readonly string cadenaconexion = "Data Source=JORDYS;Initial Catalog=ProHardware_Solutions;Integrated Security=True;Trust Server Certificate=True";

        private SqlConnection cn;


        public SqlConnection AbrirConexion()
        {
            if(cn == null)
                cn = new SqlConnection(cadenaconexion);



            //Método para abrir conexión a la base de datos

            if(cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            return cn;
        }


        public void CerrarConexion()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }

}
