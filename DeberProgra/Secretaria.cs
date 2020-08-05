using Educacion.Negocio.Entidades;

namespace Educacion.Negocio
{
    public class Secretaria
    {
        public static int Matriculados { get; set; }
        public void Matricular(Estudiante estudiante, Asignatura asignatura)
        {
            estudiante.EstudianteAsignaturas.Add( new EstudianteAsignatura 
            {
                Asignatura=asignatura,
                Estudiante=estudiante
            });
            Matriculados++;
        }
    }
}
