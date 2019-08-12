using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;
using System.Xml.XPath;


public partial class EditingXml_aspx : System.Web.UI.Page {

	string _XmlPath = null;

	public void Page_Load(object sender, EventArgs e) {
		_XmlPath = Server.MapPath(this.XmlDataSource1.DataFile);
	}

	public void btnAddLink_Click(object sender, EventArgs e) {
		string mode = (ViewState["EditMode"] == null) ? "Insert" : "Edit";
		EditXml(mode, this.lblID.Text);
	}

	public void dlLinks_ItemCommand(object source, DataListCommandEventArgs e) {
		string mode = e.CommandName;
		string id = e.CommandArgument.ToString();
		if (mode == "Delete") {
			EditXml(mode, id);
		}
		else { //Editing
			ViewState["EditMode"] = mode;
			XPathNavigator nav = new XPathDocument(_XmlPath).CreateNavigator();
			nav.MoveToFirstChild();
			XPathNavigator node = nav.SelectSingleNode("link[@id='" + id + "']");
			if (node != null) {
				this.lblID.Text = id;
				this.txtName.Text = node.GetAttribute("name", String.Empty);
				this.txtURL.Text = node.GetAttribute("href", String.Empty);
			}
			else {
				this.lblOutput.Text = "Unable to find node.";
			}
		}
	}

	private void EditXml(string mode, string id) {
		XmlDocument doc = new XmlDocument();
		doc.Load(_XmlPath);
		XPathNavigator editor = doc.CreateNavigator();
		editor.MoveToFirstChild(); //Get to <links> node
		XPathNavigator node = editor.SelectSingleNode("link[@id='" + id + "']");
		if (node != null) {
			//Found node so move to it
			editor.MoveTo(node);
			switch (mode) {
				case "Edit":
					editor.MoveToAttribute("name", String.Empty);
					editor.SetValue(this.txtName.Text);
					editor.MoveToParent();
					editor.MoveToAttribute("href", String.Empty);
					editor.SetValue(this.txtURL.Text);
					break;
				case "Delete":
					editor.DeleteSelf();
					break;
			}
		}
		else {
			//No node found
			if (mode == "Insert") {
				using (XmlWriter writer = editor.AppendChild()) {
					writer.WriteStartElement("link");
					writer.WriteAttributeString("id", Guid.NewGuid().ToString());
					writer.WriteAttributeString("name", this.txtName.Text);
					writer.WriteAttributeString("href", this.txtURL.Text);
					writer.WriteEndElement();
				}
			}
		}
		//Save() will fail if ASPNET account doesn't have write access
		doc.Save(_XmlPath);
		Response.Redirect(Request.Url.ToString());
	}

	private XPathNavigator GetNavigator() {
		XmlDocument doc = new XmlDocument();
		doc.Load(_XmlPath);
		XPathNavigator editor = doc.CreateNavigator();
		return editor;
	}

}
