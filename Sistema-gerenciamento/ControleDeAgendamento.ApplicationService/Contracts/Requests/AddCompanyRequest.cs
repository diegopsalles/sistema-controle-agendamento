using ControleDeAgendamento.ApplicationService.Contracts.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAgendamento.ApplicationService.Contracts.Requests
{
    public class AddCompanyRequest
    {
        public AddCompanyMessage CompanyMessage { get; set; }
    }
}
