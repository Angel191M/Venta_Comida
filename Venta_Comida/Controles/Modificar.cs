﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_Comida.Controles;

namespace Venta_Comida.Controles
{
    public class ModificarDatos
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


        public class ModificarDatosFormulario
        {
            private AdministradorConexionBD adminConexion;

            public ModificarDatosFormulario()
            {
                adminConexion = new AdministradorConexionBD();
            }

            public bool ModificarCliente(int ciCliente, string apellidos, string nombres, int celular)
            {
                if (adminConexion.AbrirConexion())
                {
                    try
                    {
                        string query = "UPDATE Clientes SET Apellidos = @apellidos, Nombres = @nombres, Celular = @celular WHERE CI_cliente = @ciCliente";
                        SqlCommand command = new SqlCommand(query, adminConexion.Conexion);
                        command.Parameters.AddWithValue("@ciCliente", ciCliente);
                        command.Parameters.AddWithValue("@apellidos", apellidos);
                        command.Parameters.AddWithValue("@nombres", nombres);
                        command.Parameters.AddWithValue("@celular", celular);
                        command.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar los datos del cliente: " + ex.Message);
                    }
                    finally
                    {
                        adminConexion.CerrarConexion();
                    }
                }
                return false;
            }

            public bool ModificarPlatillo(int idPlatillo, string nombre, int cantidadInventario, DateTime fechaElaboracion, decimal precio)
            {
                if (adminConexion.AbrirConexion())
                {
                    try
                    {
                        string query = "UPDATE Menu SET Nombres = @nombre, Cantidad_inventario = @cantidadInventario, Fecha_elaboracion = @fechaElaboracion, Precio = @precio WHERE ID_Platillo = @idPlatillo";
                        SqlCommand command = new SqlCommand(query, adminConexion.Conexion);
                        command.Parameters.AddWithValue("@idPlatillo", idPlatillo);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@cantidadInventario", cantidadInventario);
                        command.Parameters.AddWithValue("@fechaElaboracion", fechaElaboracion);
                        command.Parameters.AddWithValue("@precio", precio);
                        command.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar los datos del platillo: " + ex.Message);
                    }
                    finally
                    {
                        adminConexion.CerrarConexion();
                    }
                }
                return false;
            }

            public bool ModificarUsuario(int ciUsuario, string apellidos, string nombres, DateTime fechaNacimiento, string cuenta, string clave, string rol, decimal salario)
            {
                if (adminConexion.AbrirConexion())
                {
                    try
                    {
                        string query = "UPDATE Usuarios SET Apellidos = @apellidos, Nombres = @nombres, Fecha_nac = @fechaNacimiento, Cuenta = @cuenta, Clave = @clave, Rol = @rol, Salario = @salario WHERE CI_usuario = @ciUsuario";
                        SqlCommand command = new SqlCommand(query, adminConexion.Conexion);
                        command.Parameters.AddWithValue("@ciUsuario", ciUsuario);
                        command.Parameters.AddWithValue("@apellidos", apellidos);
                        command.Parameters.AddWithValue("@nombres", nombres);
                        command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                        command.Parameters.AddWithValue("@cuenta", cuenta);
                        command.Parameters.AddWithValue("@clave", clave);
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@salario", salario);
                        command.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar los datos del usuario: " + ex.Message);
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