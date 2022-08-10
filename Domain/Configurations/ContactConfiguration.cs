using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations
{


    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(s => s.Id).HasMaxLength(300);
            builder.Property(s => s.PeopleID).HasMaxLength(300);
            builder.Property(s => s.Uuid).HasMaxLength(300);

            builder.Property(s => s.Email).HasMaxLength(300);
            builder.Property(s => s.Addrees).HasMaxLength(300);
            builder.Property(s => s.Location).HasMaxLength(600);
            builder.Property(s => s.Phone).HasMaxLength(600);

        }
    }
}


