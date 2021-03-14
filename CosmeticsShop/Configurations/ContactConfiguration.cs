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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts").HasKey(c => c.Id);

            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.Name).IsRequired();

            builder.Property(c => c.PhoneNumber).IsRequired();

        }
    }
}
