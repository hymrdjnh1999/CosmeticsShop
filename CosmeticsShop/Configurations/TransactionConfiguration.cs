﻿using CosmeticsShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions").HasKey(t => t.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(t => t.Client).WithMany(c => c.Transactions).HasForeignKey(t => t.ClientId);

        }
    }
}
