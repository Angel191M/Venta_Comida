using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_Comida
{
    public class AdministradorConexionBD
    {
        private SqlConnection conexion;
        private string cadenaConexion;

        public AdministradorConexionBD()
        {
            string servidor = "DESKTOP-DVQ5DQP\\SQLEXPRESS";
            string baseDatos = "BdD_Venta_Comida";
            string usuario = "DESKTOP-DVQ5DQP\\ACER";
            string contraseña = "";
            cadenaConexion = $"Data Source={servidor};Initial Catalog={baseDatos};User ID={usuario};Password={contraseña}";
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return false;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}