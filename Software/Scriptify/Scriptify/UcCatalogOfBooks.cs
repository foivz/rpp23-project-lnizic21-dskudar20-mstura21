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
            frmAdd_EditBooks frmAdd_EditBooks = new frmAdd_EditBooks(Action.Add,Library_ID);
            frmAdd_EditBooks.ShowDialog();  
        }

        private void btnEditBook_Click(object sender, EventArgs e) {
            frmAdd_EditBooks frmAdd_EditBooks = new frmAdd_EditBooks(Action.Edit, Library_ID);
            frmAdd_EditBooks.ShowDialog();
        }
    }
}
