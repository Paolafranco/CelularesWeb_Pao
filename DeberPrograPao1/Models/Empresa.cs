using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeberPrograPao1.Models
{
    public class Empresa : GeneradorProductosTecnologicos
    { 
        public string Nombre { get; set; }

    public Empresa() : base()
    { }

    public Empresa(int id) : base(id)
    { }

    public Empresa(string id) : base(id)
    { }

    public Celular ConstruirCelular(string modelo)
    {
        // TODO : Materias primas?
        // TODO : Desperdicios?

        return new Celular()
        {
            Marca = Nombre,
            Modelo = modelo
        };
    }

        public string Prender()
        {
            return "está prendido";
        }

        public string Apagar()
        {
            return "está apagado";
        }
    }
}