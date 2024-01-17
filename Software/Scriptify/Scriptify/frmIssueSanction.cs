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
        public frmIssueSanction(Loan loan)
        {
            InitializeComponent();
            this.loan = loan;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmIssueSanction_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            txtFirstName.Text = loan.first_name;
            txtLastName.Text = loan.last_name;
            txtBookName.Text = loan.book_name;
            dtmDateOfLoan.Value = Convert.ToDateTime(loan.date_of_loan);
            dtmPlannedReturn.Value = Convert.ToDateTime(loan.planned_return);

        }

        private void btnCalculateDays_Click(object sender, EventArgs e)
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

        private void btnCalculateAmount_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text == "")
            {
                MessageBox.Show("Please enter the amount!");
            }
            else if(txtDays.Text == "")
            {
                MessageBox.Show("Please calculate the number of days!");
            }
            else
            {
                try
                {
                    Validation(txtAmount.Text);
                    var totalAmount = Convert.ToDouble(txtAmount.Text) * Convert.ToDouble(txtDays.Text);
                    txtTotal.Text = totalAmount.ToString();
                }
                catch (IssueSanctionException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }
            
        }

        private void Validation(string text)
        {
            if (text.Any(char.IsLetter))
            {
                throw new IssueSanctionException("Please enter the number!");
            }
        }

        private void btnSanction_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text == "")
            {
                MessageBox.Show("Please caluclate the amount of sanction!");
            }
            else
            {
                var service = new LoanHistoryAndSanctionsService();
                service.IssueSanction(loan);

                MessageBox.Show("Sanction issued!");
                Close();
            }
        }
    }
}
