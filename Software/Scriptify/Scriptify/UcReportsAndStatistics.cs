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
    public partial class UcReportsAndStatistics : UserControl
    {
        private Librarian user = new Librarian();
        private ReportsAndStatisticsService reportsAndStatisticsService;

        public UcReportsAndStatistics(Librarian user)
        {
            InitializeComponent();
            this.user = user;
            reportsAndStatisticsService = new ReportsAndStatisticsService();

        }

        private void UcReportsAndStatistics_Load(object sender, EventArgs e)
        {
            ShowStatistics();

        }
        private void ShowStatistics()
        {
            List<Book> topBooks = reportsAndStatisticsService.GetTopBooks(user.idLibrarians);
            dgvStatistics.DataSource = topBooks;

            int visinaReda = dgvStatistics.RowTemplate.Height;

            dgvStatistics.Height = (dgvStatistics.Rows.Count+2) * visinaReda;

            dgvStatistics.Columns["Users"].Visible = false;
            dgvStatistics.Columns["Library_has_Books"].Visible = false;
            dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
