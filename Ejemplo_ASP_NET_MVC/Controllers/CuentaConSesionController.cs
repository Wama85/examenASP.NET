using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    public class CuentaConSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string usuario, string password)
        {
            if (usuario != null && password != null && usuario.Equals("Pepe") && password.Equals("123456"))
            {
                //Guardar al usuario en una sesión
                HttpContext.Session.SetString("usuario", usuario);
                return View("Exito");
            }
            else {
                ViewBag.error = "Credenciales incorrectas";
                return View("Index");
            }
            
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("usuario");
            return RedirectToAction("Index");
        }
    }
}
