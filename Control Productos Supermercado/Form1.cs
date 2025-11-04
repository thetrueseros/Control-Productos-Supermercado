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
            try
            {
                if (cmbTipoProducto.Text == "(Seleccione)")
                {
                    throw new ArgumentException("No has seleccionado un tipo de producto.");
                }
                if (string.IsNullOrWhiteSpace(txtbPrecioBase.Text))
                {
                    throw new ArgumentNullException("El campo de precio base no puede estar vacío.");
                }
                if (double.TryParse(txtbPrecioBase.Text, out double precioBase) == false)
                {
                    throw new ArgumentException("El campo de precio base debe ser un número válido.");
                }
                if (double.Parse(txtbPrecioBase.Text) <= 0)
                {
                    throw new ArgumentOutOfRangeException("El campo de precio base no puede ser menor a 1");
                }
                if (string.IsNullOrWhiteSpace(txtbCategoría.Text))
                {
                    throw new ArgumentNullException("El campo de categoría no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(txtbNombreProd.Text))
                {
                    throw new ArgumentNullException("El campo de nombre del producto no puede estar vacío.");
                }
                if (string.IsNullOrWhiteSpace(dtpFechaVence.Text) && cmbTipoProducto.Text == "Perecedero")
                {
                    throw new ArgumentNullException("La fecha de vencimiento no puede estar vacía.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
