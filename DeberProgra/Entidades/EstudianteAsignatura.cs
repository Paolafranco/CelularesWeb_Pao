

namespace Educacion.Negocio.Entidades
{
    public class EstudianteAsignatura
    {
        public int EstudianteId { get; set; }
        public Estudiante Estudiante {  get; set; }
        public int AsignaturaId { get; set; }
        public Asignatura Asignatura { get; set; }
    }
}
