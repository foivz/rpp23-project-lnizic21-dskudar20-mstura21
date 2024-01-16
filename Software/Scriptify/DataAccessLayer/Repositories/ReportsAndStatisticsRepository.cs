using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ReportsAndStatisticsRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<Book> Entities { get; set; }
        public ReportsAndStatisticsRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Book>();
        }
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
