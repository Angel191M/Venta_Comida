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
    public partial class Reporte : Form
    {
        public Reporte()
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
            GroupBox GroupBoxUsuarios = groupBox1;
            LimpiarTodo limpiador = new LimpiarTodo();
            limpiador.Limpiar(GroupBoxUsuarios);
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdD_Venta_ComidaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bdD_Venta_ComidaDataSet.Usuarios);

        }
    }
}
