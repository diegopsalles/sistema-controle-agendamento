using ControleDeAgendamento.Domain.Entities;
using System.Collections.Generic;

namespace ControleDeAgendamento.Domain.Contracts.Services
{
    public interface ILitigationDomainService : IBaseDomainService<Litigation, int>
    {
        decimal GetAmountByActiveProcess();
        decimal GetAmountyCompany(int companyId, string state);        
        int GetAmountLitigationByValue();
        List<string> GetLitigationsByMonth(int month);
        List<string> GetLitigationByCompany(int companyId, string companyState);
        List<string> GetLitigationByProcess(string process);
    }
}
