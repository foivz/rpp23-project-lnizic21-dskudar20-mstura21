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
        public UcReportsAndStatistics(Librarian user)
        {
            InitializeComponent();
            this.user = user;

        }
    }
}
