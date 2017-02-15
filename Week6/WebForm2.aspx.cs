using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Queries qry = new Queries();
            //qry.CreateSqlCommand("SELECT * FROM EMPLOYEES");
            //gvDisplay.DataSource = qry.RunSelectDataAdapterQuery();
            //gvDisplay.DataBind();
            Queries qry = new Queries();
            qry.CreateSqlCommand("Update Employees Set Salary=@s WHERE EmployeeId=@e");
            qry.AddQueryParameter("@s", 90000);
            qry.AddQueryParameter("@e", 3);
            qry.Connect();
            qry.GetSqlCommand().ExecuteNonQuery();
            qry.Disconnect();
        }
    }
}