using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_Comida.Pantallas;
using Venta_Comida.PrimerSprint;

namespace Venta_Comida
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void botonUsuarios_Click(object sender, EventArgs e)
        {
            Reporte usu = new Reporte();
            usu.Show();
            this.Hide();
        }

        private void botonPedido_Click(object sender, EventArgs e)
        {
            Pedidos ped = new Pedidos();
            ped.Show();
            this.Hide();
        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
            this.Hide();
        }

        private void botonSuministros_Click(object sender, EventArgs e)
        {
            Suministros sumo = new Suministros();
            sumo.Show();
            this.Hide();
        }

        private void botonVentas_Click(object sender, EventArgs e)
        {
            Ventas rep = new Ventas();
            rep.Show();
            this.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
