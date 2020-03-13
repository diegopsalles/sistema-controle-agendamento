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
    [Route("api/litigation")]
    public class LitigationsController : Controller
    {
        private readonly ILitigationApplicationService _litigationApplicationService;
        public LitigationsController(ILitigationApplicationService litigationApplicationService)
        => _litigationApplicationService = litigationApplicationService;

        [HttpPost]
        public IActionResult Post([FromBody]AddLitigationRequest request)
        {
            var response = _litigationApplicationService.Add(request);

            return Ok(response);
        }

        [HttpGet,Route("/byCompany")]
        public decimal GetAmount([FromQuery]AmountByCompanyRequest request) 
            => _litigationApplicationService.GetAmountyCompany(request.CompanyId, request.State);
       
        [HttpGet,Route("/byActiveProcess")]
        public decimal GetAmountByActiveProcess()
            => _litigationApplicationService.GetAmountByActiveProcess();

        [HttpGet, Route("/byValue")]
        public int GetAmountLitigationByValue() 
            => _litigationApplicationService.GetAmountLitigationByValue();

        [HttpGet, Route("/byCompanyId")]
        public List<string> GetLitigationByCompany(int companyId) 
            => _litigationApplicationService.GetLitigationByCompany(companyId);

        [HttpGet, Route("/byLitigationsByProcess")]
        public List<string> GetLitigationByProcess(string process) 
            => _litigationApplicationService.GetLitigationByProcess(process);

        [HttpGet, Route("/byMonth")]
        public List<string> GetLitigationsByMonth(int month) 
            => _litigationApplicationService.GetLitigationsByMonth(month);
    }
}
