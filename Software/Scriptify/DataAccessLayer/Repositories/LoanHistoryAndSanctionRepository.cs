﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LoanHistoryAndSanctionRepository : IDisposable
    {
        protected EntityModels Context { get; set; }
        public DbSet<Loan> Entities { get; set; }
        public LoanHistoryAndSanctionRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Loan>();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public IQueryable<Loan> GetAllExpiredLoans(int librarianId)
        {
            DateTime today = DateTime.Now.Date;

            var loans = from loan in Entities
                        join book in Context.Library_has_Books on loan.book_id equals book.Books_idBook
                        join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                        where library.idLibrarians == librarianId && loan.planned_return <= today
                        select loan;

            return loans;
        }

        public int IssueSanction(Loan loan, bool saveChanges = true)
        {
            var sql = from e in Entities
                      where e == loan
                      select loan;
            Loan loanToUpdate = sql.FirstOrDefault();
            loanToUpdate.loan_status = "Sanction issued";

            if (saveChanges)
            {
                return SaveChanges();
            }
            else return 0;
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
