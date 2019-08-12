using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Xml.XPath;
using System.Text;

namespace XPathNavigatorDemo {

	public partial class XPathNavigatorRecursive : System.Web.UI.Page	{
		int indentLevel = 0;
		Stack<string> stack = new Stack<string>();
		StringBuilder sb = new StringBuilder();

		private void Page_Load(object sender, System.EventArgs e) {
			string xmlPath = Server.MapPath("~/XML/Customers.xml");
			//Load XML doc into non-editable DOM-like structure
			XPathDocument doc = new XPathDocument(xmlPath);
			//Create an XPathNavigator so we can iterate through nodes
			XPathNavigator nav = doc.CreateNavigator();
			nav.MoveToRoot();
			//Walk through the document recursively
			WalkTheNavTree(nav);
			//Write out closing tags of elements that don't have text
			//nodes that are in the stack
			while (stack.Count > 0) {
				indentLevel--;
				sb.Append("<br />" + Indent() + "<b>&lt;/" + stack.Pop() + "&gt;</b>");
			}
			this.lblOutput.Text = sb.ToString();
		}

		public void WalkTheNavTree(XPathNavigator nav) {
			//Handle children of current navigator position
			if (nav.HasChildren) {
				nav.MoveToFirstChild();
				if (nav.NodeType == XPathNodeType.Element) {
					indentLevel++; //increment level of hierarchy
				}
				//Only write out element names
				WriteNav(nav);
				//Recursively call function to continue
				//walking through the tree
				WalkTheNavTree(nav); 
				//This will be called after we process the children of a node
				//"children" includes text nodes as well
				nav.MoveToParent();
			}
			//Move to sibling of current node.  This will cause all siblings
			//to be processed
			while (nav.MoveToNext()) {
				WriteNav(nav);
				WalkTheNavTree(nav); 
			}
		}

		public void WriteNav(XPathNavigator nav) {
			if (nav.NodeType == XPathNodeType.Element) { 
				sb.Append("<br />" + Indent() + "<b>&lt;" + nav.LocalName);
				//Walk through any attributes on the element
				//and write them out
				if (nav.HasAttributes) {
					nav.MoveToFirstAttribute();
					sb.Append(" " + nav.LocalName + "=\"" + nav.Value + "\"");
					while (nav.MoveToNextAttribute()) {
						sb.Append(" " + nav.LocalName + "=\"" + nav.Value + "\"");
					}
					//Get off of attributes and move back to element
					nav.MoveToParent();
				}
				sb.Append("&gt;</b>");
				//Add element name to stack so we can track closing tag names
				//to write out
				stack.Push(nav.LocalName);
			}
			//Write out text node value and closing element name that
			//is on the stack
			if (nav.NodeType == XPathNodeType.Text) {
				if (nav.Value != null) {
					sb.Append(nav.Value + "<b>&lt;/" + stack.Pop() + "&gt;</b>");
				}
			}
		}
        
		//Handle indenting the XML as appropriate
		public string Indent() {
			string spaces = "";
			for (int i=0;i<indentLevel*4;i++) {
				spaces += "&nbsp;";
			}
			return spaces;
		}

	}
}
