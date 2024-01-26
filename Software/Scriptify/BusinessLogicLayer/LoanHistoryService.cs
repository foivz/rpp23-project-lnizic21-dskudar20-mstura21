using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class LoanHistoryService
    {
        public List<Loan> GetLoansInProgress(int librarianId)
        {
            using (var repo = new LoanHistoryRepository())
            {
                return repo.GetLoansInProgress(librarianId).ToList();
            }
        }

        public bool ReturnLoan(Loan loan)
        {
            bool isReturned = false;
            using (var repo = new LoanHistoryRepository())
            {
                int affectedRow = repo.LoanStatusCompleted(loan);
                isReturned = affectedRow > 0;
            }
            return isReturned;
        }
    }
}
