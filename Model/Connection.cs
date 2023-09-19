using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWPROJECT.Model
{
    public class Connection
    {
        public SqlConnection DBConnect()
        {
            string connetionString = "Data Source=Nimanthi;Initial Catalog=Student;Integrated Security=True";
            SqlConnection connetion = new SqlConnection(connetionString);
            connetion.Open();
            return connetion;
        }
    }
}
