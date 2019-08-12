using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;

public partial class SelectNodeInNamespaceDemo : System.Web.UI.Page
{
    public void Page_Load(object sender, EventArgs e)
    {
        XmlElement root = this.GetRoot();
        XmlNamespaceManager ns = new XmlNamespaceManager(root.OwnerDocument.NameTable);
        ns.AddNamespace("dc", "http://purl.org/dc/elements/1.1/");
        XmlNodeList authors = root.SelectNodes("channel/item/dc:creator", ns);
        foreach (XmlNode node in authors)
        {
            if (this.ddAuthors.Items.FindByText(node.InnerText) == null)
            {
                this.ddAuthors.Items.Add(new ListItem(node.InnerText));
            }
        }
    }

    public void ddAuthors_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.phArticles.Controls.Clear();
        XmlElement root = this.GetRoot();
        XmlNamespaceManager ns = new XmlNamespaceManager(root.OwnerDocument.NameTable);
        ns.AddNamespace("dc", "http://purl.org/dc/elements/1.1/");
        XmlNodeList articles = root.SelectNodes("channel/item[dc:creator='" +
            this.ddAuthors.SelectedValue + "']", ns);
        foreach (XmlNode node in articles)
        {
            HyperLink link = new HyperLink();
            link.Text = node.SelectSingleNode("title").InnerText;
            link.NavigateUrl = node.SelectSingleNode("link").InnerText;
            this.phArticles.Controls.Add(link);
            this.phArticles.Controls.Add(new LiteralControl("<br />"));
        }
    }

    private XmlElement GetRoot()
    {
        string xmlPath = Server.MapPath("~/XML/MSDN.xml");
        XmlDocument doc = new XmlDocument();
        doc.Load(xmlPath);
        XmlElement root = doc.DocumentElement;
        return root;
    }
}
