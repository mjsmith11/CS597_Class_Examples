using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace Week4
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            String qry = "Update Students set Major = 'Engineering' where Major = 'Business'";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            conn.Open();
            int retVal = cmd.ExecuteNonQuery();
            Response.Write(retVal + " rows were updated");
            conn.Close();
        }
    }
}