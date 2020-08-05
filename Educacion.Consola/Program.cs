using Educacion.Negocio;
using Educacion.Negocio.Entidades;
using System;

namespace Educacion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Asignatura asignatura3 = new Asignatura
            {
                Nombre = "Diseño de Interfaz"
            };

            Secretaria secretaria3 = new Secretaria();
            secretaria3.Matricular(estudiante, asignatura);

            Asignatura asignatura4 = new Asignatura
            {
                Nombre = "Matemáticas"
            };

            Secretaria secretaria4 = new Secretaria();
            secretaria4.Matricular(estudiante, asignatura);

            Console.WriteLine($"Hay {Secretaria.Matriculados} estudiantes matriculados");
        }
    }
}
