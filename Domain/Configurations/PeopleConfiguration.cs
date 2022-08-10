using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations
{
    public class PeopleConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {

            builder.Property(s => s.PeopleID).HasMaxLength(300);
         
            builder.Property(s => s.Name).HasMaxLength(300);
            builder.Property(s => s.LastName).HasMaxLength(300);
            builder.Property(s => s.Company).HasMaxLength(600);
            builder.Property(s => s.ReportTime).HasMaxLength(600);
           
        }
    }
}
