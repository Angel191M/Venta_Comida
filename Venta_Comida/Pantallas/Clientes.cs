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
        public Clientes()
        {
            InitializeComponent();
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
            // TODO: esta línea de código carga datos en la tabla 'bdD_Venta_ComidaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.bdD_Venta_ComidaDataSet.Clientes);

        }
    }
}
