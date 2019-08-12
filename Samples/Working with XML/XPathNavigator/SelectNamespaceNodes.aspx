<%@ Page Language="C#" CodeFile="SelectNamespaceNodes.aspx.cs" Inherits="SelectNamespaceNodes_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            Selecting XML Nodes in Namespaces using the XPathNavigator Class</h2>
        <br />
        <b>Select an Author:
        <asp:DropDownList ID="ddAuthors" Runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddAuthors_SelectedIndexChanged">
        </asp:DropDownList>&nbsp;<br />
        </b>
        <br />
        <asp:PlaceHolder ID="phArticles" Runat="server"></asp:PlaceHolder>
    
    </div>
    </form>
</body>
</html>
