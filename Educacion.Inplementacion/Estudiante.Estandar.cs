using Educacion.Interface;
using Educacion.Negocio.Entidades;
using System.Collections.Generic;


namespace Educacion.Inplementacion
{
    public class EstudianteEstandar : IEstudiante
    {
        private string nombre;
        private List<string> notasEstudiantes;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> NotasEstudiantes { get { return notasEstudiantes; } set { notasEstudiantes = value; } }
        public string Matricular()
        {
            return "Me voy a ir a matricular al Instituto";
        }
        public string RecibirClases()
        {
            return "Estoy recibiendo clases en el Instituto";
        }
        public string HacerDeberes()
        {
            return "Estoy haciendo deberes a mano";
        }
        public string Estudiar()
        {
            return "Estoy estudiando en el Instituto";
        }
        public string DarExamen()
        {
            return "Voy a dar el exámen al Insituto";
        }

        public string TrabajarEmpresa()
        {
            return "Estoy trabajando en las oficinas empresa";
        }

        public string RecibirTrabajos()
        {
            return "Estoy trabajando recibiendo trabajos en la oficina de mi jefe";
        }

        public string HacerTrabajos()
        {
            return "Estoy realizando los trabajos en la oficina con  mis compañeros";
        }
        public string Leer()
        {
            return "Estoy leyendo para prepararme en las pruebas";
        }

        public string IrClaces()
        {
            return "Estoy yendo a clases para no perder ninguna clase";
        }

        public string PonerAtencion()
        {
            return "Estoy poniendo atención a lo que dice el Ingeniero";
        }

        public string Participar()
        {
            return "Estoy participando para sacar buenas notas en actuacion";
        }

        public string Dialogar()
        {
            return "Estoy dialogando con mis compañeros cuando no entiendo algo";
        }
    }

}
