using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week5
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SSN"] != null)
            {
                string ssn = Session["SSN"].ToString();
                Response.Write(ssn);
            }
            else
            {
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}