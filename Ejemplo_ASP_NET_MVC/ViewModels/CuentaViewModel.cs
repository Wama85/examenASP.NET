using Ejemplo_ASP_NET_MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Ejemplo_ASP_NET_MVC.ViewModels
{
    public class CuentaViewModel
    {
        public Cuenta Cuenta { get; set; }
        public List<Lenguaje> Lenguajes { get; set; }
        public SelectList Cargos { get; set; }
    }
}
