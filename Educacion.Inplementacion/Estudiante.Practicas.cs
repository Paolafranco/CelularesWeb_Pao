using Educacion.Interface;
using Educacion.Negocio.Entidades;
using System.Collections.Generic;

namespace Educacion.Inplementacion
{
    public class EstudiantePracticas : IEstudiante
    {
        private string nombre;
        private List<string> notasEstudiantes;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> NotasEstudiantes { get { return notasEstudiantes; } set { notasEstudiantes = value; } }
        public string TrabajarEmpresa()
        {
            return "Estoy trabajando";
        }
        public string RecibirTrabajos()
        {
            return "Recibi un trabajo";
        }
        public string HacerTrabajos()
        {
            return "Estoy haciendo un trabajo";
        }
        public string Estudiar()
        {
            return "Estoy estudiando en el Instituto";
        }

        public string Matricular()
        {
            return "Me me estoy maticulando en la empresa";
        }

        public string RecibirClases()
        {
            return "Estoy recibiendo las practicas Online";
        }

        public string HacerDeberes()
        {
            return "Estoy haciendo los deberes en las practicas Online";
        }

        public string DarExamen()
        {
            return "Estoy dando los exames de las practicas";
        }
        public string Leer()
        {
            return "Estoy leyendo para prepararme para la siguiente clase";
        }

        public string IrClaces()
        {
            return "Estoy yendo a clases para no tender ninguna falta";
        }

        public string PonerAtencion()
        {
            return "Estoy poniendo atención a clases";
        }

        public string Participar()
        {
            return "Estoy participando para sacar buenas notas";
        }

        public string Dialogar()
        {
            return "Estoy dialogando cuando el Ingeniero pregunta";
        }
    }
}
