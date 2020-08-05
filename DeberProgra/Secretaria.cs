using Educacion.Negocio.Entidades;
using System;

namespace Educacion.Negocio
{
    public class Secretaria
    {
        public static int Matriculados { get; set; }
        public object Nombre { get; set; }
        public object Apellido { get; set; }

        public void Matricular(Estudiante estudiante, Asignatura asignatura)
        {
            estudiante.EstudianteAsignaturas.Add( new EstudianteAsignatura 
            {
                Asignatura=asignatura,
                Estudiante=estudiante
            });
            Matriculados++;
        }
       
        public string Saludar(Secretaria docente)
        {
            return $"Hola, me llamo {Nombre} {Apellido} la secretaria, En que te puedo ayudar?";
        }

    }
}
