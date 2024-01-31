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
using BusinessLogicLayer;
namespace Scriptify {
    public partial class ucSAP : UserControl {

        private Librarian Librarian;
        private DataGridViewStyler DataGridViewStyler = new DataGridViewStyler();
        public ucSAP(Librarian librarian) {
            InitializeComponent();
            this.Librarian = librarian;
        }

        private void ucSAP_Load(object sender, EventArgs e) {
            SAPService sAPService = new SAPService();
            var list = sAPService.getScriptifyAproovedData();
            list = list.OrderByDescending(r => r.Loans).ToList();
            dgvSAP.DataSource = list;
           DataGridViewStyler.ChangeSPAHeaderUI(dgvSAP);
            DataGridViewColumn loansColumn = dgvSAP.Columns["Loans"];
            dgvSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnScaling_Click(object sender, EventArgs e) {
            SAPService sAPService = new SAPService();
            var list = sAPService.SAPDataFairAlgorithm();
            dgvSAP.DataSource = list;
            DataGridViewStyler.ChangeSPAHeaderUISCALE(dgvSAP);
            dgvSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAlltime_Click(object sender, EventArgs e) {
            SAPService sAPService = new SAPService();
            var list = sAPService.getScriptifyAproovedData();
            list = list.OrderByDescending(r => r.Loans).ToList();
            dgvSAP.DataSource = list;
            DataGridViewStyler.ChangeSPAHeaderUI(dgvSAP);
            DataGridViewColumn loansColumn = dgvSAP.Columns["Loans"];
            dgvSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
