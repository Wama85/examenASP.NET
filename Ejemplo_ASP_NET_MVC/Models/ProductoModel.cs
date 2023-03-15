using System.Collections.Generic;
using System.Linq;

namespace Ejemplo_ASP_NET_MVC.Models
{
    public class ProductoModel
    {
        private List<Producto> productos;
        public ProductoModel() {
            productos = new List<Producto>() { 
                new Producto{ 
                    Id = "prod01",
                    Nombre = "Atun",
                    Precio = 12.5,
                    Foto = "atun.jpg",
                },
                new Producto{
                    Id = "prod02",
                    Nombre = "Queso",
                    Precio = 10,
                    Foto = "queso.jpg",
                },
                new Producto{
                    Id = "prod03",
                    Nombre = "Galleta",
                    Precio = 24,
                    Foto = "724e1d82c2c537737c11e0219a9fd238.png",
                },new Producto{
                    Id = "prod04",
                    Nombre = "Mapache",
                    Precio = 200,
                    Foto = "uno.jpeg",
                }
            };
        }
        //Bienvenidos a LINQ
        public List<Producto> getTodo() {
            return productos;
        }
        public Producto getProducto(string id) {
            return productos.Single(p => p.Id.Equals(id));
        }
    }
}
