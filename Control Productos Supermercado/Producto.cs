using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Productos_Supermercado
{
    public abstract class Producto
    {
        public string categoria { get; set; }
        public string nombre { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public double precioBase { get; set; }
        public Producto(string marca, string producto, DateTime fechaVencimiento, double precioBase)
        {
            this.categoria = marca;
            this.nombre = producto;
            this.fechaVencimiento = fechaVencimiento;
            this.precioBase = precioBase;
        }
        public abstract double CalcularPrecioFinal(double precioBase, DateTime fechaVencimiento);
    }
}
