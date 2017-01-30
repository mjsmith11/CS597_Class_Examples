using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;

namespace Week4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "Select LastName,FirstName from Students";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Response.Write(rdr["LastName"].ToString() + ", "+rdr["FirstName"]+"<br/>");
            }

            rdr.Close();
            conn.Close();
        }
    }
}