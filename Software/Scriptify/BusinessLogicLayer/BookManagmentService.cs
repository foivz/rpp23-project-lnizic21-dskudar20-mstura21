using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer {
    public class BookManagmentService {
        public List<Book> GetBooksForLibrary(int id) {
            using(var repo = new BookManagmentRepository()) {
                return repo.GetBooksForLibrary(id).ToList();
            }   
        }
    }
}
