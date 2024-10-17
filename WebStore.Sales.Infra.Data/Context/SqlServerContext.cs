using Microsoft.EntityFrameworkCore;
using WebStore.Sales.Domain.Entities;
using WebStore.Sales.Infra.Data.Mapping;

namespace WebStore.Sales.Infra.Data.Context
{

    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {

        }

        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sale>(new SaleMap().Configure);
        }
    }
}
