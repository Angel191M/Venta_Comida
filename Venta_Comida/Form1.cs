using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_Comida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonIngreso_Click(object sender, EventArgs e)
        {
            string cuenta = textCuenta.Text;
            string clave = textClave.Text;

            if (cuenta == "admin" && clave == "12345")
            {
                this.Visible = true;
                this.ShowInTaskbar = false;
                Menu FMenu = new Menu();
                FMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La cuenta o clave son incorrectos.",
                    "Venta de Hamburguesas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
