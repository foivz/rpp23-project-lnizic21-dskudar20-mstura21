using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LibraryHasBooksRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<Library_has_Books> Entities { get; set; }
        public LibraryHasBooksRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Library_has_Books>();
        }
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public IQueryable<Library_has_Books> GetAllBooksFromLibrary(int idLibrary)
        {
            var sql = from e in Entities
                      where e.Library_idLibrary == idLibrary
                      select e;
            return sql;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
