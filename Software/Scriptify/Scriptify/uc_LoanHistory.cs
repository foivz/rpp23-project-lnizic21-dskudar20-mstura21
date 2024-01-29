﻿using BusinessLogicLayer;
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
            dgvLoanHistory.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Gray;
            ChangeHeaderUI();
            dgvLoanHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void ChangeHeaderUI()
        {

            dgvLoanHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvLoanHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoanHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLoanHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvLoanHistory.EnableHeadersVisualStyles = false;

            dgvLoanHistory.Columns["idUser"].HeaderText = "User ID";
            dgvLoanHistory.Columns["username"].HeaderText = "Username";
            dgvLoanHistory.Columns["username"].HeaderText = "Username";
            dgvLoanHistory.Columns["book_name"].HeaderText = "Book name";
            dgvLoanHistory.Columns["date_of_loan"].HeaderText = "Loan date";
            dgvLoanHistory.Columns["planned_return"].HeaderText = "Return date";
            dgvLoanHistory.Columns["first_name"].HeaderText = "First name";
            dgvLoanHistory.Columns["last_name"].HeaderText = "Last name";
            dgvLoanHistory.Columns["loan_status"].HeaderText = "Status";
            dgvLoanHistory.Columns["book_id"].HeaderText = "Book ID";


        }

        private void uc_LoanHistory_Load_1(object sender, EventArgs e)
        {
            ShowLoans();
        }

    }
}
