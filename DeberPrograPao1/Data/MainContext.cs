using Microsoft.EntityFrameworkCore;
using DeberPrograPao1.Models;
using System.Security.Cryptography.X509Certificates;

namespace DeberPrograPao1.Data
{
    public class MainContext : DbContext
    {
        public MainContext (DbContextOptions<MainContext> options)
            : base(options)
        {
         
        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Computadora> Computadoras { get; set; }

        public DbSet<Celular> Celulares { get; set; }

        public DbSet<Impresora> Impresoras { get; set; }

        public DbSet<Mouse> Mouses { get; set; }

        public DbSet<Tablet> Tablets { get; set; }
    }
}
