using Estudiante.Interface;
using System;

namespace Estudiante.Intituto
{
    public class Instituto
    {
        public IEstudiante Estudiante { get; set; }
        
        public string RegistrarEstudiante(IEstudiante estudiante)
        {
            Estudiante = estudiante;

            return "Se a registrado un nuevo estudiantes";
        }
        public string DiplomaEstudiante(IEstudiante estudiante)
        {
            Estudiante = estudiante;

            return "Estudiantes con un buen promedio se le otorga Diploma";
        }
        public string EstudianteBajoPromedio(IEstudiante estudiante)
        {
            Estudiante = estudiante;

            return "Estudiantes queda hacer horas comunitarias por mal promedio";

        }

        public void RegistrarEstudiante(EstudianteDejado estudianteDejado)
        {
            throw new NotImplementedException();
        }
    }
}