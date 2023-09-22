using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SingletonTry;

namespace LibraryMgtsys
{
    public partial class User : Form
    {
        readonly SqlConnection conn;
        private string regno;
        DBConnection db = DBConnection.Instance;
        
        public User(string regno)
        {
            InitializeComponent();
            conn = db.connect();
            rgtext.Text = regno;
            conn.Open();

            SqlCommand cm1 = new SqlCommand("Select UserName , email from LoginTable where reg_no like '" + regno + "'", conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cm1);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                namedisp.Text = dr["UserName"].ToString();
                emaildisp.Text = dr["email"].ToString();

            }


            SqlCommand cm = new SqlCommand("select BookName from UserBooks where reg_no like '" + regno + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();

        }

        private void logbtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cm = new SqlCommand("select distinct BookName from UserBooks where BookName like '" + searchbox.Text + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string regno1 = rgtext.Text;
            this.Hide();
            Profile p = new Profile(regno1);
            p.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cm = new SqlCommand("update LoginTable set UserName = '"+ namedisp.Text + "' , email = '"+ emaildisp.Text + "' where reg_no = '"+rgtext.Text+"'", conn);
                cm.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated!");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
