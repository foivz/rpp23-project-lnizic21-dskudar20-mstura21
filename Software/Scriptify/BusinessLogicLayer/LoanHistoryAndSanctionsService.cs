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
        
        public bool IssueSanction(Loan loan)
        {
            bool isSuccessful = false;
            using (var repo = new LoanHistoryAndSanctionRepository())
            {
                int affectedRow = repo.IssueSanction(loan);
                isSuccessful = affectedRow > 0;
            }
            return isSuccessful;
        }
    }
}
