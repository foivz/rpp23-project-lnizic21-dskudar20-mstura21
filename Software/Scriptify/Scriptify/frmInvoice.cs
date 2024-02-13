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
        public frmInvoice(Sanction sanction)
        {
            InitializeComponent();

            this.sanction = sanction;
        }
    }
}
