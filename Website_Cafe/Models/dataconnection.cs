﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Website_Cafe.Models
{
    public class dataconnection
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string str = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
        public dataconnection()
        {
            cn = new SqlConnection(str);
        }
        public DataTable laydulieu(string query)
        {
            da = new SqlDataAdapter(query, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public void ghidulieu(string query)
        {
            cn.Open();
            cmd = new SqlCommand(query, cn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();
        }
    }
}