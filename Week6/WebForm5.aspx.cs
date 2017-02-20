using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using DatabaseQueries;
using System.Security.Cryptography;
using System.Text;

namespace Week6
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            if(Session["EmployeeId"]==null)
            {
                Response.Redirect("WebForm3.aspx");
            }
            if(Session["UserType"] != null)
            {
                if(Int32.Parse(Session["UserType"].ToString())==0)
                {

                }
                else
                {
                    btnCreate.Enabled = false;
                }
            }
            lblUsernameError.Text = "";
            string usernameTypedByUser = tbxUsername.Text;
            DBQueries qry = new DBQueries(ConfigurationManager.ConnectionStrings["Week6CS"].ConnectionString);
            qry.CreateSqlCommand("SELECT UserId from Employees");
            DataTable dt = qry.RunSelectDataAdapterQuery();
            bool isTaken = false;
            foreach(DataRow dr in dt.Rows)
            {
                if (dr["UserId"].ToString().Equals(usernameTypedByUser))
                {
                    isTaken = true;
                    break;
                }
            }

            if(isTaken)
            {
                lblUsernameError.Text = "Username Exists";
                return;
            }

            string password0 = tbxPassword0.Text;
            string password1 = tbxPassword1.Text;

            if (!password0.Equals(password1))
            {
                lblUsernameError.Text = "Passwords do not Match";
                return;
            }

            if(password0.Length < 8)
            {
                lblUsernameError.Text = "Password must be 8 characters long";
                return;
            }
            qry.CreateSqlCommand("Select MAX(EmployeeId) as E FROM Employees");
            DataTable temp = qry.RunSelectDataAdapterQuery();
            int nextEmployeeId = Int32.Parse(temp.Rows[0]["E"].ToString());
            nextEmployeeId++;
            qry.CreateSqlCommand("INSERT INTO Employees (EmployeeId, LastName, FirstName, Department, Salary, Performance, Location, UserId, Password) VALUES (@e, @l, @f, @d, @s, @p, @loc, @u, @pass)");
            qry.AddQueryParameter("@e", nextEmployeeId);
            qry.AddQueryParameter("@l", "Pollard");
            qry.AddQueryParameter("@f", "Carol");
            qry.AddQueryParameter("@d", "IT");
            qry.AddQueryParameter("@s", 70000);
            qry.AddQueryParameter("@p", "Good");
            qry.AddQueryParameter("@loc", "Chicago");
            qry.AddQueryParameter("@u", usernameTypedByUser);

            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password0));
            byte[] result = sha1.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2")); //x2 is for 2 hex because we are sending in a byte at a time
            }
            qry.AddQueryParameter("@pass", strBuilder.ToString());

            qry.Connect();
            qry.GetSqlCommand().ExecuteNonQuery();
            qry.Disconnect();
        }
    }
}