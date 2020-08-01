using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeberPrograPao1.Models
{
    public class Fabrica
    {
        public Computadora CrearComputador(string marca = "Asus", string modelo = "NoteBokk 8a")
        {
            Computadora computador = new Computadora(marca, modelo);
            return computador;
        }
        public Celular CrearCelular(string marca = "Xiaomi", string modelo = "Readme 8a")
        {
            Celular celular = new Celular(marca, modelo);
            return celular;
        }

    }
}
