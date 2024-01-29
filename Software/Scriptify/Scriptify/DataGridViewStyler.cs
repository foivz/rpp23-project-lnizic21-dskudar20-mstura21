using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scriptify
{
    //Tu piši stilove za datagridview
    public class DataGridViewStyler
    {
        public void ChangeHeaderUI(DataGridView dgv)
        {

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgv.EnableHeadersVisualStyles = false;

            dgv.Columns["idUser"].HeaderText = "User ID";
            dgv.Columns["idUser"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns["username"].HeaderText = "Username";
            dgv.Columns["book_name"].HeaderText = "Book name";
            dgv.Columns["date_of_loan"].HeaderText = "Loan date";
            dgv.Columns["planned_return"].HeaderText = "Return date";
            dgv.Columns["first_name"].HeaderText = "First name";
            dgv.Columns["last_name"].HeaderText = "Last name";
            dgv.Columns["loan_status"].HeaderText = "Status";
            dgv.Columns["book_id"].HeaderText = "Book ID";
            dgv.Columns["book_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


        public void ChangeReservationHeaderUI(DataGridView dgv)
        {

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgv.EnableHeadersVisualStyles = false;

            dgv.Columns["id_user"].HeaderText = "User ID";
            dgv.Columns["id_user"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["username"].HeaderText = "Username";
            dgv.Columns["book_name"].HeaderText = "Book name";
            dgv.Columns["first_name"].HeaderText = "First name";
            dgv.Columns["last_name"].HeaderText = "Last name";
            dgv.Columns["id_book"].HeaderText = "Book ID";
            dgv.Columns["id_book"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        public void ChangeBooksHeaderUI(DataGridView dgv)
        {

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgv.EnableHeadersVisualStyles = false;

            dgv.Columns["idBook"].HeaderText = "Book ID";
            dgv.Columns["idBook"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns["book_name"].HeaderText = "Book Name";
            dgv.Columns["overview"].HeaderText = "Overview";
            dgv.Columns["author"].HeaderText = "Author";
            dgv.Columns["genre"].HeaderText = "Genre";
        }

        public void ChangeSPAHeaderUI(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
            dgv.EnableHeadersVisualStyles = false;

            dgv.Columns["IdLibrary"].HeaderText = "Library ID";
            dgv.Columns["IdLibrary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Loans"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Name"].HeaderText = "Library name";

        }
    }
}
