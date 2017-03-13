using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
namespace Week10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            nws.ndfdXMLPortTypeClient nws = new nws.ndfdXMLPortTypeClient();
            string weather = nws.NDFDgenByDay(40,-85,DateTime.Today,"5",nws.unitType.e,nws.formatType.??); //Return from webservice call
            XmlDocument forecast = new XmlDocument();
            forecast.LoadXml(weather);
            List<double> max = new List<double>();
            XmlNodeList temperature = forecast.GetElementsByTagName("termperature");
            foreach(XmlNode t in temperature)
            {
                if (t.Attributes["type"].Value.Equals("maximum"))
                {
                    foreach(XmlNode i in t.ChildNodes)
                    {
                        if(i.Name.Equals("value"))
                        {
                            max.Add(Double.Parse(i.InnerText));
                        }
                    }
                }
            }
        }
    }
}