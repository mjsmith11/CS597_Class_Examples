using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;


namespace Week4
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
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
                    ddlStudents.Items.Add(new ListItem(rdr["LastName"].ToString() + ", " + rdr["FirstName"], rdr["SSN"].ToString()));
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
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "UPDATE Students SET Major=@m where SSN=@s";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            cmd.Parameters.AddWithValue("@m", ddlMajors.SelectedValue);
            cmd.Parameters.AddWithValue("@s", ddlStudents.SelectedValue);
            conn.Open();
            int retVal = cmd.ExecuteNonQuery();
            conn.Close();
            if(retVal==1)
            {
                lblDisplay.Text = "Update was successful";
            }
            else
            {
                lblDisplay.Text = "Update was not successful";
            }
        }

        protected void ddlStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "SELECT Major FROM Students where SSN=@s";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            cmd.Parameters.AddWithValue("@s", ddlStudents.SelectedValue);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //Create a ListItem
                //Set value property
                //Set text property
                //Add ListItem to ddlStudents
                ddlMajors.SelectedValue = rdr["Major"].ToString();
            }
            rdr.Close();
            conn.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "DELETE FROM Students WHERE where SSN=@s";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            cmd.Parameters.AddWithValue("@s", ddlStudents.SelectedValue);
            conn.Open();
            int retVal = cmd.ExecuteNonQuery();
            conn.Close();
            if (retVal == 1)
            {
                lblDisplay.Text = "Delete was successful";
                ddlStudents.Items.RemoveAt(ddlStudents.SelectedIndex);
            }
            else
            {
                lblDisplay.Text = "Delete was not successful";
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["StudentsAccessDB"].ConnectionString);
            string qry = "INSERT INTO Students (SSN,LastName,FirstName,Major,PhoneNumber) VALUES('123-45-6789','Alice','Smith','Business','7655550000')";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            conn.Open();
            int retVal = cmd.ExecuteNonQuery();
            conn.Close();
            if (retVal == 1)
            {
                lblDisplay.Text = "Insert was successful";
            }
            else
            {
                lblDisplay.Text = "Insert was not successful";
            }
        }
    }
}