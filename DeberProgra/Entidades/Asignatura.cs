using System.Collections.Generic;

namespace Educacion.Negocio.Entidades
{
    public class Asignatura
    {
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }
        public List<EstudianteAsignatura> EstudianteAsignaturas { get; set; } = new List<EstudianteAsignatura>();

    }
}
