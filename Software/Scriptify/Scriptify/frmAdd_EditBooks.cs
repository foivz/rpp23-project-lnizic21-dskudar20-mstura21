using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scriptify {
    public enum Action {
        Add,
        Edit
    };
    public partial class frmAdd_EditBooks : Form {
        private Action FormAction;
        private int LibraryId;
        public frmAdd_EditBooks(Action action,int id) {
            InitializeComponent();
            FormAction = action;
            LibraryId = id;
        }

        private void frmAdd_EditBooks_Load(object sender, EventArgs e) {
            if(FormAction == Action.Add) {
                txtTitle.Text = "Add Book";
            } else if(FormAction == Action.Edit) {
                txtTitle.Text = "Edit Book";
            }
        }
    }
}
