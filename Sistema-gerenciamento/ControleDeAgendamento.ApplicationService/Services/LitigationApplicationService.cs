using ControleDeAgendamento.ApplicationService.Contracts.Requests;
using ControleDeAgendamento.ApplicationService.Contracts.Responses;
using ControleDeAgendamento.ApplicationService.Interfaces;
using ControleDeAgendamento.Domain.Contracts.Services;
using ControleDeAgendamento.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ControleDeAgendamento.ApplicationService.Services
{
    public class LitigationApplicationService : ILitigationApplicationService
    {
        private readonly ILitigationDomainService _litigationDomainService;

        private readonly ICompanyDomainService _companyDomainService;
        public LitigationApplicationService(ILitigationDomainService litigationDomainService, ICompanyDomainService companyDomainService)
        {
            _litigationDomainService = litigationDomainService;
            _companyDomainService = companyDomainService;
        }
        public AddLitigationResponse Add(AddLitigationRequest request)
        {            
            var model = new Litigation()
            {
                IdProcess = request.LitigationMessage.IdProcess,
                ValueProcess = Convert.ToDecimal(request.LitigationMessage.ValueProcess),
                State = request.LitigationMessage.State,
                CompanyId = request.LitigationMessage.CompanyId,
                Date = new DateTime(request.LitigationMessage.DateProcess.Year, request.LitigationMessage.DateProcess.Month, request.LitigationMessage.DateProcess.Day),
                IsActive = request.LitigationMessage.IsActive
            };

            _litigationDomainService.Create(model);

            return new AddLitigationResponse(true, model.Id);
        }
        public decimal GetAmountyCompany(int companyId, string state)
        {
            var amount = _litigationDomainService.GetAmountyCompany(companyId, state);

            return amount;
        }
        public decimal GetAmountByActiveProcess()
        {
            var amountValue = _litigationDomainService.GetAmountByActiveProcess();

            return amountValue;
        }
        public int GetAmountLitigationByValue() => _litigationDomainService.GetAmountLitigationByValue();        
        public List<string> GetLitigationByCompany(int companyId)
        {
            var company = _companyDomainService.ListById(companyId);

            var lst = _litigationDomainService.GetLitigationByCompany(company.Id, company.State);

            return lst;
        }
        public List<string> GetLitigationByProcess(string process)
        {
            var lst = _litigationDomainService.GetLitigationByProcess(process);

            return lst;
        }
        public List<string> GetLitigationsByMonth(int month)
        {
            var lst = _litigationDomainService.GetLitigationsByMonth(month);

            return lst;
        }
    }
}
