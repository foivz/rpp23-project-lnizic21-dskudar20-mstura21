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
        private Action FormAction;
        private int LibraryId;
        private int? BookId;
        public frmAdd_EditBooks(Action action,int id,int? bookid) {
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
            }
        }

        private void btn_save_Click(object sender, EventArgs e) {

        }

        private void btn_add_Click(object sender, EventArgs e) {
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
                    MessageBox.Show("Book added successfully to your Library", "Book added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
            }
        }
    }
}
