using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_Comida.Controles;

namespace Venta_Comida.Pantallas
{
    public partial class Clientes : Form
    {
        private InsertarDatos insertarDatos;
        private ModificarDatos modificarDatos;
        private EliminarDatos eliminarDatos;
        ModificarDatos.ModificarDatosFormulario modificarDatosFormulario = new ModificarDatos.ModificarDatosFormulario();
        EliminarDatos.EliminarDatosFormulario eliminarDatosFormulario;
        public Clientes()
        {
            InitializeComponent();
            insertarDatos = new InsertarDatos();
            modificarDatos = new ModificarDatos();
            eliminarDatos = new EliminarDatos();
            eliminarDatosFormulario = new EliminarDatos.EliminarDatosFormulario();
            botonEliminar.Click += botonEliminar_Click;
            botonModificar.Click += botonModificar_Click;
            botonAgregar.Click += botonAgregar_Click;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Menu Atras = new Menu();
            Atras.Show();
            this.Hide();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            GroupBox GroupBoxClientes = groupBox1;
            LimpiarTodo limpiador = new LimpiarTodo();
            limpiador.Limpiar(GroupBoxClientes);
        }

        private void botonCancelarB_Click(object sender, EventArgs e)
        {
            GroupBox GroupBoxClientes = groupBox2;
            LimpiarTodo limpiador = new LimpiarTodo();
            limpiador.Limpiar(GroupBoxClientes);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.bdD_Venta_ComidaDataSet.Clientes);

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

            int ciCliente = ObtenerCiCliente();
            string apellidos = ObtenerApellidos();
            string nombres = ObtenerNombres(); 
            int celular = ObtenerCelular(); 

            bool resultado = insertarDatos.InsertarCliente(ciCliente, apellidos, nombres, celular);

            if (resultado)
            {
                MessageBox.Show("Cliente insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar el cliente");
            }
        }
        private int ObtenerCiCliente()
        {
            if (int.TryParse(textCi.Text, out int ciCliente))
            {
                return ciCliente;
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el CI del cliente");
                return 0;
            }
        }
        private string ObtenerApellidos()
        {
            return textApellidos.Text;
        }

        private string ObtenerNombres()
        {
            return textNombres.Text;
        }
        private int ObtenerCelular()
        {
            if (int.TryParse(textCelular.Text, out int celular))
            {
                return celular;
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el número de celular");
                return 0; 
            }
        }
        private void botonModificar_Click(object sender, EventArgs e)
        {
            int ciCliente = ObtenerCiCliente(); 
            string apellidos = ObtenerApellidos(); 
            string nombres = ObtenerNombres(); 
            int celular = ObtenerCelular();
            bool resultado = modificarDatosFormulario.ModificarCliente(ciCliente, apellidos, nombres, celular);
            if (resultado)
            {
                MessageBox.Show("Cliente modificado correctamente");
            }
            else
            {
                MessageBox.Show("Error al modificar el cliente");
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            int ciCliente = ObtenerCiCliente();

            bool resultado = eliminarDatosFormulario.EliminarCliente(ciCliente);

            if (resultado)
            {
                MessageBox.Show("Cliente eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente");
            }
        }
    }
}
