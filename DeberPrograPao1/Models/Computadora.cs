using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeberPrograPao1.Models
{
    public class Computadora
    {
        public Computadora()
        {
        }
        public Computadora(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public ComputadoraFoto Foto { get; set; }
        

        [System.ComponentModel.DataAnnotations.Display(Description = "Esta es la marca")]
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Id { get; set; }
    }
}
