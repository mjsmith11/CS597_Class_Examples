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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
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
            }
        }
    }
}