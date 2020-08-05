using Estudiante.Interface;
using Estudiante.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Estudiante.Implementacion
{
    class EstudianteDejado : Estudiante, IEstudiante, IEquatable<EstudianteSobresaliente>
    {

        public string Estudiar()
        {
            return "No me gusta estudiar mucho";
        }

        public string PresentarDeberes()
        {
            return $"No me gusta mucho estudiar haci que solo tenfgo el deber de {LibrosAcademicos[1]} ";
        }
        public string Participar()
        {
            return "No me gusta participar en clases";
        }

        public string PonerAtencion()
        {
            return "Me distraigo muy rapido haci que no presto Atencion en clases";
        }

        public bool Equals([AllowNull] EstudianteSobresaliente other)
        {
            return this.Id == other.Id;
        }
    }
    }
