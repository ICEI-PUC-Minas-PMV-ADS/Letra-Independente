using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options):base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<src.Models.Perfil> Perfil { get; set; }

        public DbSet<src.Models.Texto> Texto { get; set; }

        public DbSet<src.Models.Avaliacao> Avaliacao { get; set; }

    }
}
