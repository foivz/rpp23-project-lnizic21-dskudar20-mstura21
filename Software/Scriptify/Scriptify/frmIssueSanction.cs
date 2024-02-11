using BusinessLogicLayer;
using DataAccessLayer.Iznimke;
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
    public partial class frmIssueSanction : Form
    {
        private Loan loan = new Loan();
        private Librarian librarian = new Librarian();
        public event EventHandler FormClosed;
        public frmIssueSanction(Loan loan, Librarian librarian)
        {
            InitializeComponent();
            this.loan = loan;
            this.librarian = librarian;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmIssueSanction_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "0,5";

            CalculateDays();
            CalculateSanction();

            ShowData();
        }

        private void CalculateSanction()
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please enter the amount!");
            }
            else if (txtDays.Text == "")
            {
                MessageBox.Show("Please calculate the number of days!");
            }
            else
            {
                try
                {
                    Validation(txtAmount.Text);
                    var totalAmount = Convert.ToDecimal(txtAmount.Text) * Convert.ToDecimal(txtDays.Text);
                    txtTotal.Text = totalAmount.ToString();
                }
                catch (IssueSanctionException ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void CalculateDays()
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan? difference = today - loan.planned_return;

            if (difference.HasValue)
            {
                int days = difference.Value.Days;
                txtDays.Text = days.ToString();
            }
            else
            {
                MessageBox.Show("Unable to calculate the difference in days. Try again..");
            }
        }

        private void ShowData()
        {
            txtFirstName.Text = loan.first_name;
            txtLastName.Text = loan.last_name;
            txtBookName.Text = loan.book_name;
            dtmDateOfLoan.Value = Convert.ToDateTime(loan.date_of_loan);
            dtmPlannedReturn.Value = Convert.ToDateTime(loan.planned_return);

        }


        private void Validation(string text)
        {
            if (text.Any(char.IsLetter))
            {
                throw new IssueSanctionException("A number must be entered!");
            }
        }

        private void btnSanction_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text == "")
            {
                MessageBox.Show("A problem with calculating the amount of the sanction!");
            }
            else
            {
                var service = new LoanHistoryAndSanctionsService();
                service.IssueSanction(loan);
                SaveSanction();
                FormClosed?.Invoke(this, EventArgs.Empty);
                Close();
            }
        }

        private void SaveSanction()
        {
            var service = new SanctionServices();

            DateTime today = DateTime.Now.Date;

            Sanction sanction = new Sanction()
            {
                id_librarian = librarian.idLibrarians,
                id_user = loan.idUser,
                user_first_name = loan.first_name,
                user_last_name = loan.last_name,
                date_of_loan = loan.date_of_loan,
                planned_return = loan.planned_return,
                returned = today,
                sanction_amount = Convert.ToDecimal(txtTotal.Text),
            };

            service.SaveSanction(sanction);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
