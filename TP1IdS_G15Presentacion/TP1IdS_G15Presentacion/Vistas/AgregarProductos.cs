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
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está seguro que desea guardar?", "Confirmar Guardado", MessageBoxButtons.YesNo);
        }
    }
}
