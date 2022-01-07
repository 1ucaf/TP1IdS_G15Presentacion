using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1IdS_G15Presentacion.Vistas
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea seleccionar un cliente?", "?", MessageBoxButtons.YesNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
