using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oah_v1
{
    public partial class mpage : Form
    {
        public mpage()
        {
            InitializeComponent();
        }

        private void searchResidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcome_page wp = new welcome_page();
            wp.MdiParent = this;
            wp.Show();
        }

        private void donationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donation ss = new donation();
            ss.MdiParent = this;
            ss.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aboutus ab = new aboutus();
            ab.MdiParent = this;
            ab.Show();
        }

        private void mpage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            welcome_page wp = new welcome_page();
            wp.MdiParent = this;
            wp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
