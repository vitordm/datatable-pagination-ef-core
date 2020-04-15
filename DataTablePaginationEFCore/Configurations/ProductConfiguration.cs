using DataTablePaginationEFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataTablePaginationEFCore.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Price).HasColumnType("decimal(11,4)").IsRequired();

            builder.HasData(new Product { Id = 1, Description = "Pizza 1", Price = 10 });
            builder.HasData(new Product { Id = 2, Description = "Blue-Ray", Price = 60 });
            builder.HasData(new Product { Id = 3, Description = "DVD", Price = 20 });
            builder.HasData(new Product { Id = 4, Description = "T-Shirt", Price = 20.5m });
            builder.HasData(new Product { Id = 5, Description = "Computer", Price = 350.99m });
            builder.HasData(new Product { Id = 6, Description = "Laptop", Price = 200m });
            builder.HasData(new Product { Id = 7, Description = "Car", Price = 5000m });
            builder.HasData(new Product { Id = 8, Description = "Mug", Price = 5.5m });
            builder.HasData(new Product { Id = 9, Description = "Cup", Price = 2.5m });
            builder.HasData(new Product { Id = 10, Description = "Fork", Price = 1.99m });
            builder.HasData(new Product { Id = 11, Description = "Knife", Price = 6.5m });
            builder.HasData(new Product { Id = 12, Description = "Gift Card", Price = 0.88m });
            builder.HasData(new Product { Id = 13, Description = "Chair", Price = 100.87m });

        }
    }
}
