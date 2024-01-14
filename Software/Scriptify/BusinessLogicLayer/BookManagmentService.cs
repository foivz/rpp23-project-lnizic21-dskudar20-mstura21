using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using DataAccessLayer.Repositories;
using System.Data.Entity.Infrastructure;

namespace BusinessLogicLayer {
    public class BookManagmentService {
        public List<Book> GetBooksForLibrary(int id) {
            using(var repo = new BookManagmentRepository()) {
                return repo.GetBooksForLibrary(id).ToList();
            }   
        }
        public bool AddBookToLibrary(int idLibrary,string bookName) {
            using(var repo = new BookManagmentRepository()) {
                try {
                    repo.AddBookToLibrary(idLibrary,bookName);
                    return true;
                }catch(DbUpdateException ex) {
                    return false;
                }
                
            }
        }
    }
}
