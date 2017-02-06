using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace Week5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["Week5CS"].ConnectionString);
                string qry = "SELECT SSN,FirstName,LastName FROM Students";
                OleDbCommand cmd = new OleDbCommand(qry, conn);
                conn.Open();
                OleDbDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //Create a ListItem
                    //Set value property
                    //Set text property
                    //Add ListItem to ddlStudents
                    ddlStudent.Items.Add(new ListItem(rdr["LastName"].ToString() + ", " + rdr["FirstName"], rdr["SSN"].ToString()));
                }
                rdr.Close();
                conn.Close();
            }
        }

        protected void ddlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SSN"] = ddlStudent.SelectedValue; //Session starts as an empty dictionary
            Response.Redirect("WebForm3.aspx");
        }
    }
}