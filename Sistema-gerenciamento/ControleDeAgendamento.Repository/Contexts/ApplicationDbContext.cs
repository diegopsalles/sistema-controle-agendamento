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
            string strConnection = @"Server = MYSQL5025.site4now.net; Database = db_a5644e_desafio; Uid = a5644e_desafio; Pwd = 290665Diego*";
            optionsBuilder.UseMySql(strConnection, x => x.MigrationsAssembly(migrationsAssembly));
    }
    public DbSet<Company> Company { get; set; }
    public DbSet<Litigation> Litigations { get; set; }
    
    }
}
