using Ejemplo_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    public class EjemplosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EjemploPasarDatos()
        {
            ViewBag.edad = 13;
            ViewBag.nombre = "Pepe";
            ViewBag.aprobado = true;
            ViewBag.calificacion = 67.5;
            ViewBag.fechaAprobacion = DateTime.Now;
            return View();
        }

        public IActionResult EjemploPasarDatosObjeto()
        {
            var prod = new Producto {
                Id = "atn",
                Nombre = "Atún",
                Foto = "atun.jpg",
                Precio = 10.5,
                Cantidad = 5
            };
            ViewBag.producto = prod;
            return View();
        }

        public IActionResult EjemploPasarDatosObjetos()
        {
            var prods = new List<Producto> {
                new Producto
            {
                Id = "atn",
                Nombre = "Atún",
                Foto = "atun.jpg",
                Precio = 10.5,
                Cantidad = 5
            },
                new Producto
            {
                Id = "qs",
                Nombre = "Queso menonita",
                Foto = "queso.jpg",
                Precio = 25.0,
                Cantidad = 8
            },
                new Producto
            {
                Id = "qs",
                Nombre = "Queso menonita",
                Foto = "uno.jpeg",
                Precio = 25.0,
                Cantidad = 8
            },
                new Producto
            {
                Id = "qs",
                Nombre = "Queso menonita",
                Foto = "dos.jpeg",
                Precio = 25.0,
                Cantidad = 8
            },
                new Producto
            {
                Id = "qs",
                Nombre = "Queso menonita",
                Foto = "tres.jpeg",
                Precio = 25.0,
                Cantidad = 8
            }
            };
            ViewBag.productos = prods;
            return View();
        }
    }
}
