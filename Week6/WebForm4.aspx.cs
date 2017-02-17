using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using DatabaseQueries;

namespace Week6
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["EmployeeId"]==null)
            {
                Response.Redirect("WebFrom3.aspx");
            }
            int employeeId = Int32.Parse(Session["EmployeeId"].ToString());
            DBQueries qry = new DBQueries(ConfigurationManager.ConnectionStrings["Week6CS"].ConnectionString);
            qry.CreateSqlCommand("SELECT * FROM Employees WHERE EmployeeId=@e");
            qry.AddQueryParameter("@e", employeeId);
            dvDetails.DataSource = qry.RunSelectDataAdapterQuery();
            dvDetails.DataBind();

        }
    }
}