using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ReservationsRepository:IDisposable
    {
        public EntityModels Context { get; set; }
        public DbSet<Reservation_Projection> Entities { get; set; }

        public ReservationsRepository()
        {
            Context = new EntityModels();
            Entities = Context.Set<Reservation_Projection>();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }


        public IQueryable<Reservation_Projection> GetReservations(int librarianId)
        {
            
            var reservtions = from reservation in Entities
                        join book in Context.Library_has_Books on reservation.book_id equals book.Books_idBook
                        join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                        where library.idLibrarians == librarianId
                        select reservation;

            return reservtions;
        }

        public int ReservationAccepted(Reservation_Projection reservation, bool saveChanges = true)
        {
            var existingReservation = Entities.FirstOrDefault(e => e.id_user == reservation.id_user && e.book_id == reservation.book_id);

            if (existingReservation != null)
            {
                
                Loan newLoan = new Loan
                {
                    idUser = existingReservation.id_user,
                    book_id = existingReservation.book_id,
                    date_of_loan = DateTime.Now,
                    loan_status = "In Progress",
                    planned_return = DateTime.Now.AddDays(7),

                    username = existingReservation.username,
                    first_name = existingReservation.first_name,
                    last_name = existingReservation.last_name,
                   

                };

                Context.Set<Loan>().Add(newLoan);


                if (saveChanges)
                {
                    return SaveChanges();
                }
            }

            return 0;
        }


        public void Dispose()
        {
            Context.Dispose();
        }
    }


}
