using BusinessLogicLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scriptify
{
    public partial class uc_Reservation : UserControl
    {

        private ReservationService reservationService;
        private Librarian user = new Librarian();
        public uc_Reservation(Librarian user)
        {
            InitializeComponent();
            this.user = user;
            reservationService = new ReservationService();
        }

        private void uc_Reservation_Load(object sender, EventArgs e)
        {
            ShowReservations();
        }

        public void ShowReservations()
        {

            List<Reservation_Projection> reservations = reservationService.GetReservations(user.idLibrarians);
            dgvReservation.DataSource = reservations;
            dgvReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            var choosedLoan = dgvReservation.CurrentRow.DataBoundItem as Reservation_Projection;
            if (choosedLoan == null)
            {
                MessageBox.Show("Please select a reservation!");
            } else
            {
                {
                    reservationService.AcceptReservation(choosedLoan);
                    List<Reservation_Projection> reservations = reservationService.GetReservations(user.idLibrarians);
                    dgvReservation.DataSource = reservations;

                }
            }
        }
    }
}
