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

        private void dgvStatistics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowStatistics();
        }

        private void ShowStatistics()
        {
            dgvStatistics.DataSource = reportsAndStatisticsService.GetTopBooks(user.idLibrarians);
        }
    }
}
