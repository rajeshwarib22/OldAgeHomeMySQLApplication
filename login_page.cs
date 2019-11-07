using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oah_v1
{
    public partial class login_page : Form
    {
        MySqlConnection cs = new MySqlConnection("data source=localhost;initial catalog=oldv1;user id=root;password=rajeshwari22");
        public login_page()
        {
            InitializeComponent();
        }

        private void login_page_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            cs.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select username from resident",cs);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    usercombo.Items.Add(dr[0].ToString());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            { MessageBox.Show(ex.Message); }
            cs.Close();


            cs.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select username from volunteer", cs);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    volcombo.Items.Add(dr[0].ToString());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            { MessageBox.Show(ex.Message); }
            cs.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("login successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cs.Open();
                string str = "select rid,fname,mname,lname,dob,gender,address,joindate,roomno from resident where username='" + this.usercombo.Text + "'";
                MySqlCommand cmd = new MySqlCommand(str, cs);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                this.rid.Text = dr[0].ToString();
                this.fname4.Text = dr[1].ToString();
                this.mname4.Text = dr[2].ToString();
                this.lname4.Text = dr[3].ToString();
                this.dob4.Text = dr[4].ToString();
                this.gender4.Text = dr[5].ToString();
                this.address4.Text = dr[6].ToString();
                this.joindate4.Text = dr[7].ToString();
                this.roomno.Text = dr[8].ToString();
                dr.Close();
                cs.Close();
            }
            catch (MySqlException ex) { MessageBox.Show(ex.Message); }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // mpage mp = new mpage();
           // mp.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login_page lp2 = new login_page();
            lp2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                cs.Open();
                string str = "select vid,fname,mname,lname,dob,gender,worktype,designation,salary from volunteer where username='" + this.volcombo.Text + "'";
                MySqlCommand cmd = new MySqlCommand(str, cs);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                this.vid1.Text = dr[0].ToString();
                this.fname5.Text = dr[1].ToString();
                this.mname5.Text = dr[2].ToString();
                this.lname5.Text = dr[3].ToString();
                this.dob5.Text = dr[4].ToString();
                this.gender5.Text = dr[5].ToString();

                this.worktype5.Text = dr[6].ToString();
                this.designation.Text = dr[7].ToString();
                this.sal4.Text = dr[8].ToString();
                dr.Close();
                cs.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
