using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Xml.XPath;

namespace XPathNavigatorDemo {

	public partial class XPathNavigatorSimple : System.Web.UI.Page	{
	
		private void Page_Load(object sender, System.EventArgs e) {
			string xmlPath = Server.MapPath("~/XML/customers.xml");
			//Load XML doc into non-editable DOM-like structure
			XPathDocument doc = new XPathDocument(xmlPath);
			XPathNavigator nav = doc.CreateNavigator();

			//####  Find Address via manual techniques to demonstrate
			//moving through nodes via the XPathNavigator
			nav.MoveToRoot();
			//Move to Customers element
			nav.MoveToFirstChild();
			//Move to Customer element
			nav.MoveToFirstChild();
			//Move to first child of Customer (CompanyName)
			nav.MoveToFirstChild();
			//Move to Address element by looping
			//through all children of Customer element
			while (nav.MoveToNext()) {
				if (nav.LocalName == "Address") {
					//Move to text node
					nav.MoveToFirstChild();
					this.lblOutput1.Text = nav.Value;
				}
			}

			//#### Find Address via XPath
			//Move back up to Customer node and then use XPath

			//First move from text node back to Address
			nav.MoveToParent();
			//Now move back up to parent of Address (Customer)
			nav.MoveToParent();
			//Use XPath to find Address tag instead of doing manual
			//searching as shown earlier
			XPathNodeIterator node = nav.Select("Address");
			node.MoveNext();
			//Move to text node from current node (Address)
			this.lblOutput2.Text = node.Current.Value;
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
