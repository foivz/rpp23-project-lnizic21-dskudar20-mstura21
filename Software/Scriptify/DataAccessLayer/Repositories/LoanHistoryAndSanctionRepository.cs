using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LoanHistoryAndSanctionRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<Loan> Entities { get; set; }
        public LoanHistoryAndSanctionRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Loan>();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public IQueryable<Loan> GetAllExpiredLoans()
        {
            DateTime today = DateTime.Now.Date;

            var sql = from e in Entities
                      where e.planned_return <= today
                      select e;
            return sql;
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
