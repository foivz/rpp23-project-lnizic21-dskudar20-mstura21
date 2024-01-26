using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

       public List<Loan> GetLoansInProgress(int librarianId)
        {      using (var repo = new LoanHistoryAndSanctionRepository())
            {
                return repo.GetLoansInProgress(librarianId).ToList();
            }
        }

        public bool ReturnLoan(Loan loan)
        {
            bool isReturned = false;
            using (var repo = new LoanHistoryAndSanctionRepository())
            {
                int affectedRow = repo.LoanStatusCompleted(loan);
                isReturned = affectedRow > 0;
            }
            return isReturned;
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
