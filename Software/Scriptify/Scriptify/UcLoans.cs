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
    public partial class UcLoans : UserControl
    {
        private Librarian Lib;
        public UcLoans(Librarian librarian)
        {
            InitializeComponent();
            this.Lib = librarian;
        }

        private void UcLoans_Load(object sender, EventArgs e)
        {
            var pending = new PendingLoansService();
            dgvPendingLoans.DataSource = pending.GetAllPendingLoans(Lib.idLibrarians);
            ChangeHeaderUI();
            dgvPendingLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ChangeHeaderUI()
        {

            dgvPendingLoans.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvPendingLoans.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendingLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPendingLoans.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvPendingLoans.EnableHeadersVisualStyles = false;

            dgvPendingLoans.Columns["idUser"].HeaderText = "User ID";
            dgvPendingLoans.Columns["username"].HeaderText = "Username";
            dgvPendingLoans.Columns["username"].HeaderText = "Username";
            dgvPendingLoans.Columns["book_name"].HeaderText = "Book name";
            dgvPendingLoans.Columns["date_of_loan"].HeaderText = "Loan date";
            dgvPendingLoans.Columns["planned_return"].HeaderText = "Return date";
            dgvPendingLoans.Columns["first_name"].HeaderText = "First name";
            dgvPendingLoans.Columns["last_name"].HeaderText = "Last name";
            dgvPendingLoans.Columns["loan_status"].HeaderText = "Status";
            dgvPendingLoans.Columns["book_id"].HeaderText = "Book ID";


        }
    }
}
