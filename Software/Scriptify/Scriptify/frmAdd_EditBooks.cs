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
using EntityLayer;

namespace Scriptify {
    public enum Action {
        Add,
        Edit
    };

    public partial class frmAdd_EditBooks : Form {
        public delegate void BookAddedEventHandler(object sender, EventArgs e);
        public event BookAddedEventHandler BookAddedEvent;

        private Action FormAction;
        private int LibraryId;
        private int BookId;
        public frmAdd_EditBooks(Action action,int id,int bookid) {
            InitializeComponent();
            FormAction = action;
            LibraryId = id;
            BookId = bookid;
        }

        private void frmAdd_EditBooks_Load(object sender, EventArgs e) {
            if(FormAction == Action.Add) {
                txtTitle.Text = "Add Book";
                btn_save.Visible = false;
            } else if(FormAction == Action.Edit) {
                
                txtTitle.Text = "Edit Book";
                btn_add.Visible = false;
                BookManagmentService bookManagmentService = new BookManagmentService();
                var book = bookManagmentService.GetBookById(BookId);
                txtBookName.Text = book.book_name;
                txtAuthor.Text = book.author;
                txtDescription.Text = book.overview;
                txtGenre.Text = book.genre;
                
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e) {
           
            BookManagmentService bookManagmentService = new BookManagmentService();
            Book book = new Book {
                idBook = BookId,
                book_name = txtBookName.Text,
                author = txtAuthor.Text,
                overview = txtDescription.Text,
                genre = txtGenre.Text
            };
            var bookUpdated = bookManagmentService.UpdateBook(book);
            if (bookUpdated) {
                MessageBox.Show("Book updated successfully", "Book updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnBookAddedEvent();
                Close();
            } else {
                MessageBox.Show("Book could not be updated", "Book not updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            
        }

        private void btn_add_Click(object sender, EventArgs e) {
            if (CheckIfFormIsValid()) {
            BookManagmentService bookManagmentService = new BookManagmentService();
            Book book = new Book {
            book_name = txtBookName.Text,
            author = txtAuthor.Text,
            overview = txtDescription.Text,
            genre = txtGenre.Text
            };
            var bookAdded = bookManagmentService.AddBook(book);
            if (bookAdded) {
                MessageBox.Show("Book added successfully to the system","Book added",MessageBoxButtons.OK,MessageBoxIcon.Information);
                var bookAddedToLibrary = bookManagmentService.AddBookToLibrary(LibraryId, book.book_name);
                if (bookAddedToLibrary) {
                    MessageBox.Show("Book added successfully to your Library", "Book added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnBookAddedEvent();
                    Close();
                }
            }
            }
           

        }
        private Boolean CheckIfFormIsValid() {
            if (txtBookName.Text == "" || txtAuthor.Text == "" || txtDescription.Text == "" || txtGenre.Text == "") {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            } else {
                return true;
            }
        }

        protected virtual void OnBookAddedEvent() {
           
            BookAddedEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
