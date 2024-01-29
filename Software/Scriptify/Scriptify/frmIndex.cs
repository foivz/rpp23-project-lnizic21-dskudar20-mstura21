using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntityLayer;
using Patagames.Pdf;
using Patagames.Pdf.Enums;

using Patagames.Pdf.Net;

namespace Scriptify
{
    public partial class frmIndex : Form
    {
        private AuthenticationService authenticationService;
        private Librarian loggedInUser = new Librarian();
        

        public frmIndex(Librarian user)
        {
            InitializeComponent();
            labelUser.Text = user.first_name + " " + user.last_name;
            this.loggedInUser = user;
            authenticationService = new AuthenticationService();
            OpenHomePage();
            this.KeyPress += frmIndex_KeyPress;
            this.KeyPreview = true;
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
            UcLoans ucLoans = new UcLoans(loggedInUser);
            panelControls.Controls.Add(ucLoans);
        }

        private void btnCatalogOfBooks_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            int libraryId = authenticationService.GetLibrarianLibraryIDbyName(loggedInUser.username);
            UcCatalogOfBooks ucCatalogOfBooks = new UcCatalogOfBooks(loggedInUser);
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

        private void txtLoanHistory_Click(object sender, EventArgs e) {
            panelControls.Controls.Clear();
            uc_LoanHistoryAndSanctions uc_LoanHistoryAndSanctions = new uc_LoanHistoryAndSanctions(loggedInUser);
            panelControls.Controls.Add(uc_LoanHistoryAndSanctions);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            UcReportsAndStatistics ucReportsAndStatistics = new UcReportsAndStatistics(loggedInUser);
            panelControls.Controls.Add(ucReportsAndStatistics);
        }

        

        private void btnSAP_Click(object sender, EventArgs e) {
            panelControls.Controls.Clear();
            ucSAP ucSAP = new ucSAP(loggedInUser);
            panelControls.Controls.Add(ucSAP);
        }

        private void frmIndex_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            uc_Reservation uc_Reservation = new uc_Reservation(loggedInUser);
            panelControls.Controls.Add(uc_Reservation);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            uc_LoanHistory uc_LoanHistory = new uc_LoanHistory(loggedInUser);
            panelControls.Controls.Add(uc_LoanHistory);
        }

        private void frmIndex_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1) {
                Help help = new Help();
                help.ShowDialog();
            }

        }
    }
}
