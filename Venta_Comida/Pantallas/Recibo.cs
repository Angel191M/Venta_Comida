using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private int id;

        public string Pedido { get; set; }
        public int CostoTotal { get; set; }
        public int Ci { get; set; }
        public int Id { get; set; }
        private void PasoDatos(object sender, EventArgs e)
        {
            textFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            textDetalle.Text = Pedido;
            textPrecio.Text = CostoTotal.ToString();
            textCI.Text = Ci.ToString();
            textId.Text = Id.ToString();
        }
        public Recibo()
        {
            InitializeComponent();
            this.Load += PasoDatos;
        }
        private void GenerarRecibo(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Times New Roman", 14);
            Brush brush = Brushes.Black;
            float yPos = 100;
            string nombreCompleto = textNombreCom.Text;
            string numeroPedido = textId.Text;
            string carnetIdentidad = textCI.Text;
            string detalle = textDetalle.Text;
            string precio = textPrecio.Text;
            string fechaEmision = textFecha.Text;
            string contenido = $"Recibo #{numeroPedido}\n\n" +
                               $"Fecha: {fechaEmision}\n" +
                               $"Nombre: {nombreCompleto}\n" +
                               $"Carnet de Identidad: {carnetIdentidad}\n" +
                               $"Detalle: {detalle}\n" +
                               $"Precio: {precio}";
            Image imagenOriginal = Image.FromFile("C:\\Users\\ACER\\OneDrive\\Escritorio\\Venta_Comida\\IMAGEN\\photo_2023-07-01_00-04-24.jpg");
            int imagenAncho = Convert.ToInt32(0.2 * e.PageSettings.PrinterResolution.X / 2.54);
            int imagenAlto = Convert.ToInt32(0.2 * e.PageSettings.PrinterResolution.Y / 2.54);
            Image imagenRedimensionada = new Bitmap(imagenOriginal, imagenAncho, imagenAlto);
            graphics.DrawImage(imagenRedimensionada, new Point(50, 50));
            graphics.DrawString(contenido, font, brush, new PointF(50, yPos));
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

        private void textFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombreCom.Text) || string.IsNullOrWhiteSpace(textCI.Text))
            {
                MessageBox.Show("No se puede imprimir, complete todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(GenerarRecibo);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
            
            Pedidos Atras = new Pedidos();
            Atras.Show();
            this.Hide();
        }
    }
}
