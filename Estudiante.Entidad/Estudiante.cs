using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estudiante.Entidad
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto { get; set; }
        public List<string> LibrosAcademicos { get; set; }
    }
}
