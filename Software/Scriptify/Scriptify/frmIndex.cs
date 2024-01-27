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
        }
        
        private void OpenHomePage()
        {
            panelControls.Controls.Clear();
            UcHomePage ucHomePage = new UcHomePage();
            panelControls.Controls.Add(ucHomePage);
        }
        private void PdfLoader() {
            try {
                using (var doc = PdfDocument.Load("sample.pdf")) {
                var page = doc.Pages[0];
                int width = (int)page.Width;
                int height = (int)page.Height;

                using (var bitmap = new PdfBitmap(width, height, true)) {
                    bitmap.FillRect(0, 0, width, height, FS_COLOR.White);
                    page.Render(bitmap, 0, 0, width, height, PageRotate.Normal, RenderFlags.FPDF_NONE);

                    bitmap.GetImage().Save("sample.png", ImageFormat.Png);
                }
            }
            }catch(Exception e) {
                MessageBox.Show("Nije unesen pdf","Pdf Error",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
            }
                    
               
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            
            PdfLoader();
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

        private void txtBookReturn_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            uc_LoanHistory uc_LoanHistory = new uc_LoanHistory(loggedInUser);
            panelControls.Controls.Add(uc_LoanHistory);

        }

        private void txtReservation_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Clear();
            uc_Reservation uc_Reservation = new uc_Reservation(loggedInUser);
            panelControls.Controls.Add(uc_Reservation);
        }

        private void btnSAP_Click(object sender, EventArgs e) {
            panelControls.Controls.Clear();
            ucSAP ucSAP = new ucSAP(loggedInUser);
            panelControls.Controls.Add(ucSAP);
        }

        private void frmIndex_KeyPress(object sender, KeyPressEventArgs e) {
            MessageBox.Show($"Key pressed: {e.KeyChar}", "KeyPress Event");
            Help help = new Help();
                help.ShowDialog();
            
        }
    }
}
