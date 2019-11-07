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
    public partial class donation : Form
    {
        string type;
        MySqlConnection cs = new MySqlConnection("data source=localhost;initial catalog=oldv1;user id=root;password=rajeshwari22");
        public donation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int table_amt,final_amt,dont_amt,u;
            string temp,y;
            
            cs.Open();
            try
            {
                string str = "insert into donation(name,address,mobno,amount,donation_type,don_type,username,date) values('" + this.name.Text + "','" + this.address.Text + "','" + this.mobno.Text + "'," + this.amount.Text + ",'" + this.others.Text + "','" + type + "','" + this.textBox1.Text + "','" + this.date5.Text + "')";
                MySqlCommand cmd = new MySqlCommand(str, cs);
                cmd.ExecuteNonQuery();

                string str3 = "update money set total_amt=0 where name='" + this.name.Text + "'";
                MySqlCommand cmd3 = new MySqlCommand(str3, cs);
                cmd3.ExecuteNonQuery();


                string str2 = "select mid from money where date='" + this.date5.Text + "' and name='" + this.name.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(str2, cs);
                MySqlDataReader dr1 = cmd2.ExecuteReader();
                dr1.Read();
                y = dr1[0].ToString();
                dr1.Close();

                u = Int32.Parse(y);
                u = u - 1;

                string str1 = "select total_amt from money where mid=" + u + "";
                MySqlCommand cmd1 = new MySqlCommand(str1, cs);
                MySqlDataReader dr = cmd1.ExecuteReader();
                dr.Read();
                temp = dr[0].ToString();
                dr.Close();


                table_amt = Int32.Parse(temp);
                dont_amt = Int32.Parse(this.amount.Text);

                final_amt = table_amt + dont_amt;

                string str4 = "update money set total_amt=" + final_amt + " where date='" + this.date5.Text + "' or name='" + this.name.Text + "'";
                MySqlCommand cmd4 = new MySqlCommand(str4, cs);
                cmd4.ExecuteNonQuery();


                this.label4.Text = final_amt.ToString();
                MessageBox.Show("Amount Donated sucessfully");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            cs.Close();

        }

        private void donation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oldv1DataSet13.donation' table. You can move, or remove it, as needed.
            this.donationTableAdapter.Fill(this.oldv1DataSet13.donation);

            this.WindowState = FormWindowState.Maximized;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = "donation";
        }


        
        private void mobv(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("please enter valid no.");
            }
        }
        
        
    }
}
