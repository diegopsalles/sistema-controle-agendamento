using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configurations
{
    public class LitigationConfiguration
    {
        public static Action<EntityTypeBuilder<Litigation>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Litigation");
                e.HasKey(x => x.IdLitigation);
                e.Property(x => x.IdLitigation).HasColumnName("Id").IsRequired().ValueGeneratedOnAdd();
                e.Property(x => x.IdProcess).IsRequired();
                e.Property(x => x.ValueProcess).IsRequired();
                e.Property(x => x.State).IsRequired();
                e.Property(x => x.Date).IsRequired();
                e.Property(x => x.IsActive);

                e.HasOne(x => x.Company);
            });
        }
    }
}
