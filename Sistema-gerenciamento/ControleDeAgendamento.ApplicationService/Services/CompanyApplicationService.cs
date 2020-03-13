using ControleDeAgendamento.ApplicationService.Contracts.Requests;
using ControleDeAgendamento.ApplicationService.Contracts.Responses;
using ControleDeAgendamento.ApplicationService.Interfaces;
using ControleDeAgendamento.Domain.Contracts.Services;
using System;

namespace ControleDeAgendamento.ApplicationService.Services
{
    public class CompanyApplicationService : ICompanyApplicationService
    {
        private readonly ICompanyDomainService _companyDomainService;

        public CompanyApplicationService(ICompanyDomainService companyDomainService)
        => _companyDomainService = companyDomainService;        

        public AddCompanyResponse Add(AddCompanyRequest request)
        {   
            var model = new Domain.Entities.Company { Cnpj = request.CompanyMessage.Cnpj, Name = request.CompanyMessage.Name, State = request.CompanyMessage.State };
            
            _companyDomainService.Create(model);

            return new AddCompanyResponse(true, model.Id);
        }

        public CompanyResponse Get(int Id)
        {
            throw new NotImplementedException();
        }

        public CompanyResponse List()
        {
            throw new NotImplementedException();
        }

        public CompanyResponse Update(AddCompanyRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
