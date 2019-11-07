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
    public partial class expenditure : Form
    {
        string type1;
        MySqlConnection cs = new MySqlConnection("data source=localhost;initial catalog=oldv1;user id=root;password=rajeshwari22");
        public expenditure()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string abc, b,y;
            int c, d, t,u;
            cs.Open();
            try
            {

            string str="insert into expenditure(service_name,amount_needed,don_type,username,date) values ('"+this.service_name.Text+"',"+this.amt.Text+",'"+type1+"','"+this.textBox1.Text+"','"+this.date5.Text+"')";
            MySqlCommand cmd = new MySqlCommand(str, cs);
            cmd.ExecuteNonQuery();
            MessageBox.Show("amount debitted suceesfully");
            

            string str2 = "select mid from money where date='"+this.date5.Text+"' and service_name='"+this.service_name.Text+"'";
            MySqlCommand cmd2 = new MySqlCommand(str2, cs);
            MySqlDataReader dr1 = cmd2.ExecuteReader();
            dr1.Read();
            y = dr1[0].ToString();
            dr1.Close();

            u = Int32.Parse(y);
            u = u - 1;


            string str4 = "select total_amt from money where mid="+u+"";
            MySqlCommand cmd4 = new MySqlCommand(str4, cs);
            MySqlDataReader dr4 = cmd4.ExecuteReader();
            dr4.Read();
            abc = dr4[0].ToString();
            dr4.Close();

            b=this.amt.Text;

            c=Int32.Parse(b);
            d = Int32.Parse(abc);

            t = d - c;

            string str3 = "update money set total_amt=" + t + " where date='" + this.date5.Text + "' or service_name='"+this.service_name.Text+"'";
            MySqlCommand cmd3 = new MySqlCommand(str3, cs);
            cmd3.ExecuteNonQuery();
            

            this.label5.Text = abc;
            this.label6.Text = t.ToString();
            
            cs.Close();

        }
        catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
               
        }

        private void expenditure_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oldv1DataSet25.lasts' table. You can move, or remove it, as needed.
            this.lastsTableAdapter.Fill(this.oldv1DataSet25.lasts);
            // TODO: This line of code loads data into the 'oldv1DataSet24.firsts' table. You can move, or remove it, as needed.
            this.firstsTableAdapter.Fill(this.oldv1DataSet24.firsts);
            // TODO: This line of code loads data into the 'oldv1DataSet21.expenditure' table. You can move, or remove it, as needed.
            this.expenditureTableAdapter.Fill(this.oldv1DataSet21.expenditure);
            
         
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type1 = "expenditure";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
