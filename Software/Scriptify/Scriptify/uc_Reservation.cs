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
        private DataGridViewStyler dataGridView = new DataGridViewStyler();
        public uc_Reservation(Librarian user)
        {
            InitializeComponent();
            this.user = user;
            reservationService = new ReservationService();
        }

       

        public void ShowReservations()
        {

            List<Reservation_Projection> reservations = reservationService.GetReservations(user.idLibrarians);
            dgvReservation.DataSource = reservations;
            dataGridView.ChangeReservationHeaderUI(dgvReservation);
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
                    MessageBox.Show("Reservation accepted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }

        private void uc_Reservation_Load_1(object sender, EventArgs e) {
            ShowReservations();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var choosedLoan = dgvReservation.CurrentRow.DataBoundItem as Reservation_Projection;
            if (choosedLoan == null)
            {
                MessageBox.Show("Please select a reservation!");
            } else
            {
                {
                    reservationService.DeleteReservation(choosedLoan);
                    List<Reservation_Projection> reservations = reservationService.GetReservations(user.idLibrarians);
                    dgvReservation.DataSource = reservations;
                    MessageBox.Show("Successful deletion!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
  }
