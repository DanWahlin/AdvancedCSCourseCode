using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Xml;
using System.Xml.Schema;

public partial class XmlReaderValidation_aspx : System.Web.UI.Page {
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

		//Define XmlReader settings
		XmlReaderSettings readerSettings = new XmlReaderSettings();
		readerSettings.ValidationType = ValidationType.Schema;
		readerSettings.Schemas = schemaSet;
		readerSettings.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandler);
		
		//Create XmlReader instance
		using (XmlReader reader = XmlReader.Create(xmlPath, readerSettings)) {
			while (reader.Read()) { }
		}
		this.lblOutput.Text = (status) ? "Validation Succeeded!" : "Validation Failed!";
	}

	void ValidationEventHandler(object sender, ValidationEventArgs e) {
		status = false;
	}
}
