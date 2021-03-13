using CosmeticsShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Configurations
{
    public class ProductInProductPrivatePropertyConfifguration : IEntityTypeConfiguration<ProductInProductPrivateProperty>
    {
        public void Configure(EntityTypeBuilder<ProductInProductPrivateProperty> builder)
        {
            builder.ToTable("ProductInProductPrivateProperties").HasKey(x => new { x.ProductId, x.ProductPrivatePropertyId });

            builder.HasOne(x => x.Product).WithMany(p => p.ProductInProductPrivateProperties).HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.ProductPrivateProperty).WithMany(p => p.productInProductPrivateProperties).HasForeignKey(x => x.ProductPrivatePropertyId);

        }
    }
}
