using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
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
            var BMS = new BookManagmentService();
            
            if (FormAction == Action.Add) {
                txtTitle.Text = "Add Book";
                btn_save.Visible = false;
                cmbAuthors.DataSource = BMS.GetAuthors();
                
                cmbAuthors.SelectedIndex = -1;
                if(cmbAuthors.SelectedIndex == -1) {
                    txtAuthor.Enabled = true;
                } else {
                    txtAuthor.Enabled = false;
                    txtAuthor.Clear();
                }
                cmbGenre.DataSource = BMS.GetGenres();
                Combobox_conf();
            } else if(FormAction == Action.Edit) {
                
                txtTitle.Text = "Edit Book";
                btn_add.Visible = false;
                BookManagmentService bookManagmentService = new BookManagmentService();
                var book = bookManagmentService.GetBookById(BookId);
                cmbAuthors.DataSource = BMS.GetAuthors();
                cmbGenre.DataSource = BMS.GetGenres();
                cmbAuthors.SelectedIndex = -1;
                Combobox_conf();
                txtBookName.Text = book.book_name;
                txtAuthor.Text = book.author;
                txtDescription.Text = book.overview;
                cmbGenre.Text = book.genre;
                
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e) {
            
                BookManagmentService bookManagmentService = new BookManagmentService();
                try {
                    Book book;
                    bool bookUpdated;
                    if (cmbAuthors.SelectedIndex == -1 && txtAuthor.Text == "") {
                        MessageBox.Show("Autor selection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtAuthor.Enabled == true) {
                        bool isAuthorIS = bookManagmentService.AddAuthor(txtAuthor.Text);
                        book = new Book {
                            idBook = BookId,
                            book_name = txtBookName.Text,
                            author = txtAuthor.Text,
                            overview = txtDescription.Text,
                            genre = cmbGenre.Text
                        };
                        bookUpdated = bookManagmentService.UpdateBook(book);
                    } else if (txtAuthor.Text == "" && cmbAuthors.SelectedIndex != -1) {
                        book = new Book {
                            idBook = BookId,
                            book_name = txtBookName.Text,
                            author = cmbAuthors.Text,
                            overview = txtDescription.Text,
                            genre = cmbGenre.Text
                        };
                        bookUpdated = bookManagmentService.UpdateBook(book);
                    } else if (txtAuthor.Text != "" && cmbAuthors.Text == "") {
                        book = new Book {

                            book_name = txtBookName.Text,
                            author = txtAuthor.Text,
                            overview = txtDescription.Text,
                            genre = cmbGenre.Text
                        };
                        bookUpdated = bookManagmentService.UpdateBook(book);
                    } else {
                        MessageBox.Show("Autor selection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bookUpdated = false;
                    }

                    if (bookUpdated) {

                        OnBookAddedEvent();
                        Close();
                    } else {
                        MessageBox.Show("Book could not be updated", "Book not updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (DbUpdateException err) {
                    MessageBox.Show("Error updating database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }

        private void btn_add_Click(object sender, EventArgs e) {

            if (CheckIfFormIsValid()) {
            BookManagmentService bookManagmentService = new BookManagmentService();
                Book book;
          
                if (txtAuthor.Enabled == true) {
                    bool isAuthorIS = bookManagmentService.AddAuthor(txtAuthor.Text);
                    book = new Book {
                       
                        book_name = txtBookName.Text,
                        author = txtAuthor.Text,
                        overview = txtDescription.Text,
                        genre = cmbGenre.Text
            };
                } else {
                    book = new Book {
                    
                        book_name = txtBookName.Text,
                        author = cmbAuthors.Text,
                        overview = txtDescription.Text,
                        genre = cmbGenre.Text
                    };

                }
            
            var bookAdded = bookManagmentService.AddBook(book);
            if (bookAdded) {
                
                var bookAddedToLibrary = bookManagmentService.AddBookToLibrary(LibraryId, book.book_name,book.idBook);
                if (bookAddedToLibrary) {
                  
                    OnBookAddedEvent();
                    Close();
                }
            }
            }
           

        }
        private Boolean CheckIfFormIsValid() {
            var BMS = new BookManagmentService();
            var books = BMS.GetBooksForLibrary(LibraryId);
            if(books.Any(x => x.book_name == txtBookName.Text && x.overview == txtDescription.Text)) {
                MessageBox.Show("Book with that name and description already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbAuthors.SelectedIndex == -1) {
                
            if (txtBookName.Text == "" || txtAuthor.Text == "" || txtDescription.Text == "" || cmbGenre.Text == "") {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            } else {
                return true;
            }

            } else {

                if (txtBookName.Text == "" || cmbAuthors.Text == "" || txtDescription.Text == "" || cmbGenre.Text == "") {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                } else {
                    return true;
                }
            }

        }
        private void Combobox_conf() {
            
            cmbAuthors.DisplayMember = "name";
            cmbAuthors.ValueMember = "name";
            cmbGenre.DisplayMember = "genre";
            cmbGenre.ValueMember = "genre";
            cmbAuthors.SelectedIndex = -1;
        }

        protected virtual void OnBookAddedEvent() {
           
            BookAddedEvent?.Invoke(this, EventArgs.Empty);
        }


        private void btnDeselect_Click(object sender, EventArgs e) {
            cmbAuthors.SelectedIndex = -1;
            if (cmbAuthors.SelectedIndex == -1) {
                txtAuthor.Enabled = true;
            } else {
                txtAuthor.Enabled = false;
                txtAuthor.Clear();
            }
        }

        private void cmbAuthors_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbAuthors.SelectedIndex == -1) {
                txtAuthor.Enabled = true;

            } else {
                txtAuthor.Enabled = false;
                txtAuthor.Clear();
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            var BMS = new BookManagmentService();
            cmbAuthors.DataSource = BMS.GetSpecificAuthor(txtAuthorSearch.Text);
        }

        private void txtGenreSearch_KeyPress(object sender, KeyPressEventArgs e) {
            var BMS = new BookManagmentService();
            cmbGenre.DataSource = BMS.GetSpecificGenre(txtGenreSearch.Text);
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
    }
}
