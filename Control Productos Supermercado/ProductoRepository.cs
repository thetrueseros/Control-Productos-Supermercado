using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Control_Productos_Supermercado
{
    public class ProductoRepository
    {
        public static ProductoRepository instancia;
        private List<string> productos = new List<string>();
        private readonly string rutaArchivo = "productos.txt";

        /// <summary>
        /// Constructor privado para implementar el patrón Singleton
        /// </summary>
        private ProductoRepository()
        {
            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }
            productos = File.ReadAllLines(rutaArchivo).ToList();
        }

        /// <summary>
        /// Instancia singleton de ProductoRepository
        /// </summary>
        public static ProductoRepository Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ProductoRepository();
                return instancia;
            }
        }

        /// <summary>
        /// Devuelve una copia de la lista de líneas (para mostrar en la UI)
        /// </summary>
        public List<string> ObtenerListaProductos()
        {
            // se devuelve una copia para evitar modificaciones directas desde la UI
            return new List<string>(productos);
        }

        /// <summary>
        /// Agrega un vehículo (construye la línea) y la guarda en el fichero en modo append
        /// </summary>
        public void Agregar(Producto prod)
        {
            if (prod == null) return;
            string linea = "Categoría: " + prod.categoria +
                           ", Nombre: " + prod.nombre +
                           ", Precio final: " + prod.CalcularPrecioFinal(prod.precioBase, prod.fechaVencimiento);
            productos.Add(linea);

            // se guarda sólo la línea nueva en modo append para no sobrescribir el fichero
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(linea);
            }
        }
    }
}
