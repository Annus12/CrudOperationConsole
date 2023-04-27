using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           // DataTable dt = new DataTable();

            // Get The Connection Form App.config
            //make sure the connection string name is the same with app.config

            //string constr = ConfigurationManager.ConnectionStrings["DB_ATMEntities"].ConnectionString;
            //string sqlquery = @"select * from USR_INFO";

            //Create sql Connection
            //This Code is only for Datatable


            //SqlConnection con = new SqlConnection(constr);
            //SqlCommand cmd = new SqlCommand(sqlquery, con);
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
              
            //// This Is For Get Some in Table
            ////string Pin = dt.Rows[0]["Pin"].ToString();

            //con.Close();
            //da.Dispose();



            //This Code For Insert Update And Delete Query
            //SqlConnection con = new SqlConnection(constr);
            //SqlCommand cmd = new SqlCommand(sqlquery, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
    }
}
