using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    public class AppSettingsController : Controller
    {
        private IConfiguration configuracion;
        public AppSettingsController(IConfiguration configuration) {
            configuracion = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.elemento1 = configuracion["Mensaje"];
            ViewBag.elemento2 = configuracion["ConfiguracionesVarias:ConfiguracionA"];
            ViewBag.elemento3 = configuracion["ConfiguracionesVarias:ConfiguracionB"];
            ViewBag.elemento4 = configuracion["ConfiguracionesVarias:ConfiguracionC"];
            ViewBag.elemento5 = configuracion["Logging:LogLevel:Microsoft"];
            return View();
        }
    }
}
