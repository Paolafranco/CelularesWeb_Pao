using System;
using Educacion.Interface;
using Educacion.Negocio.Entidades;
using System.Diagnostics.CodeAnalysis;

namespace Educacion.Inplementacion
{
    public class EstudianteRelajado : IEstudiante, IEquatable<EstudianteRelajado>
    {
        private Estudiante estudiante = new Estudiante();
        public int Id { get { return estudiante.EstudianteId; } set { estudiante.EstudianteId = value; } }
        public string DarExamen()
        {
            return "Estoy dando el exámen y escucho musica relajante";
        }

        public string Estudiar()
        {
            return "Estoy dando el estudiando con música para concentrarme";
        }

        public string HacerDeberes()
        {
            return "Estoy haciendo deberes con musica de Manuel Medrano";
        }

        public string HacerTrabajos()
        {
            return "Estoy haciendo mis trabajos escuchando todo tipo musica";
        }

        public string Matricular()
        {
            return "Me voy a matricular y pongo musica en mi Pc de Marron5";
        }

        public string RecibirClases()
        {
            return "Estoy recibiendo clases con musica para la consetración";
        }

        public string RecibirTrabajos()
        {
            return "Estoy realizando trabajos sin musica romantica";
        }

        public string TrabajarEmpresa()
        {
            return "Estoy realizando los trabajos con musica POP";
        }
        public string Leer()
        {
            return "Estoy leyendo con musica de concentracion para entender mejor la lectura";
        }

        public string IrClaces()
        {
            return "Estoy yendo a clases con musica para relajarme un poco";
        }

        public string PonerAtencion()
        {
            return "Estoy poniendo atención a clases sin musica";
        }

        public string Participar()
        {
            return "Estoy participando sin musica";
        }

        public string Dialogar()
        {
            return "Estoy dialogando sin musica";
        }

        public bool Equals([AllowNull] EstudianteRelajado other)
        {
            return this.Id == other.Id;
        }
    }
}
