using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) 
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Contato> Contatos { get; set; }

        public DbSet<EnderecoEntrega> EnderecoEntrega { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }


        #region Conexão sem distribuição de ambiente de execução
        /*
         * Conexão sem distribuição de ambiente de execução
         */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True");
        }
        #endregion


    }
}
