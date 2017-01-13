using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week1Friday
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFahtoCel_Click(object sender, EventArgs e)
        {
            double fah = Double.Parse(tbxFah.Text);
            double cel = (fah - 32) * 5.0 / 9.0;
            tbxResult.Text = cel.ToString();
        }

        protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxState.Text = ddlStates.SelectedValue;
        }
    }
}