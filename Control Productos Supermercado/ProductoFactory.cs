using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Productos_Supermercado
{
    public class ProductoFactory
    {
        public static Producto CrearProducto(string tipo, string categoria, string nombre, DateTime fechaVencimiento, double precioBase)
        {
            try
            {
                switch (tipo)
                {
                    case "Perecedero":
                        return new ProductoPerecedero(categoria, nombre, fechaVencimiento, precioBase);
                    case "No perecedero":
                        return new ProductoNoPerecedero(categoria, nombre, fechaVencimiento, precioBase);
                    default:
                        throw new ArgumentException("Tipo de producto no válido.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
