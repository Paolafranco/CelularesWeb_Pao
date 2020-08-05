using System.Collections.Generic;
using Educacion.Negocio.Entidades;
using Educacion.Interface;

namespace Educacion.Inplementacion
{
    public class EstudianteAntiguo : IEstudiante
    {
        private string nombre;
        private List<string> notasEstudiantes;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public object Apellido { get; set; }
        public List<string> NotasEstudiantes { get { return notasEstudiantes; } set { notasEstudiantes = value; } }


        public string Matricular()
        {
            return $"{Nombre} {Apellido} ,está Matriculada en Quinto Sementre";
        }
        public string DarExamen()
        {
            return "Estoy en el exámen";
        }

        public string Estudiar()
        {
            return "Estoy estudiando";
        }

        public string HacerDeberes()
        {
            return "Estoy haciendo deberes";
        }


        public string RecibirClases()
        {
            return "Estoy recibiendo clases";
        }

        public string TrabajarEmpresa()
        {
            return "Estoy trabajando en la empresa";
        }

        public string RecibirTrabajos()
        {
            return "Estoy realizando mis trabajos de la empresa";
        }

        public string HacerTrabajos()
        {
            return "Estoy recibiendo trabajos para realizarlos en las prácticas";
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
