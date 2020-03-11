using Domain.Contracts.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class LitigationRepository : BaseRepository<Litigation, int>, ILitigationRepository
    {
        public void Delete(Litigation obj)
        {
            throw new NotImplementedException();
        }

        public List<Litigation> GetAll()
        {
            throw new NotImplementedException();
        }

        public Litigation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Litigation obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Litigation obj)
        {
            throw new NotImplementedException();
        }
    }
}
