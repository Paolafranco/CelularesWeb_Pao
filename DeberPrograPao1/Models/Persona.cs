using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeberPrograPao1.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public List<Computadora> Computadoras { get; set; } = new List<Computadora>();
        public List<Celular> Celulares { get; set; } = new List<Celular>();
        public List<Impresora> Impresoras { get; set; } = new List<Impresora>();
        public List<Mouse> Mouses { get; set; } = new List<Mouse>();
        public List<Tablet> Tablets { get; set; } = new List<Tablet>();
        public List<Curso> Cursos { get; set; } = new List<Curso>();
        public byte[] Foto { get; set; }
        [NotMapped]
        [Display(Name = "Fotografía")]
        public string FotoBase64 { get; set; }

        //Instancias

        private Celular celular;
        public Celular Celular
        {
            get { return celular; }
            set
            {
                celular = value;
            }
        }


        private Computadora computadora;
        public Computadora Computadora
        {
            get { return computadora; }
            set
            {
                computadora = value;
            }
        }

       
        private Mouse mouse;
        public Mouse Mouse
        {
            get { return mouse; }
            set
            {
                mouse = value;
            }
        }
       
      
        private Tablet tablet;
        public Tablet Tablet
        {
            get { return tablet; }
            set
            {
                tablet = value;
            }
        }
        
        private Impresora impresora;
        public Impresora Impresora
        {
            get { return impresora; }
            set
            {
                impresora = value;
            }
        }
       




        public string Saludar(string nombre)
        {
            return $"Hola {nombre} soy {Nombre}";
        }

        public Persona()
        {
        }

        public string Saludar()
        {
            return $"Hola, me llamo {Nombre}soy tu ascesora.";
        }

        public string IndicarCelL()
        {
            return $"Un {Celular.Modelo} y su id es";
        }
        public string IndicarCompu()
        {
            return $"Una {Computadora.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarTablet()
        {
            return $"Una {Tablet.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarImpresora()
        {
            return $"Una {Impresora.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarMouse()
        {
            return $"Una {Mouse.Modelo} y su id es {Computadora.Id}";
        }

    }
}


