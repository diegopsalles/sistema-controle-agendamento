using ControleDeAgendamento.Domain.Contracts.Repositories;
using ControleDeAgendamento.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeAgendamento.Repository.Repositories
{
    public class BaseRepository<TEntity, Tkey> : IBaseRepository<TEntity, Tkey> where TEntity : class
    {        
        public void Delete(TEntity obj)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Entry(obj).State = EntityState.Deleted;                
                ctx.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Set<TEntity>().ToList();
            }

        }

        public TEntity GetById(Tkey id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Set<TEntity>().Find(id);
            }
        }

        public void Insert(TEntity obj)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Entry(obj).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Update(TEntity obj)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Entry(obj).State = EntityState.Modified;
                ctx.SaveChanges();
            }

        }
    }
}
