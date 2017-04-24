using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week15
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World " + DateTime.Now.ToLongTimeString();
            //System.Threading.Thread.Sleep(5000);
        }

        protected void btnProgress_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
        }

        protected void updateTimer_Tick(object sender, EventArgs e)
        {
            //lblHello.Text = DateTime.Now.ToLongTimeString();
        }
    }
}