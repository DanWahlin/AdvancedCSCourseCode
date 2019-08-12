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
using System.Text;

public partial class ReadSubTree_aspx : System.Web.UI.Page {
	void Page_Load(object sender, EventArgs e) {
		string xmlPath = Server.MapPath("~/XML/ServerConfig.config");
		using (XmlReader reader = XmlReader.Create(xmlPath)) {
			string serverName = reader.NameTable.Add("Server");
			reader.ReadToDescendant("Server");
			do {
				//Get a subtree reader
				XmlReader subReader = reader.ReadSubtree();
				ReadServerSubTree(subReader);
			} while (reader.ReadToNextSibling("Server"));
		}
	}

	private void ReadServerSubTree(XmlReader subReader) {
		StringBuilder sb = new StringBuilder();
		subReader.Read();
		sb.Append("<b>Server Properties:</b><br />");
		//Walk through Server node's attributes
		while (subReader.MoveToNextAttribute()) {
			sb.Append(subReader.Name);
			sb.Append(" = ");
			sb.Append(subReader.Value);
			sb.Append("<br />");
		}
		subReader.MoveToElement();
		//Move to first Domain node under Server/Domains
		subReader.ReadToDescendant("Domain");
		do {
			sb.Append("<p /><b>Server Domains:</b><br />");
			sb.Append(subReader.ReadElementString());
			sb.Append("<br />");

		} while (subReader.ReadToDescendant("Domain"));
		sb.Append("<hr />");
		subReader.Close();
		this.lblOutput.Text += sb.ToString();
	}
}
