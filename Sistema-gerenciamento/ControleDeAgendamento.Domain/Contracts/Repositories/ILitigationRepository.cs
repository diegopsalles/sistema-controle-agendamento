using ControleDeAgendamento.Domain.Entities;
using System.Collections.Generic;

namespace ControleDeAgendamento.Domain.Contracts.Repositories
{
    public interface ILitigationRepository : IBaseRepository<Litigation, int>
    {
        decimal GetAmountByActiveProcess();
        decimal GetAmountyByCompany(int companyId, string state);
        int GetAmountLitigationByValue();
        List<string> GetLitigationsByMonth(int month);
        List<string> GetLitigationByCompany(int companyId, string companyState);
        List<string> GetLitigationByProcess(string process);
    }
}
