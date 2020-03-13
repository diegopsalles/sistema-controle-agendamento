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
            string strConnection = @"Server=CEPHEUS.cd.com;Port=3306;Database=wz_identityserver;Uid=user_wz_identityserver;Pwd=123987!@#;persistsecurityinfo=True;SslMode=none;";

            services.AddDbContext<ApplicationDbContext>(o => o.UseMySql(strConnection));
        }

    }
}
