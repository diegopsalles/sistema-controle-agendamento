using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeAgendamento.ApplicationService.Contracts.Requests;
using ControleDeAgendamento.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleDeAgendamento.API.Controllers
{
    [Route("api/company")]
    public class CompanyController : Controller
    {
        private readonly ICompanyApplicationService _companyApplicationService;

        public CompanyController(ICompanyApplicationService companyApplicationService) => _companyApplicationService = companyApplicationService;
        
       
        [HttpPost]
        public IActionResult Post([FromBody]AddCompanyRequest request)
        {
            var response = _companyApplicationService.Add(request);

            return Ok(response);
        }

    }
}
