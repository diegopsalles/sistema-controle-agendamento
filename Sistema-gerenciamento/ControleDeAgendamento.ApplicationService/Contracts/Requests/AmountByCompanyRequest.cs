using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAgendamento.ApplicationService.Contracts.Requests
{
    public class AmountByCompanyRequest
    {
        public int CompanyId { get; set; }

        public string State { get; set; }
    }
}
