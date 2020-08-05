using Estudiante.Interface;
using System.Collections.Generic;

namespace Estudiante.Implementacion
{
    public class EstudianteSobresaliente : IEstudiante
    {

        private string nombre;
        private string apellido;
        private List<string> librosAcademicos;

        public int Id { get; set; }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string NombreCompleto { get; set; }
        public List<string> LibrosAcademicos { get; set; } = new List<string> { "Progrmacion", "Base de Datos" };


        public string Estudiar()
        {
            return $"Hola soy {NombreCompleto} un estudiante muy dedicado y me gusta estudiar y para mejor aprendisaje uso {LibrosAcademicos[2]} ";
        }
        public string PresentarDeberes()
        {
            return "Siempre entrego mis deberes a tiempo";
        }
        public string Participar()
        {
            return "Me gusta mucho hacer preguntas y aprender nuevas cosas";
        }
        public string PonerAtencion()
        {
            return "Me gusta poner atencion para hacer preguntas y participar";
        }
        public string Leer()
        {
            return "Me gusta leer mucho ademas aprendo a expresarme mejor";
        }

    }
}