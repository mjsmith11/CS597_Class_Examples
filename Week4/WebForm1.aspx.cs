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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbxSearch_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "Select LastName,FirstName,Major from Students where Major=@m";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            cmd.Parameters.AddWithValue("@m", tbxMajor.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvDisplay.DataSource = dt;
            gvDisplay.DataBind();
        
        }
    }
}