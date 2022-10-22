using System.Collections.Generic;
using System.Linq;

namespace FINALASPNET.Models
{
    public class ModelProductos
    {
        private List<Producto> productos;
        public ModelProductos()
        {
            productos = new List<Producto> {
                new Producto{
                    id = 1,
                    nombre = "Atún VanCamps",
                    precio = 12,
                    imagen = "atun.jpg"
                },
                new Producto{
                    id = 2,
                    nombre = "Queso menonita",
                    precio = 45,
                    imagen = "queso.jpg"
                }
            };
        }

        public List<Producto> getTodo()
        {
            return productos;
        }
        public Producto getProducto(int id)
        {
            return productos.Single(p => p.id == id);
        }

    }
}
