﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //tbxName.Text = "Hello World";
        }

        protected void btnHello_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            tbxName.Text = "Hello " + name;
        }
    }
}
// making a change to try gitkraken