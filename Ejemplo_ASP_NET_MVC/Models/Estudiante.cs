using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejemplo_ASP_NET_MVC.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        public int ci { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nac { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public virtual ICollection<Telefono> telefonos { get; set; }
        public Estudiante()
        {
            telefonos = new HashSet<Telefono>();
        }
    }
}
