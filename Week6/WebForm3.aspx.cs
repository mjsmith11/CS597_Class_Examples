using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using DatabaseQueries;
using System.Data.SqlClient;
using System.Data;

namespace Week6
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int employeeId = -1;
            string passwordFromDatabase;
            DBQueries qry = new DBQueries(ConfigurationManager.ConnectionStrings["Week6CS"].ConnectionString);
            qry.CreateSqlCommand("SELECT Password,EmployeeId FROM Employees WHERE Username = @u");
            qry.AddQueryParameter("@u", tbxUserId.Text);
            qry.Connect();
            SqlDataReader rdr = qry.GetSqlCommand().ExecuteReader();
            while(rdr.Read())
            {
                passwordFromDatabase = rdr["Password"].ToString();
                employeeId = Int32.Parse(rdr["EmployeeId"].ToString());
            }
            string passwordFromUser = tbxPassword.Text;

            rdr.Close();
            qry.Disconnect();


            Session["EmployeeId"] = employeeId;
            Response.Redirect("WebForm4.aspx");
        }
    }
}