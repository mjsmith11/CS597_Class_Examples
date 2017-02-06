using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;

namespace Week5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["Week5CS"].ConnectionString);
            string qry = "INSERT INTO Students (SSN,LastName,FirstName,Major,PhoneNumber) VALUES (@s,@l,@f,@m,@p)";
            OleDbCommand cmd = new OleDbCommand(qry, conn);
            cmd.Parameters.AddWithValue("@s", tbxSSN.Text);
            cmd.Parameters.AddWithValue("@l", tbxLast.Text);
            cmd.Parameters.AddWithValue("@f", tbxFirst.Text);
            cmd.Parameters.AddWithValue("@m", tbxMajor.Text);
            cmd.Parameters.AddWithValue("@p", tbxPhone.Text);
            conn.Open();
            int retVal;
            try
            {
                retVal = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                retVal = -1;
            }
            conn.Close();
            if(retVal == 1)
            {
                lblResult.Text = "Insert query successful";
            }
            else
            {
                lblResult.Text = "Insert query unsuccessful";
            }

        }
    }
}