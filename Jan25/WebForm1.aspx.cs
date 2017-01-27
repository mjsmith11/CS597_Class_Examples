using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//the three below were added manually
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace Jan25
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Grab connection string from web.config

            //Using the above connection string, make a connection to the database
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            //Design SQL query
            string qry = "select LastName,FirstName from Students";
            //Associate the above SQL query with the above connection
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            //Run the Query
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //Store the results of the query
            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds,"StudentNames");

            //Bind the results to a presentation layer control (GridView)
            gvDisplay.DataSource = ds.Tables["StudentNames"];
            gvDisplay.DataBind();
        }
    }
}