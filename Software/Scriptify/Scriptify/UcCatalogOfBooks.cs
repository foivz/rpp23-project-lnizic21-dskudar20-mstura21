using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using EntityLayer;
namespace Scriptify
{
    public partial class UcCatalogOfBooks : UserControl
    {
        
        
        private BookManagmentService bookManagmentService;
        private int Library_ID;
        public UcCatalogOfBooks(int id)
        {
            InitializeComponent();
            bookManagmentService = new BookManagmentService();
            Library_ID = id;
        }

        private void UcCatalogOfBooks_Load(object sender, EventArgs e)
        {
          
            List < Book > books = bookManagmentService.GetBooksForLibrary(Library_ID);
            dgvBookManagment.DataSource = books;
            dgvBookManagment.Columns["Users"].Visible = false;
            dgvBookManagment.Columns["Library_has_Books"].Visible = false;
            dgvBookManagment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddBook_Click(object sender, EventArgs e) {
            frmAdd_EditBooks frmAdd_EditBooks = new frmAdd_EditBooks(Action.Add,Library_ID,0);
            frmAdd_EditBooks.BookAddedEvent += LoadOnSucces;
            frmAdd_EditBooks.ShowDialog();  
        }

        private void btnEditBook_Click(object sender, EventArgs e) {
            if(dgvBookManagment.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a book to edit","No book is selected",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
                return;
            }
            int bookID = SelectedBookId();
            frmAdd_EditBooks frmAdd_EditBooks = new frmAdd_EditBooks(Action.Edit, Library_ID,bookID);
            frmAdd_EditBooks.BookAddedEvent += LoadOnSucces;
            frmAdd_EditBooks.ShowDialog();
        }
        private int SelectedBookId() {
         
           Book book =  dgvBookManagment.SelectedRows[0].DataBoundItem as Book;
            return book.idBook;
        }
        


        private void LoadOnSucces(object sender, EventArgs e) {
            List<Book> books = bookManagmentService.GetBooksForLibrary(Library_ID);
            dgvBookManagment.DataSource = books;
            dgvBookManagment.Columns["Users"].Visible = false;
            dgvBookManagment.Columns["Library_has_Books"].Visible = false;
            dgvBookManagment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e) {
            int bookID = SelectedBookId();
            var sucess =  bookManagmentService.DeleteBook(bookID);
            if (sucess) {
                MessageBox.Show("Book deleted successfully", "Book deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Book> books = bookManagmentService.GetBooksForLibrary(Library_ID);
                dgvBookManagment.DataSource = books;
                dgvBookManagment.Columns["Users"].Visible = false;
                dgvBookManagment.Columns["Library_has_Books"].Visible = false;
                dgvBookManagment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            } else {
                MessageBox.Show("Book could not be deleted", "Book not deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
