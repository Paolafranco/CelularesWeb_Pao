using Educacion.Negocio;
using Educacion.AccesoDatos;
using Educacion.Inplementacion;
using Educacion.Negocio.Entidades;
using System;

namespace Educacion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Secretaria secretaria3 = new Secretaria
            {
                Nombre = "Paola",
                Apellido= "Franco"

            };

            var docente = new Secretaria
            {
                Nombre = "Cecilia",
                Apellido = "Franco"
            };

            Console.WriteLine("Bienvenidos al Instituto");
            Estudiante estudiante = new Estudiante
            {
                Nombre="Paola",
                Apellido="Franco",
                Nacimiento= new DateTime(1997,10,13)
            };
            Asignatura asignatura = new Asignatura
            {
                Nombre="Programacion"
            };

            Secretaria secretaria = new Secretaria();
            secretaria.Matricular(estudiante,asignatura);

            Asignatura asignatura1 = new Asignatura
            {
                Nombre = "Base de Datos"
            };

            Secretaria secretaria1 = new Secretaria();
            secretaria1.Matricular(estudiante, asignatura);

            Asignatura asignatura2 = new Asignatura
            {
                Nombre = "Ingles"
            };

            Secretaria secretaria2 = new Secretaria();
            secretaria2.Matricular(estudiante, asignatura);

            Console.WriteLine(secretaria3.Saludar(docente));
            Console.WriteLine();
            Console.WriteLine("Quisiera por favor saber cuantos alumnos se Matricularon el día de hoy de 9:00 am a 12:00 pm");
            Console.WriteLine();
            Console.WriteLine($"Hay {Secretaria.Matriculados} estudiantes matriculados a esas horas");
            Console.WriteLine();
            Console.WriteLine("Muchas gracias, deme por favor sus nombres y el semestre en el que se encuentran");
            Console.WriteLine();

            //
            EstudianteAntiguo estudianteAntiguo = new EstudianteAntiguo()
            {
                Nombre = "Victor",
                Apellido = "Lara"
            };

            string estudiante0 = estudianteAntiguo.Matricular();
            Console.WriteLine(estudianteAntiguo.Matricular());

            EstudianteAplicado estudianteAplicado = new EstudianteAplicado()
            {
                Nombre = "Andrea",
                Apellido = "Franco"
            };

            string estudiant1 = estudianteAplicado.Matricular();
            Console.WriteLine(estudianteAplicado.Matricular());

            EstudianteMallaNueva estudianteMallaNueva = new EstudianteMallaNueva()
            {
                Nombre = "Mateo",
                Apellido = "Campos"
            };

            string estudiant2 = estudianteMallaNueva.Matricular();
            Console.WriteLine(estudianteMallaNueva.Matricular());
        }
    }
}
