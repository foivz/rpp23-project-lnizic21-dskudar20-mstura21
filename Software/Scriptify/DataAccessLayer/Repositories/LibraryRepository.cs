using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LibraryRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<Library> Entities { get; set; }
        public LibraryRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Library>();
        }
        public IQueryable<Library> GetAllLibraries()
        {
            var sql = from l in Entities
                      select l;
            return sql;
        }
        public Library GetLibraryById(int id) {
            var sql = from l in Entities
                      where l.idLibrary == id
                      select l;
            return sql.FirstOrDefault();
        }
        public Library GetLibraryByName(string name) {
            var sql = from l in Entities
                      where l.name == name
                      select l;
            return sql.FirstOrDefault();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
