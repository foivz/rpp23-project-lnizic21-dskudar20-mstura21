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
    public partial class uc_LoanHistory : UserControl
    {
        private LoanHistoryService loanHistoryService;
        private Librarian user = new Librarian();
        public uc_LoanHistory(Librarian user)
        {
            InitializeComponent();
            this.user = user;
            loanHistoryService = new LoanHistoryService();
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            var choosedLoan = dgvLoanHistory.CurrentRow.DataBoundItem as Loan;
            if (choosedLoan == null)
            {
                MessageBox.Show("Please select a loan that has been returned!");
            } else
            {
                {
                    loanHistoryService.ReturnLoan(choosedLoan);
                    dgvLoanHistory.DataSource = loanHistoryService.GetLoansInProgress(user.idLibrarians);

                }
            }
        }

      
        private void ShowLoans()
        {
            List<Loan> loans = loanHistoryService.GetLoansInProgress(user.idLibrarians);
            dgvLoanHistory.DataSource = loans;
            dgvLoanHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void uc_LoanHistory_Load_1(object sender, EventArgs e)
        {
            ShowLoans();
        }
    }
}
