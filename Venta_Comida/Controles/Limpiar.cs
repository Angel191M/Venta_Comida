using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_Comida.Controles
{
    public class LimpiarTodo
    {
        public void Limpiar(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is GroupBox groupboxesXD)
                {
                    Limpiar(groupboxesXD);
                }
                else if (control is Panel paneles)
                {
                    Limpiar(paneles);
                }
            }
        }
    }
}