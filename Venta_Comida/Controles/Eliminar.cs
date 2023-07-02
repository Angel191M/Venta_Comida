using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_Comida.Controles
{
    public class EliminarDatos
    {
        public class AdministradorConexionBD
        {
            private SqlConnection conexion;
            private string cadenaConexion;

            public SqlConnection Conexion
            {
                get { return conexion; }
            }

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
                    MessageBox.Show("Error al abrir la conexión: " + ex.Message);
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
                    MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
                }
            }
        }

        public class EliminarDatosFormulario
        {
            private AdministradorConexionBD adminConexion;

            public EliminarDatosFormulario()
            {
                adminConexion = new AdministradorConexionBD();
            }

            public bool EliminarCliente(int ciCliente)
            {
                if (adminConexion.AbrirConexion())
                {
                    try
                    {
                        string query = "DELETE FROM Clientes WHERE CI_cliente = @ciCliente";
                        SqlCommand command = new SqlCommand(query, adminConexion.Conexion);
                        command.Parameters.AddWithValue("@ciCliente", ciCliente);
                        command.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar los datos del cliente: " + ex.Message);
                    }
                    finally
                    {
                        adminConexion.CerrarConexion();
                    }
                }
                return false;
            }

            public bool EliminarPlatillo(int idPlatillo)
            {
                if (adminConexion.AbrirConexion())
                {
                    try
                    {
                        string query = "DELETE FROM Menu WHERE ID_Platillo = @idPlatillo";
                        SqlCommand command = new SqlCommand(query, adminConexion.Conexion);
                        command.Parameters.AddWithValue("@idPlatillo", idPlatillo);
                        command.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar los datos del platillo: " + ex.Message);
                    }
                    finally
                    {
                        adminConexion.CerrarConexion();
                    }
                }
                return false;
            }

            public bool EliminarUsuario(int ciUsuario)
            {
                if (adminConexion.AbrirConexion())
                {
                    try
                    {
                        string query = "DELETE FROM Usuarios WHERE CI_usuario = @ciUsuario";
                        SqlCommand command = new SqlCommand(query, adminConexion.Conexion);
                        command.Parameters.AddWithValue("@ciUsuario", ciUsuario);
                        command.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar los datos del usuario: " + ex.Message);
                    }
                    finally
                    {
                        adminConexion.CerrarConexion();
                    }
                }
                return false;
            }
        }
    }
}
