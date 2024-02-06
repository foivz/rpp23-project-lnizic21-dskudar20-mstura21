using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class SanctionRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<Sanction> Entities { get; set; }
        public SanctionRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Sanction>();
        }
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public int SaveSanction(Sanction sanction, bool saveChanges = true)
        {
            Entities.Add(sanction);

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
