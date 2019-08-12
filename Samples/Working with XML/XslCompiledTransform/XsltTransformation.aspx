<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XsltTransformation.aspx.cs" Inherits="XsltTransformation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Transform RSS" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server"></asp:Label></div>
    </form>
</body>
</html>
