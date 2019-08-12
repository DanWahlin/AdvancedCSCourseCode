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
using System.IO;

public partial class XmlWriterSettings_aspx : System.Web.UI.Page {
	public void Page_Load(object sender, EventArgs e) {
	}

	public void btnSubmit_Click(object sender, EventArgs e) {
		XmlWriterSettings ws = new XmlWriterSettings();
		ws.Indent = true;
		ws.CheckCharacters = true;
		ws.NewLineOnAttributes = true;

		StringWriter sw = new StringWriter();
		using (XmlWriter writer = XmlWriter.Create(sw, ws)) {
			writer.WriteStartElement("customers");
			writer.WriteStartElement("customer");
			writer.WriteAttributeString("id", Guid.NewGuid().ToString());
			writer.WriteAttributeString("fname", "John");
			writer.WriteAttributeString("lname", "Doe");
			writer.WriteEndElement();

			writer.WriteStartElement("customer");
			writer.WriteAttributeString("id", Guid.NewGuid().ToString());
			writer.WriteAttributeString("fname", "Jane");
			writer.WriteAttributeString("lname", "Doe");
			writer.WriteEndElement();

			writer.WriteEndElement(); //close customers
		}
		this.txtXml.Text = sw.GetStringBuilder().ToString();
	}

}
