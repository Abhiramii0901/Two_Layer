using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Two_Layer
{
    public class Concncls
    {
        SqlConnection con;
        SqlCommand cmd;
        public Concncls()
        {
            con = new SqlConnection(@"server=DESKTOP-H686DSG\SQLEXPRESS;database=ExamDB;Integrated security=true");
        }
        public int fn_nonqry(string qry)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(qry, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string fn_sclar(string qry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(qry, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public SqlDataReader fn_datared(string qry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}