using Educacion.Interface;

namespace Educacion.Negocio
{
    public class DocenteInspector
    { 
      public IEstudiante Estudiante { get; set; }
        public string MatricularEstudiantes(IEstudiante estudiante)
        {
            Estudiante = estudiante;
            return "Contrate un Estuidante";
        }
        public string RealizarProyecto()
        {
            return Estudiante.RecibirClases() + "Proyecto" +
            Estudiante.HacerDeberes() + "Proyecto" +
            Estudiante.Estudiar() + "Proyecto" +
            Estudiante.DarExamen() + "Proyecto" +
            Estudiante.Leer() + "Proyecto" +
            Estudiante.IrClaces() + "Proyecto" +
            Estudiante.PonerAtencion() + "Proyecto" +
            Estudiante.Participar() + "Proyecto" +
            Estudiante.Dialogar() + "Proyecto";
        }

        public string MatricularEstudiantes()
        {
           return "Matricule un estudiante";
        }
    }
}
