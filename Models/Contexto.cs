using BancoProjetoFinal1.Models;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Models
{

    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Observacoes> Observacoes { get; set; }

    }
}
