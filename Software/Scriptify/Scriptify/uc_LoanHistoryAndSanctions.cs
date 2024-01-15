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

namespace Scriptify {
    public partial class uc_LoanHistoryAndSanctions : UserControl {

        private LoanHistoryAndSanctionsService loanHistoryAndSanctionsService;
        private Librarian user = new Librarian();
        public uc_LoanHistoryAndSanctions(Librarian user) {
            InitializeComponent();
            user = user;
            loanHistoryAndSanctionsService = new LoanHistoryAndSanctionsService();
        }

        private void uc_LoanHistoryAndSanctions_Load(object sender, EventArgs e)
        {
            ShowLoans();
        }

        private void ShowLoans()
        {
            List<Loan> loans = loanHistoryAndSanctionsService.GetAllExpiredLoans();
            dgvLoanHistoryAndSanctions.DataSource = loans;
        }
    }
}
