using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ReportsAndServicesService
    {
        public List<Book> GetTopBooks(int librarianId)
        {
            using (var repo = new ReportsAndStatisticsRepository())
            {
                return repo.GetTopBooks(librarianId).ToList();
            }
        }
    }
}
