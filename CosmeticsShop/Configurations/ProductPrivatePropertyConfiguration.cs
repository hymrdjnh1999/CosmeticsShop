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
    public class ProductPrivatePropertyConfiguration : IEntityTypeConfiguration<ProductPrivateProperty>
    {
        public void Configure(EntityTypeBuilder<ProductPrivateProperty> builder)
        {
            builder.ToTable("ProductPrivateProperties").HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();
        }
    }
}
