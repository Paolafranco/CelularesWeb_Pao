using System.Collections.Generic;

namespace DeberPrograPao1.Models
{
    public class Celular : Producto
    {
        public int Id { get; set; }
        //public  Persona Propietario { get; set; }
        

        public Celular() : base()
        {

        }

        public Celular(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public string Escribir()
        {
            return "";
        }

        public string LLamar()
        {
            return "";
        }


        public string Colgar()
        {
            return "";
        }

        public string Guardar()
        {
            return "";
        }

        public string Jugar()
        {
            return "";
        }

        public string Eliminar()
        {
            return "";
        }

        

    }
}
