<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ParsingRss.aspx.cs" Inherits="XmlReader_ParsingRss" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        a {text-decoration:none;}
        a:hover {color:Navy;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Parsing and Displaying RSS Data with XmlReader and XmlWriter</h2>
        <asp:Label ID="lblOutput" runat="Server" EnableViewState="false" />
    </div>
    </form>
</body>
</html>
