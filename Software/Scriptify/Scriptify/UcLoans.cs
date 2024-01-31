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
        private DataGridViewStyler dataGridView = new DataGridViewStyler();
        PendingLoansService pending;
        List<Loan> loans;
        List<Loan> searchedName;
        List<Loan> searchedBook;
        public UcLoans(Librarian librarian)
        {
            InitializeComponent();
            this.Lib = librarian;
          
            pending = new PendingLoansService();
            loans = pending.GetAllPendingLoans(Lib.idLibrarians);
        }

        private void UcLoans_Load(object sender, EventArgs e)
        {

            dgvPendingLoans.DataSource = loans;
            dataGridView.ChangeHeaderUI(dgvPendingLoans);
            dgvPendingLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        private void txtUsername_TextChanged(object sender, EventArgs e) {
            
            if (searchedBook != null) {
                searchedName = searchedBook.Where(x => x.username.ToLower().Contains(txtUsername.Text.ToLower())).ToList();
            dgvPendingLoans.DataSource = searchedName;
            } else {
                searchedName = loans.Where(x => x.username.ToLower().Contains(txtUsername.Text.ToLower())).ToList();
                dgvPendingLoans.DataSource = searchedName;
            }
            if(txtSearchBooks.Text == "" && txtUsername.Text == "") {
                dgvPendingLoans.DataSource = pending.GetAllPendingLoans(Lib.idLibrarians);
            }
            
        }

        private void txtSearchBooks_TextChanged(object sender, EventArgs e) {
               
            if(searchedName != null) {
                searchedBook = searchedName.Where(x => x.book_name.ToLower()
                .Contains(txtSearchBooks.Text.ToLower())).ToList();
                dgvPendingLoans.DataSource = searchedBook;
            } else {
                searchedBook = loans.Where(x => x.book_name.ToLower()
                .Contains(txtSearchBooks.Text.ToLower())).ToList();
                dgvPendingLoans.DataSource = searchedBook;
            }
            if (txtSearchBooks.Text == "" && txtUsername.Text == "") {
                dgvPendingLoans.DataSource = pending.GetAllPendingLoans(Lib.idLibrarians);
            }

        }

      
    }
}
