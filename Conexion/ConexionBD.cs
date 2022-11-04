using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace prueba.Conexion
{
    internal class ConexionBD
    {
        private string cadenaconexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=pruebas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection conn;
        private SqlCommand cmd;

        private SqlDataAdapter adapter;

        private void Conectar()
        {
            conn = new SqlConnection(cadenaconexion);

        }

        public ConexionBD()
        {
            Conectar();
        }

    }
}
