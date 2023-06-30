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
using Venta_Comida.PrimerSprint;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Venta_Comida.Pantallas
{
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Pedidos Atras = new Pedidos();
            Atras.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
