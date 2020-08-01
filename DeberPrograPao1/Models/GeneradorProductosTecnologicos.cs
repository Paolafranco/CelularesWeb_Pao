using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeberPrograPao1.Models
{
    public class GeneradorProductosTecnologicos
    {
        readonly Random random = new Random();

        public int Id { get; set; }
        public GeneradorProductosTecnologicos()
        {
            Id = random.Next();
        }

        public GeneradorProductosTecnologicos(int identificar)
        {
            Id = identificar;
        }

        public GeneradorProductosTecnologicos(string identificarCadena)
        {
            Id = Convert.ToInt32(identificarCadena);
        }

      
    }
}

