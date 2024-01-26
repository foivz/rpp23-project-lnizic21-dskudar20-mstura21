using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer {
    public class PendingLoansService {
        public List<Loan> GetAllPendingLoans(int librarianId) {
            using (var pending = new PendingLoansRepository()) {
                var loans = pending.GetAllPendingLoans(librarianId);
                return loans.ToList();
            }
        }
    }
}
