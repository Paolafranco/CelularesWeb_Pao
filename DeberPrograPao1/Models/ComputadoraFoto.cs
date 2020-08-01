using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeberPrograPao1.Models
{
    public class ComputadoraFoto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public byte[] Fotografia { get; set; }
    }
}
