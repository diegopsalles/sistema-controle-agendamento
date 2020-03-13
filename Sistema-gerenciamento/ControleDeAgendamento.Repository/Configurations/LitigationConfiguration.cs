using ControleDeAgendamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ControleDeAgendamento.Repository.Configurations
{
    public class LitigationConfiguration
    {
        public static Action<EntityTypeBuilder<Litigation>> ConfigureMap()
        {
            return (e =>
            {
                e.ToTable("Litigation");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id").IsRequired().ValueGeneratedOnAdd();
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
