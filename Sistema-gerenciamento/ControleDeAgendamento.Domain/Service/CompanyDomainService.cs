using ControleDeAgendamento.Domain.Contracts.Repositories;
using ControleDeAgendamento.Domain.Contracts.Services;
using ControleDeAgendamento.Domain.Entities;
using System.Collections.Generic;

namespace ControleDeAgendamento.Domain.Service
{
    public class CompanyDomainService : BaseDomainService<Company, int>, ICompanyDomainService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyDomainService(ICompanyRepository companyRepository) : base(companyRepository) => _companyRepository = companyRepository;

        public void Create(Company company) => _companyRepository.Insert(company);
        public void Delete(Company obj) => _companyRepository.Delete(obj);
        public List<Company> ListAll() => _companyRepository.GetAll();
        public Company ListById(int id) => _companyRepository.GetById(id);
        public void Update(Company obj) => _companyRepository.Update(obj);        
    }
}
