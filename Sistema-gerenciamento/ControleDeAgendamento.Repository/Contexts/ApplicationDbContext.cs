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
            string strConnection = @"Server=ecommerce-allied-db1.cqpou5y4xe1k.us-east-1.rds.amazonaws.com;Port=3306;Database=db_p_oi;Uid=usr_oi;Pwd=BNV73g5U;persistsecurityinfo=True;SslMode=none;";
            optionsBuilder.UseMySql(strConnection, x => x.MigrationsAssembly(migrationsAssembly));
    }
    public DbSet<Company> Company { get; set; }
    public DbSet<Litigation> Litigations { get; set; }
    
    }
}
