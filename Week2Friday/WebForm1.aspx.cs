using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week2Friday
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if the page is loading for the first time
                ListItem qa = new ListItem("QA", "30");
                ddlPayRate.Items.Add(qa);
                ListItem dev = new ListItem("Developer", "35");
                ListItem pm = new ListItem("PM", "45");
                ddlPayRate.Items.Add(dev);
                ddlPayRate.Items.Add(pm);
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            tbxAnswer.Text = Convert.ToString(Double.Parse(tbxHours.Text) * Double.Parse(ddlPayRate.SelectedValue));
        }
    }
}