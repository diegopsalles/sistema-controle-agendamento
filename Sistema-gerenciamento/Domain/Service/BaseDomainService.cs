using Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service
{
    public class BaseDomainService<TEntity, TKey> : IBaseDomainService<TEntity, TKey> where TEntity : class
    {
        public void Create(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> ListAll()
        {
            throw new NotImplementedException();
        }

        public TEntity ListById(TKey id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
