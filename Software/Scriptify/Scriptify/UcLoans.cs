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
    public partial class UcLoans : UserControl
    {
        private Librarian Lib;
        public UcLoans(Librarian librarian)
        {
            InitializeComponent();
            this.Lib = librarian;
        }

        private void UcLoans_Load(object sender, EventArgs e)
        {
            var pending = new PendingLoansService();
            dgvPendingLoans.DataSource = pending.GetAllPendingLoans(Lib.idLibrarians);
            dgvPendingLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
