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
namespace LibraryMgtsys
{
    public partial class Register : Form
    {
        readonly SqlConnection conn;
        
        DBConnection db2 = DBConnection.Instance;
        public Register()
        {
            InitializeComponent();
            conn = db2.connect();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pwdtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rgtxt.Text==""|| nametxt.Text==""|| emailtxt.Text==""|| pwdtxt.Text=="")
            {
                MessageBox.Show("Information are missing");

            }
            else 
            {
                try
                {
                    conn.Open();
                    SqlCommand cm = new SqlCommand("insert into LoginTable values ('"+rgtxt.Text+"', '"+nametxt.Text+"','"+emailtxt.Text+"','"+pwdtxt.Text+ "')", conn);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Registered");
                    conn.Close();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }

                Login r = new Login();  
                this.Hide();
                r.Show();
               
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login lo = new Login();
            lo.Show();
        }
    }
}
