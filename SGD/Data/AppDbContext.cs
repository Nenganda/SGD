using Microsoft.EntityFrameworkCore;
using SGD.Data.EntityConfig;
using SGD.Data.Model;

namespace SGD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationPaisMap());
            modelBuilder.ApplyConfiguration(new ApplicationCategoriaMap());
            modelBuilder.ApplyConfiguration(new ApplicationSubCategoriaMap());
            modelBuilder.ApplyConfiguration(new ApplicationProdutoMap());
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SGD;Trusted_Connection=True;MultipleActiveResultSets=true";
            return strCon;
        }
    }
}
