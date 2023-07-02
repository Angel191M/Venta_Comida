using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Venta_Comida.Controles;
using Venta_Comida.Pantallas;
using static System.Net.Mime.MediaTypeNames;

namespace Venta_Comida.PrimerSprint
{
    public partial class Pedidos : Form
    {
        
        private Recibo formularioDestino;
        public int Id { get; set; } = 1;
        public Pedidos()
        {
            InitializeComponent();
            formularioDestino = new Recibo();
            textId.Text = Id.ToString();
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
            if (string.IsNullOrWhiteSpace(textId.Text) || string.IsNullOrWhiteSpace(textCI.Text) || string.IsNullOrWhiteSpace(textTCosto.Text))
            {
                MessageBox.Show("Datos incompletos, complete los datos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            formularioDestino.Pedido = textPedido.Text;
            formularioDestino.CostoTotal = int.Parse(textTCosto.Text);
            formularioDestino.Ci = int.Parse(textCI.Text);
            formularioDestino.Id = int.Parse(textId.Text);
            formularioDestino.Show();
            this.Hide();
        }

        private void botonH1_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Pipocas de Pollo";
            textUCosto.Text = "23";
            textCantidad.Text = "1";
        }

        private void botonJ4_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Juego de Durazno";
            textUCosto.Text = "12";
            textCantidad.Text = "1";
        }


        private void botonCalcularTotal_Click(object sender, EventArgs e)
        {
            int cantidad, precio, total;
            if (int.TryParse(textCantidad.Text, out cantidad))
            {
                if (int.TryParse(textUCosto.Text, out precio))
                {
                    total = cantidad * precio;
                    textTCosto.Text = total.ToString();
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void botonH2_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Pollo al Horno";
            textUCosto.Text = "75";
            textCantidad.Text = "1";
        }

        private void botonH3_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Sandwich de Pollo";
            textUCosto.Text = "25";
            textCantidad.Text = "1";
        }

        private void botonH4_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Pollo a la Broaster";
            textUCosto.Text = "25";
            textCantidad.Text = "1";
        }

        private void botonH5_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Bagel Sandwich";
            textUCosto.Text = "26";
            textCantidad.Text = "1";
        }

        private void botonH6_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Socafusión";
            textUCosto.Text = "22";
            textCantidad.Text = "1";
        }

        private void botonH7_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Socafusión Picante-Dulce";
            textUCosto.Text = "22";
            textCantidad.Text = "1";
        }

        private void botonH8_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Sandwich";
            textUCosto.Text = "20";
            textCantidad.Text = "1";
        }

        private void botonR1_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Coca Cola";
            textUCosto.Text = "6";
            textCantidad.Text = "1";
        }

        private void botonR2_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Fanta";
            textUCosto.Text = "6";
            textCantidad.Text = "1";
        }

        private void botonR3_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Sprite";
            textUCosto.Text = "6";
            textCantidad.Text = "1";
        }

        private void botonJ1_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Juego de Frutilla";
            textUCosto.Text = "12";
            textCantidad.Text = "1";
        }

        private void botonJ2_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Juego de Platano";
            textUCosto.Text = "12";
            textCantidad.Text = "1";
        }

        private void botonJ3_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Juego de Limon";
            textUCosto.Text = "12";
            textCantidad.Text = "1";
        }

        private void botonJ5_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Juego de Piña";
            textUCosto.Text = "12";
            textCantidad.Text = "1";
        }

        private void botonJ6_Click(object sender, EventArgs e)
        {
            textPedido.Text = "Juego de Papaya";
            textUCosto.Text = "12";
            textCantidad.Text = "1";
        }
    }
}
