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
    public partial class alogin : Form
    {
        public alogin()
        {
            InitializeComponent();
        }

        

        private void expenditureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expenditure ex = new expenditure();
            ex.MdiParent = this;
            ex.Show();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adda ad = new adda();
            ad.MdiParent = this;
            ad.Show();
        }

        private void modifyRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifya md = new modifya();
            md.MdiParent = this;
            md.Show();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletea d = new deletea();
            d.MdiParent = this;
            d.Show();
        }

        private void displayResidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resi_display rd = new resi_display();
            rd.MdiParent = this;
            rd.Show();
        }

        private void displayVolunteerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vol_display vd = new vol_display();
            vd.MdiParent = this;
            vd.Show();
        }

        private void alogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            admin_loginp al = new admin_loginp();
            al.MdiParent = this;
            al.Show();

            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_loginp aa = new admin_loginp();
            aa.MdiParent = this;
            aa.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
