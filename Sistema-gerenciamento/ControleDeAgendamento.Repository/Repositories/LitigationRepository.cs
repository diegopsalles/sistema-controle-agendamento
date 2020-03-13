using ControleDeAgendamento.Domain.Contracts.Repositories;
using ControleDeAgendamento.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeAgendamento.Repository.Repositories
{
    public class LitigationRepository : BaseRepository<Litigation, int>, ILitigationRepository
    {
        public decimal GetAmountByActiveProcess()
        {
            var amount = this.GetAll().Where(li => li.IsActive == true).Select(o => o.ValueProcess).Sum();

            return amount;
        }
        public decimal GetAmountyByCompany(int companyId, string state) 
        {
            var amount = this.GetAll().Where(li => li.CompanyId == companyId && li.State == state).Select(lt => lt.ValueProcess).Average();

            return amount;
        }
        public int GetAmountLitigationByValue() 
        {
            var _total = this.GetAll().Where(li => li.ValueProcess > 100000).Count();

            return _total;
        }
        public List<string> GetLitigationsByMonth(int month) 
        {
            List<string> lst = new List<string>();

            this.GetAll().Where(a => a.Date.Month == month).
                Select(lt => lt.IdProcess).
                ToList().
                ForEach(e => 
                {
                    lst.Add(e);
                });

            return lst;
        }
        public List<string> GetLitigationByCompany(int companyId, string companyState) 
        {
            List<string> lst = new List<string>();

            this.GetAll().Where(a => a.CompanyId == companyId && a.State == companyState).                
                Select(lt => lt.IdProcess).
                ToList().
                ForEach(e =>
                {
                    lst.Add(e);
                });

            return lst;
        }
        public List<string> GetLitigationByProcess(string process) 
        {
            List<string> lst = new List<string>();

            this.GetAll().Where(a => a.IdProcess.Contains(process)).
                Select(lt => lt.IdProcess).
                ToList().
                ForEach(e =>
                {
                    lst.Add(e);
                });

            return lst;
        }
    }
}
