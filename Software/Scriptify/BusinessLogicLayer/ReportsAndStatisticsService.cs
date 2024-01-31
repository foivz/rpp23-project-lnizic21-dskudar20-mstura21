using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ReportsAndStatisticsService
    {
        public List<Book> GetTopBooks(int librarianId)
        {
            using (var repo = new ReportsAndStatisticsRepository())
            {
                return repo.GetTopBooks(librarianId).ToList();
            }
        }
        public List<User> GetTopUsers(int librarianId)
        {
            using (var repo = new ReportsAndStatisticsRepository())
            {
                return repo.GetTopUsers(librarianId).ToList();
            }
        }

        public List<UserWithCount> GetTop10Users(int librarianId)
        {
            using (var repo = new ReportsAndStatisticsRepository())
            {
                return repo.GetTop10Users(librarianId).ToList();
            }
        }

        public List<BookWithCount> GetTop10Books(int librarianId)
        {
            using (var repo = new ReportsAndStatisticsRepository())
            {
                return repo.GetTop10Books(librarianId).ToList();
            }
        }

    }
}
