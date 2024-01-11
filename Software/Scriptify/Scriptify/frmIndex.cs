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
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
             
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            UcLoans ucLoans = new UcLoans();
            panelControls.Controls.Add(ucLoans);
        }

        private void btnCatalogOfBooks_Click(object sender, EventArgs e)
        {

        }
    }
}
