using ControleDeAgendamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ControleDeAgendamento.Repository.Configurations
{
    public class CompanyConfirguration
    {
        public static Action<EntityTypeBuilder<Company>> ConfigureMap()
        {   
            return (e =>
            {
                e.ToTable("Company");
                e.HasKey(x => x.Id);
                e.Property(x => x.Id).HasColumnName("Id").IsRequired().ValueGeneratedOnAdd();
                e.Property(x => x.Name).IsRequired();
                e.Property(x => x.Cnpj).IsRequired();
                e.Property(x => x.State).IsRequired();

                e.HasMany(x => x.Litigation);
            });
        }
    }
}
