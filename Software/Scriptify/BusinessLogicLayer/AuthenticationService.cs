using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            using (var repo = new LibrarianRepository())
            {
                Librarian user = repo.GetUserByUsernameAndPasssword(username, password);
                return user != null;
            }
        }
        public int GetLibrarianLibraryIDbyName(string name) {
            using (var repo = new LibrarianRepository()) {
                return repo.GetLibrarianLibraryIDbyName(name);
            }
        }

        public bool CreateUser(Librarian user)
        {
            bool isSuccessful = false;
            using (var repo = new LibrarianRepository())
            {
                int affectedRow = repo.CreateNewUser(user);
                isSuccessful = affectedRow > 0;
            }
            return isSuccessful;
        }
        public List<Library> GetAllLibrariesForRegistration()
        {
            using (var repo = new LibraryRepository())
            {
                return repo.GetAllLibraries().ToList();
            }
        }
    }
}
