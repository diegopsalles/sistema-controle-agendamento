using ControleDeAgendamento.Domain.Contracts.Repositories;
using ControleDeAgendamento.Domain.Contracts.Services;
using System.Collections.Generic;

namespace ControleDeAgendamento.Domain.Service
{
    public class BaseDomainService<TEntity, TKey> : IBaseDomainService<TEntity, TKey> where TEntity : class
    {
        private readonly IBaseRepository<TEntity, TKey> _baseRepository;
        public BaseDomainService(IBaseRepository<TEntity, TKey> baseRepository) => _baseRepository = baseRepository;
        public void Create(TEntity obj) => this._baseRepository.Insert(obj);
        public void Delete(TEntity obj) => this._baseRepository.Delete(obj);
        public List<TEntity> ListAll() => this.ListAll();
        public TEntity ListById(TKey id) => this.ListById(id);
        public void Update(TEntity obj) => this.Update(obj);
    }
}
