using Ejemplo_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    public class SubirController : Controller
    {
        IWebHostEnvironment webHostEnvironment;
        public SubirController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View("Index", new Producto());
        }
        public IActionResult Guardar(Producto producto, IFormFile foto)
        {
            if (foto == null || foto.Length == 0)
                return Content("Archivo no elegido adecuadamente");
            else
            {
                var ruta = Path.Combine(webHostEnvironment.WebRootPath, "imagenes", foto.FileName);
                var stream = new FileStream(ruta, FileMode.Create);
                foto.CopyToAsync(stream);
                producto.Foto = foto.FileName;
            }
            ViewBag.producto = producto;

            return View("Exito");
        }
    }
}
