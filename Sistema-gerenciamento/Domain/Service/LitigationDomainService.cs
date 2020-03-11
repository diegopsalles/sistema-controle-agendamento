using Domain.Contracts.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service
{
    public class LitigationDomainService : BaseDomainService<Litigation, int>, ILitigationDomainService
    {
        public void Create(Litigation obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Litigation obj)
        {
            throw new NotImplementedException();
        }

        public List<Litigation> ListAll()
        {
            throw new NotImplementedException();
        }

        public Litigation ListById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Litigation obj)
        {
            throw new NotImplementedException();
        }
    }
}
