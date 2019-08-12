using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace XMLHierMenus {
	/// <summary>
	/// Hierarchical Menus Application by Dan Wahlin - http://www.XMLforASP.NET
	/// </summary>

	public class XmlMenu : Control {
        List<string> _arrayHolderArray	= new List<string>();
		List<string> _arrayNamesArray = new List<string>();
		string _xmlFilePath         = String.Empty;
        string _startMenuName       = String.Empty;
        string _strImage            = String.Empty;
        string _startMenuImage      = String.Empty;
        string _startMenuStyle      = String.Empty;
        string _startMenuLinkText   = String.Empty;
        string _strCurrentMenu      = String.Empty;
        int	_intLevel               = 1;
        HttpContext context         = HttpContext.Current;

        public string StartMenuName {
            get {
                return _startMenuName;
            }
            set {
                _startMenuName = value;
            }
        }
        
        public string MenuImagePath {
            get {
                return _strImage;
            }
            set {
                _strImage = value;
            }
        }

        public string StartMenuStyle {
            get {
                return _startMenuStyle;
            }
            set {
                _startMenuStyle = value;
            }
        }

        public string StartMenuImage {
            get {
                return _startMenuImage;
            }
            set {
                _startMenuImage = value;
            }
        }

        public string XmlFilePath {
            get {
                return _xmlFilePath;
            }
            set {
                _xmlFilePath = value;
            }
        }

		protected override void Render(HtmlTextWriter output) {
            if (this.StartMenuImage == String.Empty) {
                output.Write("StartMenuName not supplied.  The XML menus cannot initialize");
            } else {
                output.Write("<a id=\"" + this.StartMenuName + "_link" + "\" onClick=\"startIt('" + this.StartMenuName +
                             "',this,0)\" style=\"" + this.StartMenuStyle + "\">" +
                             this.StartMenuName);
                if (this.StartMenuImage != String.Empty) output.Write("<img src=\"" + this.StartMenuImage + "\" border=\"0\">");
                output.Write("</a>");
                output.Write("\n\n" + CreateMenu());
            }
		}
		
        public string CreateMenu() {
            StringBuilder strOutput = new StringBuilder();
            int i = 0;
            List<string> startArray = new List<string>();
            string strVariable = "";
            string strTemp = "";
			
            XmlDocument XMLDoc = new XmlDocument();
            try {
                XMLDoc.Load(CheckFilePath(_xmlFilePath));
            }
            catch (Exception exc) {
                strOutput.Append(exc.Message);
                return strOutput.ToString();
            }
				
            XmlNodeList nodeList = XMLDoc.DocumentElement.ChildNodes;
                			
            foreach (XmlNode node in nodeList) {

                XmlNode currentNode = node;
                if (currentNode.HasChildNodes == true && currentNode.ChildNodes.Count>1) {
                    _strCurrentMenu = _startMenuName + "_" + (i+1);
                    string thisMenu = _startMenuName;	
                    if (currentNode.ChildNodes.Count>2) {
                        strVariable = "<span id=\"" + thisMenu + "_span" + (i+1) +
                                      "\" class='cellOff' onMouseOver=\"stateChange('" + _strCurrentMenu +
                                      "',this," + _intLevel + ")\" onMouseOut=\"stateChange('',this,'')\">" + 
                                      "<img align=\"right\" vspace=\"2\" border=\"0\" src=\"" + _strImage + "\">" + currentNode.ChildNodes[1].InnerText + 
                                      "</span><br>\n";
                        startArray.Add(strVariable);	
                        WalkTree(currentNode);
                    } else {
                        strVariable = "<span id=\"" + thisMenu + "_span" + (i+1) + "\" class='cellOff' onMouseOver=\"stateChange('',this,'');hideDiv(" + _intLevel + ")\" onMouseOut=\"stateChange('',this,'')\" onClick=\"location.href='" + currentNode.ChildNodes[0].InnerText + "'\">" + currentNode.ChildNodes[1].InnerText + "</span><br>\n";
                        startArray.Add(strVariable);	
                    }
                }
                i++;
            }
			
            startArray.TrimExcess();			
            _arrayNamesArray.Add(_startMenuName);
            for (i=0;i<startArray.Count;i++) {
                strTemp += startArray[i];
            }
            _arrayHolderArray.Add(strTemp);
			
            //Reverse Array order so we don't have to worry about the ZIndex of each div layer
            _arrayHolderArray.Reverse();
            _arrayNamesArray.Reverse();

            //Loop through arrays and write out divs and their individual span content items
            for (i=0;i<_arrayNamesArray.Count;i++) {
                strOutput.Append("<div id='" + _arrayNamesArray[i].ToString() + "' class='clsMenu'>");
                strOutput.Append(_arrayHolderArray[i].ToString());
                strOutput.Append("</div>\n");
            }			
            _arrayHolderArray.Clear();
            _arrayNamesArray.Clear();
			
            /*if (_blnStaticMenus) {
                StreamWriter writer = new StreamWriter(File.Open(_strSaveToFilePath, FileMode.OpenOrCreate, FileAccess.Write));
                writer.Write(strOutput.ToString());
                writer.Flush();		
                if (writer !=null) writer.Close();
            }*/
            return strOutput.ToString();
        } //CreateMenus
		
        private void WalkTree(XmlNode node) {
            _intLevel += 1;
            string strVariable = "";
            string strTemp = "";
			List<string> tempArray = new List<string>();

			for (int j=2;j<node.ChildNodes.Count;j++) {
                XmlNode newNode = node.ChildNodes[j];
					
                if (newNode.HasChildNodes == true && newNode.ChildNodes.Count>2) {	// Each node should have a 0=hyperlink and 1=text node so don't call the function again if there are just these children
                    _strCurrentMenu += "_" + (j-1);
                    string thisMenu = _strCurrentMenu.Substring(0,_strCurrentMenu.Length-2);
                    strVariable = "<span id=\"" + thisMenu + "_span" + (j-1) + "\" class='cellOff' onMouseOver=\"stateChange('" + _strCurrentMenu + "',this," + _intLevel + ")\" onMouseOut=\"stateChange('',this,'')\">" + "<img align=\"right\" vspace=\"2\" border=\"0\" src=\"" + _strImage + "\">" + newNode.ChildNodes[1].InnerText + "</span><br>\n";
                    tempArray.Add(strVariable);
                    WalkTree(newNode);
                } else {
                    strVariable = "<span id=\"" + _strCurrentMenu + "_span" + (j-1) + "\" class='cellOff' onMouseOver=\"stateChange('',this,'');hideDiv(" + _intLevel + ")\" onMouseOut=\"stateChange('',this,'')\" onClick=\"location.href='" + newNode.ChildNodes[0].InnerText + "'\">" + newNode.ChildNodes[1].InnerText + "</span><br>\n";
                    tempArray.Add(strVariable);
                }			
            }
			
            tempArray.TrimExcess();
            _arrayNamesArray.Add(_strCurrentMenu);
            for (int i=0;i<tempArray.Count;i++) {
                strTemp += tempArray[i];
            }
            _arrayHolderArray.Add(strTemp);
            _strCurrentMenu = _strCurrentMenu.Substring(0,_strCurrentMenu.Length-2); //Exiting function so go back to previous menu version
            _intLevel -= 1;
            tempArray.Clear();
        } // WalkTree

        private string CheckFilePath(string path) {
            if (path.IndexOf("\\:") == -1 && path.ToUpper().IndexOf("HTTP://") == -1) {
                path = context.Server.MapPath(path);
            }
            return path;
        }
	}
}
