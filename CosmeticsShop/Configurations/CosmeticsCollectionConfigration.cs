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
    public class CosmeticsCollectionConfigration : IEntityTypeConfiguration<CosmeticsCollection>
    {
        public void Configure(EntityTypeBuilder<CosmeticsCollection> builder)
        {
            builder.ToTable("CosmeticsCollections").HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();
        }
    }
}
