using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Ejemplo_ASP_NET_MVC.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Descripcion { get; set; }
        public bool Disponible { get; set; }
        public List<string> Lenguajes { get; set; }//leng1, leng2, leng3 
        public string Genero { get; set; }// M, F
        public string Cargo { get; set; } // Rol1, Rol2, Rol3...
    }
}
