using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebStore.Sales.Domain.Entities;

namespace WebStore.Sales.Infra.Data.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.SaleCode)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("SaleCode")
                .HasColumnType("varchar(100)");
        }
    }
}
