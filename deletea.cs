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
    public partial class deletea : Form
    {
        MySqlConnection cs = new MySqlConnection("data source=localhost;initial catalog=oldv1;user id=root;password=rajeshwari22");
        public deletea()
        {
            InitializeComponent();
        }

        private void deletea_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            cs.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select username from resident", cs);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.del.Items.Add(dr[0].ToString());

                }
                dr.Close();
            }
            catch (MySqlException ex)
            { MessageBox.Show(ex.Message); }
            cs.Close();

            cs.Open();
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("select username from manager", cs);
                MySqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    this.comboBox1.Items.Add(dr1[0].ToString());

                }
                dr1.Close();
            }
            catch (MySqlException ex)
            { MessageBox.Show(ex.Message); }
            cs.Close();


            cs.Open();
            try
            {
                MySqlCommand cmd2 = new MySqlCommand("select username from worker", cs);
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    this.del2.Items.Add(dr2[0].ToString());

                }
                dr2.Close();
            }
            catch (MySqlException ex)
            { MessageBox.Show(ex.Message); }
            cs.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cs.Open();
                string str = "delete from resident where username='" + this.del.Text + "'";
                MessageBox.Show(str);

                MySqlCommand cmd3 = new MySqlCommand(str, cs);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("deleted");
                cs.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cs.Open();

                string str = "delete from worker where username='" + this.del2.Text + "'";
                MessageBox.Show(str);

                MySqlCommand cmd4 = new MySqlCommand(str, cs);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("deleted");
                cs.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cs.Open();
                string str = "delete from manager where username='" + this.comboBox1.Text + "'";
                MessageBox.Show(str);

                MySqlCommand cmd5 = new MySqlCommand(str, cs);
                cmd5.ExecuteNonQuery();
                MessageBox.Show("deleted");
                cs.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

       
        
    }
}
