using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonTry;
using LibraryMgtsys;

namespace LibraryMgtsys
{
    public partial class Profile : Form
    {

        readonly SqlConnection conn;
        private string regno1;
        DBConnection db1 = DBConnection.Instance;
        public Profile(string regno1)
        {
            InitializeComponent();
            conn = db1.connect();
            registno.Text = regno1;

            try
            {
                conn.Open();
                SqlCommand cm1 = new SqlCommand("Select UserName , email from LoginTable where reg_no like '" + registno.Text + "'", conn);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cm1);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                foreach (DataRow dr in dt1.Rows)
                {
                    namedisp.Text = dr["UserName"].ToString();
                    emaildisp.Text = dr["email"].ToString();

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
              

            


        }

        private void myiss1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void rgno_Click(object sender, EventArgs e)
        {

        }
    }
}
