using ControleDeAgendamento.ApplicationService.Contracts.Responses;
using ControleDeAgendamento.ApplicationService.Contracts.Requests;
using System.Collections.Generic;

namespace ControleDeAgendamento.ApplicationService.Interfaces
{
    public interface ILitigationApplicationService
    {
        AddLitigationResponse Add(AddLitigationRequest request);        
        decimal GetAmountByActiveProcess();
        decimal GetAmountyCompany(int companyId, string state);        
        int GetAmountLitigationByValue();
        List<string> GetLitigationsByMonth(int month);
        List<string> GetLitigationByCompany(int companyId);
        List<string> GetLitigationByProcess(string process);
    }
}
