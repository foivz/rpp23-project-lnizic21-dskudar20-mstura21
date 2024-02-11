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
        private string placeholderText = "Search loans by book name or username";
        private string placeholderTextSanctions = "Search sanctions by first name or last name";
        private BindingSource bindingSource = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        private Librarian user = new Librarian();
        private DataGridViewStyler dataGridView = new DataGridViewStyler();
        public uc_LoanHistoryAndSanctions(Librarian user) {
            InitializeComponent();
            this.user = user;
            loanHistoryAndSanctionsService = new LoanHistoryAndSanctionsService();
            txtSearchLoans.Text = placeholderText;
            txtSearchLoans.Enter += TextBoxSearch_Enter;
            txtSearchLoans.Leave += TextBoxSearch_Leave;

            txtSearchSanctions.Text = placeholderTextSanctions;
            txtSearchSanctions.Enter += TextBoxSearchS_Enter;
            txtSearchSanctions.Leave += TextBoxSearchS_Leave;

            cmbFiltering.Items.Add("All loans");
            cmbFiltering.Items.Add("Completed loans");
            cmbFiltering.Items.Add("In progress loans");
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
        private void TextBoxSearchS_Enter(object sender, EventArgs e)
        {
            if (txtSearchSanctions.Text == placeholderTextSanctions)
            {
                txtSearchSanctions.Text = "";
            }
        }

        private void TextBoxSearchS_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchSanctions.Text))
            {
                txtSearchSanctions.Text = placeholderTextSanctions;
            }
        }
        private void uc_LoanHistoryAndSanctions_Load(object sender, EventArgs e)
        {
            ShowLoans();
            ShowSanctions();
            btnLoanHistory.Visible = false;
            dgvSanctions.Visible = false;
            txtSearchSanctions.Visible = false;
        }

        private void ShowSanctions()
        {
            var service = new SanctionServices();
            List<Sanction> sanctions = service.GetAllSanctions();
            dgvSanctions.DataSource = sanctions;
            dataGridView.ChangeHeaderSanctionsUI(dgvSanctions);
            dgvSanctions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void ShowLoans()
        {
            List<Loan> loans = loanHistoryAndSanctionsService.GetAllExpiredLoans(user.idLibrarians);


            string sortOrder = cmbFiltering?.SelectedItem?.ToString();

            if (sortOrder == "All loans")
            {
                loans = loans;
            }
            else if (sortOrder == "Completed loans")
            {
                loans = loans.Where(l => l.loan_status == "Completed").ToList();
            }
            else if (sortOrder == "In progress loans")
            {
                loans = loans.Where(l => l.loan_status == "In progress").ToList();
            }
            
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
                    frmIssueSanction frmIssueSanction = new frmIssueSanction(choosedLoan, user);
                    frmIssueSanction.FormClosed += frmIssueSanction_FormClosed;

                    frmIssueSanction.ShowDialog();

                }
            }
        }

        private void frmIssueSanction_FormClosed(object sender, EventArgs e)
        {
            ReloadLoanHistoryAndSanctions();
        }

        private void ReloadLoanHistoryAndSanctions()
        {
            this.Controls.Clear();
            uc_LoanHistoryAndSanctions uc_LoanHistoryAndSanctions = new uc_LoanHistoryAndSanctions(user);
            this.Controls.Add(uc_LoanHistoryAndSanctions);
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

                string sortOrder = cmbFiltering?.SelectedItem?.ToString();

                if (sortOrder == "All loans")
                {
                    listOfLoans = listOfLoans;
                }
                else if (sortOrder == "Completed loans")
                {
                    listOfLoans = listOfLoans.Where(l => l.loan_status == "Completed").ToList();
                }
                else if (sortOrder == "In progress loans")
                {
                    listOfLoans = listOfLoans.Where(l => l.loan_status == "In progress").ToList();
                }

                List<Loan> filteredLoans = listOfLoans.Where(loan => (loan.book_name.ToLowerInvariant().Contains(searchText)) || (loan.username.ToLowerInvariant().Contains(searchText))).ToList();
                bindingSource.DataSource = filteredLoans;
                dgvLoanHistoryAndSanctions.DataSource = bindingSource;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnSanctions.Visible = false;
            btnSanction.Visible = false;
            dgvLoanHistoryAndSanctions.Visible = false;
            txtSearchLoans.Visible = false;
            txtSearchSanctions.Visible = true;
            label2.Visible = false;
            btnLoanHistory.Visible = true;
            dgvSanctions.Visible = true;
            cmbFiltering.Visible = false;
            label3.Visible = false;
        }

        private void btnLoanHistory_Click(object sender, EventArgs e)
        {
            btnLoanHistory.Visible = false;
            btnSanctions.Visible = true;
            btnSanction.Visible = true;
            dgvLoanHistoryAndSanctions.Visible = true;
            txtSearchLoans.Visible = true;
            txtSearchSanctions.Visible = false;
            label2.Visible = true;
            dgvLoanHistoryAndSanctions.Visible = true;
            dgvSanctions.Visible = false;
            cmbFiltering.Visible = true;
            label3.Visible = true;

        }

        private void txtSearchSanctions_TextChanged(object sender, EventArgs e)
        {
            var service = new SanctionServices();
            string searchText = txtSearchSanctions.Text.Trim().ToLowerInvariant();
            if (string.IsNullOrWhiteSpace(searchText) || searchText == placeholderTextSanctions.ToLowerInvariant())
            {
                ShowSanctions();
            }
            else
            {
                List<Sanction> listOfSanctions = service.GetAllSanctions();
                List<Sanction> filteredSanctions = listOfSanctions.Where(sanction => (sanction.user_last_name.ToLowerInvariant().Contains(searchText)) || (sanction.user_first_name.ToLowerInvariant().Contains(searchText))).ToList();
                bindingSource2.DataSource = filteredSanctions;
                dgvSanctions.DataSource = bindingSource2;
            }
        }

        private void cmbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowLoans();
        }
    }
}
