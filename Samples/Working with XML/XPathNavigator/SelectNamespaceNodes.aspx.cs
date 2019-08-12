using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.XPath;

public partial class SelectNamespaceNodes_aspx : System.Web.UI.Page {
	public void Page_Load(object sender, EventArgs e) {
		XPathNavigator nav = this.GetNavigator();
		foreach (XPathNavigator node in nav.Select("channel/item/dc:creator",nav)) {
			if (this.ddAuthors.Items.FindByText(node.Value) == null) {
				this.ddAuthors.Items.Add(new ListItem(node.Value));
			}
		}
		this.ddAuthors.Items.Insert(0,new ListItem("Select One:"));
	}

	public void ddAuthors_SelectedIndexChanged(object sender, EventArgs e) {
		this.phArticles.Controls.Clear();
		XPathNavigator nav = this.GetNavigator();
		//filter on creator node associated with dc namespace prefix
		foreach (XPathNavigator node in nav.Select("channel/item[dc:creator='" + 
			this.ddAuthors.SelectedValue + "']", nav)) {
			HyperLink link = new HyperLink();
			link.Text = node.SelectSingleNode("title").Value;
			link.NavigateUrl = node.SelectSingleNode("title").Value;
			this.phArticles.Controls.Add(link);
			this.phArticles.Controls.Add(new LiteralControl("<br />"));
		}
	}

	private XPathNavigator GetNavigator() {
		string xmlPath = Server.MapPath("~/XML/MSDN.xml");
		XPathDocument doc = new XPathDocument(xmlPath);
		XPathNavigator nav = doc.CreateNavigator();
		nav.MoveToFirstChild();
		return nav;
	}

}
