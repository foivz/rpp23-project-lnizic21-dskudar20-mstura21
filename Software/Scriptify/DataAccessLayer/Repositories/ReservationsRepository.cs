using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ReservationsRepository : IDisposable
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

            var reservations = from reservation in Entities
                              join book in Context.Library_has_Books on reservation.id_book equals book.Books_idBook
                              join library in Context.Librarians on book.Library_idLibrary equals library.Library_idLibrary
                               where library.idLibrarians == librarianId
                               select reservation;
           
            foreach (var reservation in reservations)
            {
                Book matchingBook = Context.Books.FirstOrDefault(p => p.idBook == reservation.id_book);

                if (matchingBook != null)
                {
                    reservation.book_name = matchingBook.book_name;
                }
            }
            return reservations;
        }

        public void DeleteReservation(Reservation_Projection reservation)
        {
            Entities.Remove(reservation);
            SaveChanges();
        }
        public int ReservationAccepted(Reservation_Projection reservation, bool saveChanges = true)
        {
            var existingReservation = Entities.FirstOrDefault(e => e.id_user == reservation.id_user && e.id_book == reservation.id_book);

            if (existingReservation != null)
            {

                Loan newLoan = new Loan
                {
                    idUser = existingReservation.id_user,
                    book_id = existingReservation.id_book,
                    date_of_loan = DateTime.Now,
                    loan_status = "In Progress",
                    planned_return = DateTime.Now.AddDays(7),
                    book_name = existingReservation.book_name,
                    username = existingReservation.username,
                    first_name = existingReservation.first_name,
                    last_name = existingReservation.last_name,


                };

                Context.Set<Loan>().Add(newLoan);

                DeleteReservation(existingReservation);

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
