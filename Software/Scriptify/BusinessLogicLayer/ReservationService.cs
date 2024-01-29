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

        public List<Reservation_Projection> GetOldReservations(int librarianId)
        {
            using (var repo = new ReservationsRepository())
            {
                return repo.GetOldReservations(librarianId).ToList();
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

        public int DeleteOldReservations(int librarianId)
        {
            using (var repo = new ReservationsRepository())
            {
                
                var oldReservations = GetOldReservations(librarianId).ToList();

               
                foreach (var reservation in oldReservations)
                {
                    repo.DeleteReservation(reservation);
                }

                return oldReservations.Count;
            }
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
