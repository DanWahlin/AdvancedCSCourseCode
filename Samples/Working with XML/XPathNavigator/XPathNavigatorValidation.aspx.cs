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
using System.Xml.Schema;
using System.IO;

public partial class XPathNavigatorValidation_aspx : System.Web.UI.Page {
	string xmlPath = null;
	string schemaPath = null;

	public void Page_Load(object sender, EventArgs e) {
		xmlPath = Server.MapPath("~/XML/MSDN.xml");
		schemaPath = Server.MapPath("~/Schemas/MSDN.xsd");
		using (StreamReader reader = new StreamReader(xmlPath)) {
			this.txtXml.Text = reader.ReadToEnd();
		}
	}

    public void btnSubmit_Click(object sender, EventArgs e)
    {
		//Load schema used to validate
		XmlSchemaSet schemaSet = new XmlSchemaSet();
		schemaSet.Add(String.Empty, schemaPath);
		schemaSet.Compile();

		//Validate XML using an XPathNavigator's CheckValidity() method
		XPathDocument doc = new XPathDocument(xmlPath);
		XPathNavigator nav = doc.CreateNavigator();
		bool status = nav.CheckValidity(schemaSet, new ValidationEventHandler(nav_ValidationEventHandler));

		this.lblOutput.Text = (status) ? "Validation Succeeded!" : "Validation Failed!";
	}

	void nav_ValidationEventHandler(object sender, ValidationEventArgs e) {
		//Errors could be logged here
	}

}
