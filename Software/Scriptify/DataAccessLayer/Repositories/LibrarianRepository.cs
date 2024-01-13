using DataAccessLayer.Iznimke;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LibrarianRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<Librarian> Entities { get; set; }
        public LibrarianRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Librarian>();
        }
        
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public Librarian GetUserByUsernameAndPasssword(string username, string password)
        {
            return Entities.SingleOrDefault(u => u.username == username && u.password == password);
        }

        public int CreateNewUser(Librarian user, bool saveChanges = true)
        {
            if(Entities.Count(u => u.username == user.username) > 0)
            {
                throw new RegistrationException("User with username " + user.username + " is already exists!");
            }
            else
            {
                Entities.Add(user);
            }

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
