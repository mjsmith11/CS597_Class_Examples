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

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxState.Text = RadioButtonList1.SelectedValue;
        }

        protected void btnToppings_Click(object sender, EventArgs e)
        {
            //checkbox list only gives first value in the list that is selected in SelectedValue
            //tbxState.Text = cbxlToppings.SelectedValue;
            string displayText = "";
            foreach (ListItem l in cbxlToppings.Items)
            {
                if (l.Selected)
                    displayText += l.Text + " ";
            }
            //    for(int i = 0; i<cbxlToppings.Items.Count; i++)
            //    {
            //        if(cbxlToppings.Items[i].Selected)
            //        {
            //            displayText += cbxlToppings.Items[i].Text+" ";
            //        }
            //    }
           tbxState.Text = displayText;

        }

        protected void btnlbxToppings_Click(object sender, EventArgs e)
        {
            string displayText = "";
            foreach (ListItem l in lbxToppings.Items)
            {
                if (l.Selected)
                    displayText += l.Text + " ";
            }
            tbxState.Text = displayText;
        }
    }
}