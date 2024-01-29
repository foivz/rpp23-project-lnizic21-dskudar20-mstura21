using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scriptify
{
    public class DataGridViewStyler
    {
        public void ChangeHeaderUI(DataGridView dgvPendingLoans)
        {

            dgvPendingLoans.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvPendingLoans.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendingLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPendingLoans.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvPendingLoans.EnableHeadersVisualStyles = false;

            dgvPendingLoans.Columns["idUser"].HeaderText = "User ID";
            dgvPendingLoans.Columns["username"].HeaderText = "Username";
            dgvPendingLoans.Columns["book_name"].HeaderText = "Book name";
            dgvPendingLoans.Columns["date_of_loan"].HeaderText = "Loan date";
            dgvPendingLoans.Columns["planned_return"].HeaderText = "Return date";
            dgvPendingLoans.Columns["first_name"].HeaderText = "First name";
            dgvPendingLoans.Columns["last_name"].HeaderText = "Last name";
            dgvPendingLoans.Columns["loan_status"].HeaderText = "Status";
            dgvPendingLoans.Columns["book_id"].HeaderText = "Book ID";  
        }


        public void ChangeReservationHeaderUI(DataGridView dgvPendingLoans)
        {

            dgvPendingLoans.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvPendingLoans.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendingLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPendingLoans.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvPendingLoans.EnableHeadersVisualStyles = false;

            dgvPendingLoans.Columns["id_user"].HeaderText = "User ID";
            dgvPendingLoans.Columns["username"].HeaderText = "Username";
            dgvPendingLoans.Columns["book_name"].HeaderText = "Book name";
            dgvPendingLoans.Columns["first_name"].HeaderText = "First name";
            dgvPendingLoans.Columns["last_name"].HeaderText = "Last name";
            dgvPendingLoans.Columns["id_book"].HeaderText = "Book ID";
        }

        public void ChangeBooksHeaderUI(DataGridView dgvPendingLoans)
        {

            dgvPendingLoans.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvPendingLoans.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPendingLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPendingLoans.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgvPendingLoans.EnableHeadersVisualStyles = false;

            dgvPendingLoans.Columns["idBook"].HeaderText = "Book ID";
            dgvPendingLoans.Columns["book_name"].HeaderText = "Book Name";
            dgvPendingLoans.Columns["overview"].HeaderText = "Overview";
            dgvPendingLoans.Columns["author"].HeaderText = "Author";
            dgvPendingLoans.Columns["genre"].HeaderText = "Genre";
        }
    }
}
