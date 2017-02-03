using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace Week4
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
                string qry = "SELECT SSN,FirstName,LastName FROM Students";
                OleDbCommand cmd = new OleDbCommand(qry,conn);
                conn.Open();
                OleDbDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    //Create a ListItem
                    //Set value property
                    //Set text property
                    //Add ListItem to ddlStudents
                    ddlStudents.Items.Add(new ListItem(rdr["LastName"].ToString() + ", " + rdr["FirstName"],rdr["SSN"].ToString()));
                }
                rdr.Close();
                conn.Close();
            }
        }

        protected void ddlStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "SELECT * FROM Students where SSN=@s";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            cmd.Parameters.AddWithValue("@s", ddlStudents.SelectedValue);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvDisplay.DataSource = dt;
            gvDisplay.DataBind();
            dvDisplay.DataSource = dt;
            dvDisplay.DataBind();
            
        }
    }
}