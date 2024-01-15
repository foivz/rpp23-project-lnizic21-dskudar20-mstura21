using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LoanHistoryAndSanctionsService
    {
        public List<Loan> GetAllExpiredLoans(int librarianId)
        {
            using (var repo = new LoanHistoryAndSanctionRepository())
            {
                return repo.GetAllExpiredLoans(librarianId).ToList();
            }
        }
    }
}
