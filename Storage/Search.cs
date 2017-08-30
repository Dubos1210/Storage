using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        
        public string[] col = { "title", "comment", "area", "container" };

        private void Search_Load(object sender, EventArgs e)
        {
        }

        public string[] searchquery() {
            string[] ret = { "", "" };
            ret[0] = searchtxt.Text;
            if (searchin.SelectedIndex >= 0 && searchin.SelectedIndex < 2) {
                ret[1] = col[searchin.SelectedIndex];
            }
            else {
                ret[1] = "title";
            }
            return ret;
        }

        public void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
