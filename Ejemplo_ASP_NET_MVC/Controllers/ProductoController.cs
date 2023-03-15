using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_ASP_NET_MVC.Controllers
{
    [Route("productos")]
    public class ProductoController : Controller
    {
        [Route("index")]
        [Route("/")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("comprar/{id}")]
        public IActionResult Compra(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [Route("comprar2/{id}/{cupon}")]
        public IActionResult Compra2(int id, string cupon)
        {
            ViewBag.id = id;
            ViewBag.cupon = cupon;
            return View();
        }

        //Query Strings
        [Route("comprar3")]
        public IActionResult Compra3([FromQuery(Name = "id")] int idprod)
        {
            ViewBag.id = idprod;
            return View();
        }

        [Route("comprar4")]
        public IActionResult Compra4([FromQuery(Name = "id")] int idprod, [FromQuery(Name = "cup")] int idcupon)
        {
            ViewBag.id = idprod;
            ViewBag.cupon = idcupon;
            return View();
        }
    }
}
