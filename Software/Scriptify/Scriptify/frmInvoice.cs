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
    public partial class frmInvoice : Form
    {
        private Sanction sanction = new Sanction();
        public event EventHandler FormFinish;
        public frmInvoice(Sanction sanction)
        {
            InitializeComponent();

            this.sanction = sanction;
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

            if(sanction.sanction_status == "Paid")
            {
                btnPaid.Visible = false;
                labelStatusPayed.Visible = true;
            }
            else
            {
                btnPaid.Visible = true;
                labelStatusPayed.Visible = false;
            }

            rtxtInvoice.SelectionFont = new Font(rtxtInvoice.Font, FontStyle.Bold);
            rtxtInvoice.SelectionAlignment = HorizontalAlignment.Center;

            string invoiceText = "Invoice " + sanction.id_sanction + "/2024\n\n\n";

            rtxtInvoice.AppendText(invoiceText);

            rtxtInvoice.SelectionFont = new Font(rtxtInvoice.Font, FontStyle.Regular);
            rtxtInvoice.SelectionAlignment = HorizontalAlignment.Center;


            string returnedString = sanction.returned.ToString();
            DateTime returnedDate = Convert.ToDateTime(returnedString);
            string formattedDateReturned = returnedDate.ToShortDateString();

            string dateofloan = sanction.date_of_loan.ToString();
            DateTime dateofloanDate = Convert.ToDateTime(dateofloan);
            string formattedDateOfLoan = dateofloanDate.ToShortDateString();

            string plannedreturn = sanction.planned_return.ToString();
            DateTime plannedDate = Convert.ToDateTime(plannedreturn);
            string formattedPlannedDate = plannedDate.ToShortDateString();

            invoiceText = "Scriptify Team \n";
            invoiceText += "Invoice date: " + formattedDateReturned + "\n\n";

            invoiceText += "User \n\n";
            invoiceText += "Name: " + sanction.user_first_name + " " + sanction.user_last_name + "\n";
            invoiceText += "Date of loan: " + formattedDateOfLoan + "\n";
            invoiceText += "Planned return: " + formattedPlannedDate + "\n";
            invoiceText += "Returned: " + formattedDateReturned + "\n\n";
            invoiceText += "Overview: Late return of the book\n\n";
            rtxtInvoice.AppendText(invoiceText);

            rtxtInvoice.SelectionFont = new Font(rtxtInvoice.Font, FontStyle.Bold);
            rtxtInvoice.SelectionAlignment = HorizontalAlignment.Center;

            invoiceText = "Amount: " + sanction.sanction_amount + " €" + "\n";

            rtxtInvoice.AppendText(invoiceText);

            
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            var service = new SanctionServices();
            service.UpdateSanction(sanction);
            FormFinish?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
