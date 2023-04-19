using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosC
{
    public partial class CantidadJugadores : Form
    {
        public CantidadJugadores()
        {
            InitializeComponent();
        }

        private void tIngresarCantidad_Enter(object sender, EventArgs e)
        {
            tIngresarCantidad.Text = "";
        }

        private void tIngresarCantidad_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(tIngresarCantidad.Text, out _))
            {
                tIngresarCantidad.Text = "";
            }
        }

        private void tIngresarCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CantidadJugadores_Load(object sender, EventArgs e)
        {

        }

        public TextBox getTIngresarCantidad ()
        {
            return this.tIngresarCantidad;
        } 
    }
}
