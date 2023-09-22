using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonTry;

namespace LibraryMgtsys
{
    public partial class Login : Form
    {
        readonly SqlConnection conn;
        DBConnection dbc = DBConnection.Instance;
        public Login()
        {
            InitializeComponent();
            conn = dbc.connect();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from LoginTable where reg_no ='"+rgtxt.Text+"' and Pwd = '"+pwdtxt.Text+"'",conn);
            SqlDataAdapter  adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                String regno = (string)ds.Tables[0].Rows[0]["reg_no"];
                //Pass.uname = rgtxt.Text;
                this.Hide();
                User u = new User(regno);
                u.Show();
            }
            else {
                MessageBox.Show("Wrong USERNAME or PASSWORD","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
            
            
        }

        private void about_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Register r = new Register();
            r.Show();
        }
    }
}
