using Ejemplo_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    public class ProductoParaCarritoController : Controller
    {
        public IActionResult Index()
        {
            var prodModel = new ProductoModel();
            ViewBag.productos = prodModel.getTodo();
            return View();
        }
    }
}
