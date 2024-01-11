using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<User> Entities { get; set; }
        public UserRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<User>();
        }
        
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public User GetUserByUsernameAndPasssword(string username, string password)
        {
            return Entities.SingleOrDefault(u => u.username == username && u.password == password);
        }

        public int CreateNewUser(User user, bool saveChanges = true)
        {

            Entities.Add(user);

            if(saveChanges)
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
