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
using System.Xml.Schema;
using System.IO;

public partial class XmlDocumentValidation : System.Web.UI.Page {
	string xmlPath = null;
	string schemaPath = null;
	bool status = true;

	public void Page_Load(object sender, EventArgs e) {
		xmlPath = Server.MapPath("~/XML/MSDN.xml");
		schemaPath = Server.MapPath("~/Schemas/MSDN.xsd");
		using (StreamReader reader = new StreamReader(xmlPath)) {
			this.txtXml.Text = reader.ReadToEnd();
		}
	}

	public void btnSubmit_Click(object sender, EventArgs e) {
		//Load schema used to validate
		XmlSchemaSet schemaSet = new XmlSchemaSet();
		schemaSet.Add(String.Empty, schemaPath);
		schemaSet.Compile();

		//Validate XML using an XmlDocuments's Validate() method
		XmlDocument doc = new XmlDocument();
		doc.Load(xmlPath);
		doc.Schemas = schemaSet;
		doc.Validate(new ValidationEventHandler(doc_ValidationEventHandler));
		this.lblOutput.Text = (status) ? "Validation Succeeded!" : "Validation Failed!";
	}

	void doc_ValidationEventHandler(object sender, ValidationEventArgs e) {
		//Errors could be logged or written out to the application here
		status = false;
	}

}