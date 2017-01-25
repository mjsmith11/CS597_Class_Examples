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

            //Run the Query

            //Store the results of the query

            //Bind the results to a presentation layer control (GridView)
        }
    }
}