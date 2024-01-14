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
        private string placeholderText = "Search books";
        private BindingSource bindingSource = new BindingSource();
        private Librarian user = new Librarian();
        public UcCatalogOfBooks(Librarian user)
        {
            InitializeComponent();
            bookManagmentService = new BookManagmentService();
            this.user = user;

            txtSearchBooks.Text = placeholderText;
            txtSearchBooks.Enter += TextBoxSearch_Enter;
            txtSearchBooks.Leave += TextBoxSearch_Leave;

            cmbFiltering.Items.Add("Book name (A-Z)");
            cmbFiltering.Items.Add("Book name (Z-A)");
            cmbFiltering.Items.Add("Author (A-Z)");
            cmbFiltering.Items.Add("Author (Z-A)");
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearchBooks.Text == placeholderText)
            {
                txtSearchBooks.Text = "";
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBooks.Text))
            {
                txtSearchBooks.Text = placeholderText;
            }
        }

        private void UcCatalogOfBooks_Load(object sender, EventArgs e)
        {

            ShowBooks();
           
        }

        private void ShowBooks()
        {
            List<Book> books = bookManagmentService.GetBooksForLibrary(user.Library_idLibrary);


            string sortOrder = cmbFiltering?.SelectedItem?.ToString();

            if (sortOrder == "Book name (A-Z)")
            {
                books = books.OrderBy(book => book.book_name).ToList();
            }
            else if(sortOrder == "Book name (Z-A)")
            {
                books = books.OrderByDescending(book => book.book_name).ToList();
            }
            else if(sortOrder == "Author (A-Z)")
            {
                books = books.OrderBy(book => book.author).ToList();
            }
            else if (sortOrder == "Author (Z-A)")
            {
                books = books.OrderByDescending(book => book.author).ToList();
            }

            bindingSource.DataSource = books;
            dgvBookManagment.DataSource = bindingSource;

            dgvBookManagment.Columns["Users"].Visible = false;
            dgvBookManagment.Columns["Library_has_Books"].Visible = false;

            dgvBookManagment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddBook_Click(object sender, EventArgs e) {
            frmAdd_EditBooks frmAdd_EditBooks = new frmAdd_EditBooks(Action.Add,user.Library_idLibrary,0);
            frmAdd_EditBooks.BookAddedEvent += LoadOnSucces;
            frmAdd_EditBooks.ShowDialog();  
        }

        private void btnEditBook_Click(object sender, EventArgs e) {
            if(dgvBookManagment.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a book to edit","No book is selected",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
                return;
            }
            int bookID = SelectedBookId();
            frmAdd_EditBooks frmAdd_EditBooks = new frmAdd_EditBooks(Action.Edit, user.Library_idLibrary,bookID);
            frmAdd_EditBooks.BookAddedEvent += LoadOnSucces;
            frmAdd_EditBooks.ShowDialog();
        }
        private int SelectedBookId() {
         
           Book book =  dgvBookManagment.SelectedRows[0].DataBoundItem as Book;
            return book.idBook;
        }
        
        private void LoadOnSucces(object sender, EventArgs e) {
            List<Book> books = bookManagmentService.GetBooksForLibrary(user.Library_idLibrary);
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
                List<Book> books = bookManagmentService.GetBooksForLibrary(user.Library_idLibrary);
                dgvBookManagment.DataSource = books;
                dgvBookManagment.Columns["Users"].Visible = false;
                dgvBookManagment.Columns["Library_has_Books"].Visible = false;
                dgvBookManagment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            } else {
                MessageBox.Show("Book could not be deleted", "Book not deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBooks.Text.Trim().ToLowerInvariant();
            if (string.IsNullOrWhiteSpace(searchText) || searchText == placeholderText.ToLowerInvariant())
            {
                ShowBooks();
            }
            else
            {
                List<Book> listOfBooks = bookManagmentService.GetBooksForLibrary(user.Library_idLibrary);
                List<Book> filteredBooks = listOfBooks.Where(book => book.book_name.ToLowerInvariant().Contains(searchText)).ToList();
                bindingSource.DataSource = filteredBooks;
                dgvBookManagment.DataSource = bindingSource;
            }
        }

        private void cmbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBooks();
        }
    }
}
