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
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

public partial class XsltTransformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
		StringBuilder sb = new StringBuilder();
		XmlWriter writer = XmlWriter.Create(sb);
		XPathDocument doc = new XPathDocument(Server.MapPath("~/Xml/MSDN.xml"));
		XslCompiledTransform trans = new XslCompiledTransform();
		trans.Load(Server.MapPath("MSDN.xslt"));
		trans.Transform(doc, null, writer);
		writer.Close();
		this.lblOutput.Text = sb.ToString();
    }
}
