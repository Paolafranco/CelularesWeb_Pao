using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DeberPrograPao1.Models
{
    public class EdicionRol
    {
        public IdentityRole Rol { get; set; }
        public IEnumerable<IdentityUser> Miembros { get; set; }
        public IEnumerable<IdentityUser> NoMiembros { get; set; }
    }
}