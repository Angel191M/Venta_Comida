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
using Venta_Comida.Pantallas;
using static System.Net.Mime.MediaTypeNames;

namespace Venta_Comida.PrimerSprint
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Menu Atras = new Menu();
            Atras.Show();
            this.Hide();
        }

        private void botonCliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.Show();
            this.Hide();
        }

        private void botonCancel_Click(object sender, EventArgs e)
        {
            Panel PanelPedidos = panel1;
            LimpiarTodo limpiador = new LimpiarTodo();
            limpiador.Limpiar(PanelPedidos);
        }

        private void botonRecibo_Click(object sender, EventArgs e)
        {
            Recibo reci = new Recibo();
            reci.Show();
            this.Hide();
        }

        private void botonH1_Click(object sender, EventArgs e)
        {

        }
    }
}
