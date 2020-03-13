using ControleDeAgendamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ControleDeAgendamento.Repository.Contexts
{
    public class ApplicationDbContext : DbContext
    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var migrationsAssembly = typeof(ApplicationDbContext).GetTypeInfo().Assembly.GetName().Name;
        string strConnection = @"Server=CEPHEUS.cd.com;Port=3306;Database=wz_identityserver;Uid=user_wz_identityserver;Pwd=123987!@#;persistsecurityinfo=True;SslMode=none;";
            optionsBuilder.UseMySql(strConnection, x => x.MigrationsAssembly(migrationsAssembly));
    }
    public DbSet<Company> Company { get; set; }
    public DbSet<Litigation> Litigations { get; set; }
    
    }
}
