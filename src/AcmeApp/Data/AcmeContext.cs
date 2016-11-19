using AcmeApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace AcmeApp.Data
{

    public class AcmeContext : DbContext
    {

        public AcmeContext(DbContextOptions<AcmeContext> options)
                : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<MateriaPrima> MateriasPrimas { get; set; }

    }

}
