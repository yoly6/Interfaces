using Estudiante.Implementacion;
using Estudiante.Intituto;
using Estudiante.Entidad;


namespace Estudiante.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Instituto MiInstituto = new Instituto();

            MiInstituto.RegistrarEstudiante(new EstudianteSobresaliente());

            MiInstituto.DiplomaEstudiante(new EstudianteSobresaliente());

            var estudianteSobresaliente = new EstudianteSobresaliente();
            estudianteSobresaliente.Id = 1;
            estudianteSobresaliente.Nombre = "Juan";
            estudianteSobresaliente.Apellido = "Gonzales";

            Console.WriteLine(estudianteSobresaliente.PresentarDeberes());

            MiInstituto.RegistrarEstudiante(new EstudianteDejado());
            MiInstituto.EstudianteBajoPromedio();
            var estudianteDejado = new EstudianteDejado();
            estudianteDejado.Id = 1;
            estudianteDejado.Nombre = "Maria";
            estudianteDejado.Apellido = "Lopez";
            Console.WriteLine(estudianteDejado.PresentarDeberes());

        }
    }
}