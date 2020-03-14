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
            string strConnection = @"Server = MYSQL5025.site4now.net; Database = db_a5644e_desafio; Uid = a5644e_desafio; Pwd = 290665Diego*";

            services.AddDbContext<ApplicationDbContext>(o => o.UseMySql(strConnection));
        }

    }
}
