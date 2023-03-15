using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    public class EjemplosConttoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
