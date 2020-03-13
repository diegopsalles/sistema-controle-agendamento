using System.Collections.Generic;

namespace ControleDeAgendamento.ApplicationService.Contracts.Messages
{
    public class AddCompanyMessage
    {
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string State { get; set; }        
    }
}
