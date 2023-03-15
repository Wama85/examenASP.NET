using Ejemplo_ASP_NET_MVC.Herramientas;
using Ejemplo_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    public class SesionesController : Controller
    {
        public IActionResult Index()
        {
            //Almacenando valores primitivos en sesión:
            HttpContext.Session.SetInt32("edad", 18);
            HttpContext.Session.SetString("usuario", "pepe");

            //Almacenando un objeto Producto en sesión:
            Producto producto = new Producto {
                Id = "prod01",
                Nombre = "Atún",
                Foto = "atun.jpg",
                Precio = 14.5,
                Cantidad = 10
            };
            /*
               {
                   "Id": "prod01",
                   "Nombre": "Atún",
                   "Foto": "atun.jpg"
               }

               {
                   "Id": "123456LP",
                   "Nombre": "Pepe",
                   "Foto": "perfil.jpg"
               }
            */

            ConversorParaSesiones.ObjetoAjson(HttpContext.Session, "producto", producto);

            //Pasando una lista de productos
            List<Producto> productos = new List<Producto>() {
                new Producto {
                    Id = "prod01",
                    Nombre = "Atún",
                    Foto = "atun.jpg",
                    Precio = 14.5,
                    Cantidad = 10
                },
                new Producto {
                    Id = "prod02",
                    Nombre = "Queso",
                    Foto = "queso.jpg",
                    Precio = 20.5,
                    Cantidad = 12
                },
                new Producto {
                    Id = "prod03",
                    Nombre = "Galleta",
                    Foto = "galleta.jpg",
                    Precio = 25,
                    Cantidad = 24
                }
            };
            ConversorParaSesiones.ObjetoAjson(HttpContext.Session, "productos", productos);

            return View("Index");
        }
    }
}
