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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "Select distinct State from Students";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                ddlStates.Items.Add(new ListItem(rdr["State"].ToString(), rdr["State"].ToString()));
            }
            rdr.Close();
            conn.Close();

            qry = "SELECT DISTINCT Major from Students";
            cmd = new OleDbCommand(qry, conn);
            conn.Open();
            rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                ddlMajors.Items.Add(new ListItem(rdr["Major"].ToString(), rdr["Major"].ToString()));
            }
            
            rdr.Close();
            conn.Close();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "SELECT LastName,FirstName,Major,State FROM Students WHERE Major=@m and State=@s";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            //its important that these are in the same order  as they are in qry
            cmd.Parameters.AddWithValue("@m", ddlMajors.SelectedValue);
            cmd.Parameters.AddWithValue("@s",ddlStates.SelectedValue);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();

            Response.Write("<table border='1'>");
            while(rdr.Read())
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(rdr["LastName"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(rdr["FirstName"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(rdr["Major"].ToString());
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(rdr["State"].ToString());
                Response.Write("</td>");

                Response.Write("</tr>");
            }
            Response.Write("</table>");

            rdr.Close();
            conn.Close();

        }
    }
}