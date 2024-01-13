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
    public partial class UcCatalogOfBooks : UserControl
    {
        private string placeholderText = "Search books";

        private Librarian user = new Librarian();
        public UcCatalogOfBooks(Librarian user)
        {
            InitializeComponent();
            this.user = user;

            txtSearchText.Text = placeholderText;
            txtSearchText.Enter += TextBoxSearch_Enter;
            txtSearchText.Leave += TextBoxSearch_Leave;
        }
        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearchText.Text == placeholderText)
            {
                txtSearchText.Text = "";
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchText.Text))
            {
                txtSearchText.Text = placeholderText;
            }
        }

        private void UcCatalogOfBooks_Load(object sender, EventArgs e)
        {
            ShowBooks();
        }

        private void ShowBooks()
        {
            var service = new LibraryHasBooksService();
            dgvCatalogOfBooks.DataSource = service.GetAllGetAllBooksFromLibrary(user.Library_idLibrary);
            dgvCatalogOfBooks.Columns["Library_has_Books"].Visible = false;
            dgvCatalogOfBooks.Columns["Users"].Visible = false;
        }
    }
}
