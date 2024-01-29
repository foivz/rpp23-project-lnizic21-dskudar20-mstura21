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
            dgvSAP.DataSource = sAPService.getScriptifyAproovedData();
            DataGridViewStyler.ChangeSPAHeaderUI(dgvSAP);
            dgvSAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
