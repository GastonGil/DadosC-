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
    public partial class NombresJugadores : Form
    {
        public NombresJugadores()
        {
            InitializeComponent();
        }

        private void tIngresarNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tIngresarNombres_Enter(object sender, EventArgs e)
        {
        
        }

        public TextBox getTIngresarNombres()
        {
        return this.tIngresarNombres;
        }

        private void bConfirmar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
