using ControleDeAgendamento.ApplicationService.Contracts.Requests;
using ControleDeAgendamento.ApplicationService.Contracts.Responses;

namespace ControleDeAgendamento.ApplicationService.Interfaces
{
    public interface ICompanyApplicationService
    {
        AddCompanyResponse Add(AddCompanyRequest request);
        CompanyResponse Update(AddCompanyRequest request);
        CompanyResponse List();
        CompanyResponse Get(int Id);        
    }
}
