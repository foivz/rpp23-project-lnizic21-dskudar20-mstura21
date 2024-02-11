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
using System.Windows.Forms.DataVisualization.Charting;

namespace Scriptify
{
    public partial class UcReportsAndStatistics : UserControl
    {
        private Librarian user = new Librarian();
        private ReportsAndStatisticsService reportsAndStatisticsService;
        private DataGridViewStyler dataGridView = new DataGridViewStyler();

        public UcReportsAndStatistics(Librarian user)
        {
            InitializeComponent();
            this.user = user;
            reportsAndStatisticsService = new ReportsAndStatisticsService();

        }

        private void UcReportsAndStatistics_Load(object sender, EventArgs e)
        {
            dgvTopUsers.Visible = false;
            labelTopUsers.Visible = false;
            dgvStatistics.Visible = false;
            labelTopBooks.Visible = false;
            chActivitiy.Visible = false;

        }

        private void ShowTopUsers()
        {
            List<UserWithCount> topUsers = reportsAndStatisticsService.GetTop10Users(user.idLibrarians);
            dgvTopUsers.DataSource = topUsers;

            int visinaReda = dgvTopUsers.RowTemplate.Height;

            dgvTopUsers.Height = (dgvTopUsers.Rows.Count + 2) * visinaReda;

            dgvTopUsers.Columns["password"].Visible = false;
            dgvTopUsers.Columns["Money"].Visible = false;
            dataGridView.ChangeUsersWithCountHeaderUI(dgvTopUsers);
            dgvTopUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTopUsers.Visible = true;
            labelTopUsers.Visible = true;
            dgvStatistics.Visible = false;
            labelTopBooks.Visible = false;
            chActivitiy.Visible = false;

        }

        private void ShowStatistics()
        {
            List<BookWithCount> topBooks = reportsAndStatisticsService.GetTop10Books(user.idLibrarians);
            dgvStatistics.DataSource = topBooks;

            int visinaReda = dgvStatistics.RowTemplate.Height;

            dgvStatistics.Height = (dgvStatistics.Rows.Count+2) * visinaReda;

            //dgvStatistics.Columns["Users"].Visible = false;
            //dgvStatistics.Columns["Library_has_Books"].Visible = false;
            //dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.ChangeBooksWithCountHeaderUI(dgvStatistics);
            dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTopUsers.Visible = false;
            labelTopUsers.Visible = false;
            dgvStatistics.Visible = true;
            labelTopBooks.Visible = true;
            chActivitiy.Visible = false;
        }

        private void btnTopBooks_Click(object sender, EventArgs e)
        {
            ShowStatistics();
        }

        private void btnTopUsers_Click(object sender, EventArgs e)
        {
            ShowTopUsers();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ShopActivityChart();
        }

        private void ShopActivityChart()
        {
            dgvStatistics.Visible = false;
            labelTopBooks.Visible = false;
            dgvTopUsers.Visible = false;
            labelTopUsers.Visible = false;
            chActivitiy.Visible = true;

            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddMonths(-1);

            var loansInLastMonth = reportsAndStatisticsService.GetChartDatas(startDate, endDate);

            chActivitiy.Series.Clear();
            chActivitiy.ChartAreas[0].AxisX.Interval = 1;

            chActivitiy.ChartAreas[0].AxisX.Title = "Date";
            chActivitiy.ChartAreas[0].AxisY.Title = "Number of loans";
            chActivitiy.BackColor = Color.LightGray;
            chActivitiy.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.Black;
            chActivitiy.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.Black;

            Series series = new Series("Loans");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Blue;

            foreach (var item in loansInLastMonth)
            {
                series.Points.AddXY(item.Date, item.Count);
            }

            chActivitiy.Series.Add(series);

        }
    }
}
