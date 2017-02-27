using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
namespace Week8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument news = new XmlDocument();
            news.Load("http://rss.cnn.com/rss/cnn_topstories.rss");
            //news.Load("http://www.espn.com/espn/rss/news");
            XmlNodeList stories = news.GetElementsByTagName("item");
            foreach(XmlNode s in stories)
            {
                string title = "";
                string link = "";

                //Response.Write(s.ChildNodes[0].InnerText + "<br/>");
                //Response.Write(s.ChildNodes.Count+"<br/>");
                foreach(XmlNode i in s.ChildNodes)
                {
                    //Response.Write(i.Name+"&nbsp");
                    if(i.Name.Equals("title"))
                    {
                        title = i.InnerText;
                    }
                    else if(i.Name.Equals("link"))
                    {
                        link = i.InnerText;
                    }
                    else if(i.Name.Equals("guid"))
                    {
                       // Response.Write(i.Attributes["isPermaLink"].Value);
                    }
                    else if(i.Name.Equals("media:group"))
                    {
                        //Response.Write(i.ChildNodes.Count);
                        foreach(XmlNode j in i.ChildNodes)
                        {
                            if(j.Name.Equals("media:content"))
                            {
                                if(j.Attributes["medium"].Value.Equals("image"))
                                {
                                    string url = j.Attributes["url"].Value;
                                    Response.Write("<img src ='" + url + "'/>");
                                }
                                Response.Write("<br/>");
                            }
                        }
                    }
                }
                //Response.Write("<a href='" + link + "'>" + title + "</a>");
                Response.Write("<br/>");
            }
            //Response.Write(stories.Count);
        }
    }
}