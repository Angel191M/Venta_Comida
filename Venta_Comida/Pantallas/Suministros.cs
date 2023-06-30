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
    public partial class Suministros : Form
    {
        public Suministros()
        {
            InitializeComponent();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Menu Atras = new Menu();
            Atras.Show();
            this.Hide();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            GroupBox GroupBoxPlatillos = groupBox1;
            LimpiarTodo limpiador = new LimpiarTodo();
            limpiador.Limpiar(GroupBoxPlatillos);
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            GroupBox GroupBoxClientes = groupBox2;
            LimpiarTodo limpiador = new LimpiarTodo();
            limpiador.Limpiar(GroupBoxClientes);
        }
    }
}
