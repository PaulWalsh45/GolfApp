using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class DAO
    {
        public SqlConnection con;
       

        public DAO()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["GolfSociety"].ConnectionString);
        }

        public SqlConnection OpenDbConnection()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }

        public void CloseDbConnnection()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        
    }
}
