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
using System.Security.Cryptography;
using System.Text;

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
            string passwordFromDatabase = "";
            DBQueries qry = new DBQueries(ConfigurationManager.ConnectionStrings["Week6CS"].ConnectionString);
            qry.CreateSqlCommand("SELECT Password,EmployeeId FROM Employees WHERE UserId = @u");
            qry.AddQueryParameter("@u", tbxUserId.Text);
            qry.Connect();
            SqlDataReader rdr = qry.GetSqlCommand().ExecuteReader();
            while(rdr.Read())
            {
                passwordFromDatabase = rdr["Password"].ToString();
                employeeId = Int32.Parse(rdr["EmployeeId"].ToString());
            }

            rdr.Close();
            qry.Disconnect();

            string passwordFromUser = tbxPassword.Text;

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passwordFromUser));
            byte[] result = sha1.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2")); //x2 is for 2 hex because we are sending in a byte at a time
            }

            string hashedPasswordFromUser = strBuilder.ToString();

            if (hashedPasswordFromUser.Equals(passwordFromDatabase))
            {
                Session["EmployeeId"] = employeeId;
                Response.Redirect("WebForm4.aspx");
            }
        }
    }
}