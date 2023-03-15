using System.ComponentModel.DataAnnotations;

namespace Ejemplo_ASP_NET_MVC.Models
{
    public class CuentaUsuario
    {
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Usuario { get; set; }
        [Required(ErrorMessage ="Introduzca una contraseña, no lo deje vacío")]
        [MinLength(3)]
        [MaxLength(10)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#%$]).{6,15})")]
        public string Password { get; set; }
        [Required]
        [Range(18,50,ErrorMessage ="La edad debe estar entre 18 y 50 años.")]
        public int Edad { get; set; }
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [Url]
        public string website { get; set; }
    }
}
