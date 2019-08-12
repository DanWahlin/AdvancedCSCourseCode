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
using System.IO;

public partial class XmlReader_ParsingRss : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		//Create XmlWriter to generate RSS data as HTML
		StringWriter sw = new StringWriter();
		XmlWriterSettings ws = new XmlWriterSettings();
		ws.Indent = true;
		ws.OmitXmlDeclaration = true;
		ws.Encoding = System.Text.Encoding.UTF8;
		using (XmlWriter writer = XmlWriter.Create(sw, ws)) {
			writer.WriteStartElement("ul");
			string xmlPath = Server.MapPath("~/XML/MSDN.xml");
			using (XmlReader reader = XmlReader.Create(xmlPath)) {
				reader.ReadToDescendant("item");
				//Read each <item> node in the RSS document
				do {
					ReadSubTree(reader.ReadSubtree(), writer);
				} while (reader.ReadToNextSibling("item"));
			}
			writer.WriteEndElement();
		}
		this.lblOutput.Text = sw.ToString();
	}

	//Read child nodes of <item> in RSS document
	private void ReadSubTree(XmlReader subReader, XmlWriter writer) {
		subReader.Read();
		string link = null;
		string title = null;
		while (subReader.Read()) {
			if (subReader.Name == "title") {
				title = subReader.ReadElementString();
			}
			if (subReader.Name == "link") {
				link = subReader.ReadElementString();
			}
		}
		//Write out title and link node values to XmlWriter
		writer.WriteStartElement("li");
			writer.WriteStartElement("a");
				writer.WriteAttributeString("href", link);
				writer.WriteString(title);
			writer.WriteEndElement(); //close <a>
		writer.WriteEndElement(); //close <li>
		subReader.Close();
	}
}
