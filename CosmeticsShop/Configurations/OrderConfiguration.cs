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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders").HasKey(o => o.Id);

            builder.Property(o => o.ShipAddress).IsRequired();

            builder.Property(o => o.ShipName).IsRequired();

            builder.Property(o => o.ShipPhoneNumber).IsRequired();

            builder.HasOne(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserId);

        }
    }
}
