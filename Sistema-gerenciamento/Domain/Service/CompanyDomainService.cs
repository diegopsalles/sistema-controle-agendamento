using Domain.Contracts.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service
{
    public class CompanyDomainService : BaseDomainService <Company, int>, ICompanyDomainService
    {
        public void Create(Company obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Company obj)
        {
            throw new NotImplementedException();
        }

        public List<Company> ListAll()
        {
            throw new NotImplementedException();
        }

        public Company ListById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Company obj)
        {
            throw new NotImplementedException();
        }
    }
}
