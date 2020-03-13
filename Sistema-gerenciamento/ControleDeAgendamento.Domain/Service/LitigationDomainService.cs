using ControleDeAgendamento.Domain.Contracts.Repositories;
using ControleDeAgendamento.Domain.Contracts.Services;
using ControleDeAgendamento.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ControleDeAgendamento.Domain.Service
{
    public class LitigationDomainService: BaseDomainService<Litigation, int>, ILitigationDomainService
    {
        private readonly ILitigationRepository _litigationRepository;
        public LitigationDomainService(ILitigationRepository litigationRepository) : base(litigationRepository) => _litigationRepository = litigationRepository;
        public void Create(Litigation company) => _litigationRepository.Insert(company);
        public void Delete(Litigation obj) => _litigationRepository.Delete(obj);
        public decimal GetAmountByActiveProcess() => _litigationRepository.GetAmountByActiveProcess();
        public int GetAmountLitigationByValue() => _litigationRepository.GetAmountLitigationByValue();
        public decimal GetAmountyCompany(int companyId, string state) => _litigationRepository.GetAmountyByCompany(companyId, state);
        public List<string> GetLitigationByCompany(int companyId, string companyState) => _litigationRepository.GetLitigationByCompany(companyId, companyState);        
        public List<string> GetLitigationByProcess(string process) => _litigationRepository.GetLitigationByProcess(process);
        public List<string> GetLitigationsByMonth(int month) => _litigationRepository.GetLitigationsByMonth(month);        
        public List<Litigation> ListAll() => _litigationRepository.GetAll();
        public Litigation ListById(int id) => _litigationRepository.GetById(id);
        public void Update(Litigation obj) => _litigationRepository.Update(obj);
    }
}
