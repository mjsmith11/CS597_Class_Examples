using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Week6
{
    public class Queries
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Queries()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Week6CS"].ConnectionString);
        }

        public void Connect()
        {
            conn.Open();
        }

        public void Disconnect()
        {
            conn.Close();
        }

        public SqlCommand GetSqlCommand()
        {
            return cmd;
        }

        public void AddQueryParameter(string parameterName, object parameterValue)
        {
            cmd.Parameters.AddWithValue(parameterName, parameterValue);
        }
        public void CreateSqlCommand(string qry)
        {
            cmd = new SqlCommand(qry, conn);
        }

        public DataTable RunSelectDataAdapterQuery()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}