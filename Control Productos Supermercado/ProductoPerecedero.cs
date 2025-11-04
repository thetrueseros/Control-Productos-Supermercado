using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Productos_Supermercado
{
    public class ProductoPerecedero : Producto
    {
        public ProductoPerecedero(string categoria, string nombre, DateTime fechaVencimiento, double precioBase) : base(categoria, nombre, fechaVencimiento, precioBase)
        {
        }
        public override double CalcularPrecioFinal(double precioBase, DateTime fechaVencimiento)
        {
            if (fechaVencimiento <= DateTime.Now.AddDays(5))
            {
                return precioBase * 0.9;
            }
            else
            {
                return precioBase;
            }
        }
    }
}
