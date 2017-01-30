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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
                string qry = "SELECT DISTINCT State from Students";
                OleDbCommand cmd = new OleDbCommand(qry, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ddlState.DataSource = dt;
                ddlState.DataTextField = "State";
                ddlState.DataValueField = "State";
                ddlState.DataBind();
            }

        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "Select * from Students where State=@s";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            cmd.Parameters.AddWithValue("@s", ddlState.SelectedValue);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvDisplay.DataSource = dt;
            gvDisplay.DataBind();
        }
    }
}