using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Productos_Supermercado
{
    public abstract class Producto
    {
        public string marca { get; set; }
        public string producto { get; set; }
        public double precioBase { get; set; }
        public Producto(string marca, string producto, double precioBase)
        {
            this.marca = marca;
            this.producto = producto;
            this.precioBase = precioBase;
        }
        public abstract double CalcularPrecioFinal(double precioBase);
    }
}
