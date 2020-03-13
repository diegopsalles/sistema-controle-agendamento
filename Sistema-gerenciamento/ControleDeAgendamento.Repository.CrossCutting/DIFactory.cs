using ControleDeAgendamento.ApplicationService.Interfaces;
using ControleDeAgendamento.ApplicationService.Services;
using ControleDeAgendamento.Domain.Contracts.Repositories;
using ControleDeAgendamento.Domain.Contracts.Services;
using ControleDeAgendamento.Domain.Service;
using ControleDeAgendamento.Repository.Contexts;
using ControleDeAgendamento.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ControleDeAgendamento.Repository.CrossCutting
{
    public static class DIFactorys
    {
        public static void InvokeDIFactory(this IServiceCollection services) 
        {

            services.InvokeDIApplication();
            services.InvokeDIDomainService();
            services.InvokeDIRepository();

        }
        private static void InvokeDIRepository(this IServiceCollection services)
        {
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ILitigationRepository, LitigationRepository>();
        }
        private static void InvokeDIApplication(this IServiceCollection services)
        {
            
            services.AddScoped<ICompanyApplicationService, CompanyApplicationService>();
            services.AddScoped<ILitigationApplicationService, LitigationApplicationService>();
        }
        private static void InvokeDIDomainService(this IServiceCollection services) 
        {
            services.AddScoped<ICompanyDomainService, CompanyDomainService>();
            services.AddScoped<ILitigationDomainService, LitigationDomainService>();
        }
        
        public static void ConfigEntityFramework(this IServiceCollection services) 
        {
            string strConnection = @"Server=ecommerce-allied-db1.cqpou5y4xe1k.us-east-1.rds.amazonaws.com;Port=3306;Database=db_p_oi;Uid=usr_oi;Pwd=BNV73g5U;persistsecurityinfo=True;SslMode=none;";

            services.AddDbContext<ApplicationDbContext>(o => o.UseMySql(strConnection));
        }

    }
}
