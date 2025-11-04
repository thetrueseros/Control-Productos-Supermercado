using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Productos_Supermercado
{
    public class ProductoNoPerecedero : Producto
    {
        public ProductoNoPerecedero(string categoria, string nombre, DateTime fechaVencimiento, double precioBase) : base(categoria, nombre, fechaVencimiento, precioBase)
        {
        }
        public override double CalcularPrecioFinal(double precioBase, DateTime fechaVencimiento)
        {
            if (precioBase > 100000)
            {
                return precioBase*0.95;
            }
            else
            {
                return precioBase;
            }
        }
    }
}
