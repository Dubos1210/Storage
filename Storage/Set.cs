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
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
        }

        private void Set_Load(object sender, EventArgs e)
        {
            askpasswdchk.Checked = Properties.Settings.Default.AskPassword;
            localserverchk.Checked = Properties.Settings.Default.LocalServer;
            iptxt.Text = Properties.Settings.Default.ServerIP;
            dbtxt.Text = Properties.Settings.Default.MySQLDatabase;
            usertxt.Text = Properties.Settings.Default.MySQLUser;
            passwordtxt.Text = Properties.Settings.Default.MySQLPassword;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AskPassword = askpasswdchk.Checked;
            Properties.Settings.Default.LocalServer = localserverchk.Checked;
            Properties.Settings.Default.ServerIP = iptxt.Text;
            Properties.Settings.Default.MySQLDatabase = dbtxt.Text;
            Properties.Settings.Default.MySQLUser = usertxt.Text;
            Properties.Settings.Default.MySQLPassword = passwordtxt.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void localserverchk_CheckedChanged(object sender, EventArgs e)
        {
            iptxt.Enabled = !localserverchk.Checked;
            if (localserverchk.Checked == true) {
                iptxt.Text = "127.0.0.1";
            }
        }
    }
}
