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
    public class ProductInCosmeticsCollectionConfiguration : IEntityTypeConfiguration<ProductInCosmeticsCollection>
    {
        public void Configure(EntityTypeBuilder<ProductInCosmeticsCollection> builder)
        {
            builder.ToTable("ProductInCosmeticsCollections").HasKey(x => new { x.ProductId, x.CosmeticsCollectionId });

            builder.HasOne(x => x.CosmeticsCollection).WithMany(cc => cc.ProductInCosmeticsCollections).HasForeignKey(x => x.CosmeticsCollectionId);

            builder.HasOne(x => x.Product).WithMany(p => p.ProductInCosmeticsCollections).HasForeignKey(x => x.ProductId);
        }
    }
}
