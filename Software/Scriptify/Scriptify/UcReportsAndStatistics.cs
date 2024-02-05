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

        }

        private void ShowTopUsers()
        {
            List<UserWithCount> topUsers = reportsAndStatisticsService.GetTop10Users(user.idLibrarians);
            dgvTopUsers.DataSource = topUsers;

            int visinaReda = dgvTopUsers.RowTemplate.Height;

            dgvTopUsers.Height = (dgvTopUsers.Rows.Count + 2) * visinaReda;

            //dgvTopUsers.Columns["loans_of_books"].Visible = false;
            //dgvTopUsers.Columns["Reservations"].Visible = false;
            //dgvTopUsers.Columns["user_has_Library_has_Books"].Visible = false;
            //dgvTopUsers.Columns["Books"].Visible = false;
            //dgvTopUsers.Columns["Money"].Visible = false;
            dataGridView.ChangeUsersWithCountHeaderUI(dgvTopUsers);
            dgvTopUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTopUsers.Visible = true;
            labelTopUsers.Visible = true;
            dgvStatistics.Visible = false;
            labelTopBooks.Visible = false;

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

            dataGridView.ChangeBooksHeaderUI(dgvStatistics);
            dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTopUsers.Visible = false;
            labelTopUsers.Visible = false;
            dgvStatistics.Visible = true;
            labelTopBooks.Visible = true;
        }

        private void btnTopBooks_Click(object sender, EventArgs e)
        {
            ShowStatistics();
        }

        private void btnTopUsers_Click(object sender, EventArgs e)
        {
            ShowTopUsers();
        }
    }
}
