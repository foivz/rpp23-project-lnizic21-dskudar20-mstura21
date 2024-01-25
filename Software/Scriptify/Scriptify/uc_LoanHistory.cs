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
        private LoanHistoryAndSanctionsService loanHistoryAndSanctionsService;
        private Librarian user = new Librarian();
        public uc_LoanHistory(Librarian user)
        {
            InitializeComponent();
            this.user = user;
            loanHistoryAndSanctionsService = new LoanHistoryAndSanctionsService();
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {

        }

        private void uc_LoanHistory_Load(object sender, EventArgs e)
        {
            ShowLoans();
        }
        private void ShowLoans()
        {
            List<Loan> loans = loanHistoryAndSanctionsService.GetAllExpiredLoans(user.idLibrarians);
            dgv = loans;
            dgvLoanHistoryAndSanctions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
