using Ejemplo_ASP_NET_MVC.Herramientas;
using Ejemplo_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            
            var carrito = ConversorParaSesiones.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito");
            ViewBag.carrito = carrito;
            ViewBag.total = carrito.Sum(it => it.Producto.Precio * it.Cantidad);
            return View();
        }
        [Route("Agregar/{id}")]
        public IActionResult Agregar(string id) {
            ProductoModel prodMod = new ProductoModel();
            if (ConversorParaSesiones.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito") == null)
            {
                List<Item> carrito = new List<Item>();
                carrito.Add(new Item { Producto = prodMod.getProducto(id), Cantidad = 1 });
                ConversorParaSesiones.ObjetoAjson(HttpContext.Session, "carrito", carrito);
            }
            else {
                List<Item> carrito = ConversorParaSesiones.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito");
                int indice = existeProducto(id);
                if (indice > -1) {
                    
                    carrito[indice].Cantidad++;
                }
                else {
                    carrito.Add(new Item { Producto = prodMod.getProducto(id), Cantidad = 1 });
                }
                ConversorParaSesiones.ObjetoAjson(HttpContext.Session, "carrito", carrito);
            }
            return RedirectToAction("Index");
        }

        private int existeProducto(string id)
        {
            List<Item> carrito = ConversorParaSesiones.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito");
            for (int i= 0; i< carrito.Count; i++) {
                if (carrito[i].Producto.Id.Equals(id))
                    return i;
            }
            return -1;
        }
        [Route("Quitar/{id}")]
        public IActionResult Quitar(string id) {
            List<Item> carrito = ConversorParaSesiones.JsonAobjeto<List<Item>>(HttpContext.Session, "carrito");
            int indice = existeProducto(id);
            carrito.RemoveAt(indice);
            ConversorParaSesiones.ObjetoAjson(HttpContext.Session, "carrito", carrito);
            return RedirectToAction("Index");
        }
        [Route("Finalizar/{id}")]
        public IActionResult Finalizar(string id)
        {

            return View();
        }
    }
}
