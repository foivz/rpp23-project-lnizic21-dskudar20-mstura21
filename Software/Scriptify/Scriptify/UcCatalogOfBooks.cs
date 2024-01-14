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
            dgvBookManagment.DataSource = bookManagmentService.GetBooksForLibrary(Library_ID);
        }
    }
}
