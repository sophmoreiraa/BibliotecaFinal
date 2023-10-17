using Microsoft.EntityFrameworkCore;

namespace BibliotecaFinal.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Livros> Livros { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}

