using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Productos_Supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoProducto.SelectedIndex = 0;
        }

        private void cmbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoProducto.SelectedIndex == 1) // Perecedero
            {
                lblObligatorio.Visible = true;
                lblFechaVencimiento.Enabled = true;
                dtpFechaVence.Enabled = true;
            }
            else // No perecedero
            {
                lblObligatorio.Visible = false;
                lblFechaVencimiento.Enabled = false;
                dtpFechaVence.Enabled = false;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
