using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ReservationService
    {

        public List<Reservation_Projection> GetReservations(int librarianId)
        {
            using (var repo = new ReservationsRepository())
            {
                return repo.GetReservations(librarianId).ToList();
            }
        }

        public bool AcceptReservation(Reservation_Projection reservation)
        {
            bool isAccepted = false;
            using (var repo = new ReservationsRepository())
            {
                int affectedRow = repo.ReservationAccepted(reservation);
                isAccepted = affectedRow > 0;

            }
            return isAccepted;
        }

        public bool DeleteReservation(Reservation_Projection reservation)
        {
            bool isDeleted = false;
            using (var repo = new ReservationsRepository())
            {
                int affectedRow = repo.DeleteReservation(reservation);
                isDeleted = affectedRow > 0;

            }
            return isDeleted;
        }
    }
}
