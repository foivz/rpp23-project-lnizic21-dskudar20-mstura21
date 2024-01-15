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
    public partial class frmIssueSanction : Form
    {
        private Loan loan = new Loan();
        public frmIssueSanction(Loan loan)
        {
            InitializeComponent();
            this.loan = loan;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmIssueSanction_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            txtFirstName.Text = loan.first_name;
            txtLastName.Text = loan.last_name;

        }
    }
}
