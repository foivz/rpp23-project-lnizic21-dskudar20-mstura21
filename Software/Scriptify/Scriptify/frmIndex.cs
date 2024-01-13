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
    public partial class frmIndex : Form
    {
        private Librarian user = new Librarian();
        public frmIndex(Librarian user)
        {
            InitializeComponent();
            this.user = user;
            labelUser.Text = user.first_name + " " + user.last_name;
            OpenHomePage();
        }
        
        private void OpenHomePage()
        {
            panelControls.Controls.Clear();
            UcHomePage ucHomePage = new UcHomePage();
            panelControls.Controls.Add(ucHomePage);
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
             
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            UcLoans ucLoans = new UcLoans();
            panelControls.Controls.Add(ucLoans);
        }

        private void btnCatalogOfBooks_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            UcCatalogOfBooks ucCatalogOfBooks = new UcCatalogOfBooks(user);
            panelControls.Controls.Add(ucCatalogOfBooks);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            UcHomePage ucHomePage = new UcHomePage();
            panelControls.Controls.Add(ucHomePage);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
