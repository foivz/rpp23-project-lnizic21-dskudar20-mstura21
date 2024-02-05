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
        private string placeholderText = "Search loans by book name";
        private BindingSource bindingSource = new BindingSource();
        private Librarian user = new Librarian();
        private DataGridViewStyler dataGridView = new DataGridViewStyler();
        public uc_LoanHistoryAndSanctions(Librarian user) {
            InitializeComponent();
            this.user = user;
            loanHistoryAndSanctionsService = new LoanHistoryAndSanctionsService();
            txtSearchLoans.Text = placeholderText;
            txtSearchLoans.Enter += TextBoxSearch_Enter;
            txtSearchLoans.Leave += TextBoxSearch_Leave;
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearchLoans.Text == placeholderText)
            {
                txtSearchLoans.Text = "";
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchLoans.Text))
            {
                txtSearchLoans.Text = placeholderText;
            }
        }
        private void uc_LoanHistoryAndSanctions_Load(object sender, EventArgs e)
        {
            ShowLoans();
        }

        private void ShowLoans()
        {
            List<Loan> loans = loanHistoryAndSanctionsService.GetAllExpiredLoans(user.idLibrarians);
            bindingSource.DataSource = loans;
            dgvLoanHistoryAndSanctions.DataSource = bindingSource;
            dataGridView.ChangeHeaderUI(dgvLoanHistoryAndSanctions);
            dgvLoanHistoryAndSanctions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void btnSanction_Click(object sender, EventArgs e)
        {
            var choosedLoan = dgvLoanHistoryAndSanctions.CurrentRow.DataBoundItem as Loan;
            if(choosedLoan == null)
            {
                MessageBox.Show("Please select a loan for issuing a sanction!");
            }
            else
            {
                if(choosedLoan.loan_status == "Completed" || choosedLoan.loan_status == "Sanction issued")
                {
                    MessageBox.Show("Please select the loan that is overdue!");
                }
                else
                {
                    frmIssueSanction frmIssueSanction = new frmIssueSanction(choosedLoan);
                    frmIssueSanction.ShowDialog();

                }
            }
        }

        private void dgvLoanHistoryAndSanctions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvLoanHistoryAndSanctions.Columns["loan_status"].Index && e.RowIndex >= 0)
            {
                object cellValue = dgvLoanHistoryAndSanctions[e.ColumnIndex, e.RowIndex].Value;

                if (cellValue != null)
                {
                    string statusValue = cellValue.ToString();

                    if (statusValue.Equals("In progress", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvLoanHistoryAndSanctions.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (statusValue.Equals("Sanction issued", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvLoanHistoryAndSanctions.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (statusValue.Equals("Completed", StringComparison.OrdinalIgnoreCase))
                    {
                        dgvLoanHistoryAndSanctions.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    }
                }
            }
        }


        private void txtSearchLoans_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchLoans.Text.Trim().ToLowerInvariant();
            if (string.IsNullOrWhiteSpace(searchText) || searchText == placeholderText.ToLowerInvariant())
            {
                ShowLoans();
            }
            else
            {
                List<Loan> listOfLoans = loanHistoryAndSanctionsService.GetAllExpiredLoans(user.idLibrarians);
                List<Loan> filteredLoans = listOfLoans.Where(loan => loan.book_name.ToLowerInvariant().Contains(searchText)).ToList();
                bindingSource.DataSource = filteredLoans;
                dgvLoanHistoryAndSanctions.DataSource = bindingSource;
            }
        }
    }
}
