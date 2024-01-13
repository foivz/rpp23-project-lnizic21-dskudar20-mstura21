using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LibraryHasBooksService
    {

        public List<Book> GetAllGetAllBooksFromLibrary(int idLibrary)
        {
            using (var repo = new LibraryHasBooksRepository())
            {
                return repo.GetAllBooksFromLibrary(idLibrary).ToList();
            }
        }
    }
}
