<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SelectNodeInNamespaceDemo.aspx.cs" Inherits="SelectNodeInNamespaceDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            Selecting XML Nodes in Namespaces using the XmlDocument Class</h2>
        <br />
        <b>Select an Author:
        <asp:DropDownList ID="ddAuthors" Runat="server" AutoPostBack="True" AppendDataBoundItems="true" OnSelectedIndexChanged="ddAuthors_SelectedIndexChanged">
            <asp:ListItem Value="">Select One:</asp:ListItem>
        </asp:DropDownList>&nbsp;<br />
        </b>
        <br />
        <asp:PlaceHolder ID="phArticles" Runat="server"></asp:PlaceHolder>
    
    </div>
    </form>
</body>
</html>
