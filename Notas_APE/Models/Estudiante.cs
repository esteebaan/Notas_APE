using System.ComponentModel.DataAnnotations;

namespace Notas_APE.Models
{
    public class Estudiante
    {
        [Key]
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }
        public ICollection<Nota> Notas { get; set; }
    }
}
