using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;
using System.Collections;
using kaleido.Web.UI.Components;

namespace kaleido.Web.UI.Controls
{
    public partial class SlideShowNew : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
         {
             ArrayList bilder = new ArrayList();
             int indx = 0;
             bilder = BasePage.HamtaBild(Server, "~/Data/Sites/1/media/SlideShow/");
             foreach (string url in bilder)
             {
                 indx++;
                 if (indx == 1)
                     Image1.ImageUrl = ResolveUrl(url);
                 else if (indx == 2)
                     Image2.ImageUrl = ResolveUrl(url);
                 else if (indx == 3)
                     Image3.ImageUrl = ResolveUrl(url);
                 else if (indx == 4)
                     Image4.ImageUrl = ResolveUrl(url);
                 else if (indx == 5)
                     Image5.ImageUrl = ResolveUrl(url);
                 else if (indx == 6)
                     Image6.ImageUrl = ResolveUrl(url);
                 else if (indx == 7)
                     Image7.ImageUrl = ResolveUrl(url);
                 else if (indx == 8)
                     Image8.ImageUrl = ResolveUrl(url);
                 else if (indx == 9)
                     Image9.ImageUrl = ResolveUrl(url);
                 else if (indx == 10)
                     Image10.ImageUrl = ResolveUrl(url);
             }
             for (int i = indx + 1; i < 11; i++)
             {
                 if (i == 1)
                     Image1.Visible = false;
                 else if (i == 2)
                     Image2.Visible = false;
                 else if (i == 3)
                     Image3.Visible = false;
                 else if (i == 4)
                     Image4.Visible = false;
                 else if (i == 5)
                     Image5.Visible = false;
                 else if (i == 6)
                     Image6.Visible = false;
                 else if (i == 7)
                     Image7.Visible = false;
                 else if (i == 8)
                     Image8.Visible = false;
                 else if (i == 9)
                     Image9.Visible = false;
                 else if (i == 10)
                     Image10.Visible = false;
             }
             String URLString = "http://www.vidiofsweden.se/uploads/start/links/start.xml";
             //String URLString = "http://localhost:60047/uploads/start/links/start.xml";
             XmlTextReader reader = new XmlTextReader(URLString);
             //Response.Write("här 1");
             if (reader != null)
             {
                 indx = 0;
                 //Response.Write("här 2");
                 while (reader.Read())
                 {
                     //Response.Write("här 3");
                     if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Image"))
                     {
                         if (reader.HasAttributes)
                         {
                             //Response.Write(reader.GetAttribute("Link"));
                             indx++;
                             if (indx == 1)
                                 Image1.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 2)
                                 Image2.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 3)
                                 Image3.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 4)
                                 Image4.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 5)
                                 Image5.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 6)
                                 Image6.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 7)
                                 Image7.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 8)
                                 Image8.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 9)
                                 Image9.NavigateUrl = reader.GetAttribute("Link");
                             else if (indx == 10)
                                 Image10.NavigateUrl = reader.GetAttribute("Link");
                         }
                     }
                 }
             }
         }
        }
    }
}