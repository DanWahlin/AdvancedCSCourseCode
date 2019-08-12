<%@ Page Language="C#" CodeFile="XmlWriterSettings.aspx.cs" Inherits="XmlWriterSettings_aspx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Editing with the XPathNavigator Class</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>
            Formatting XML with the XmlWriterSettings Class</h2>
        <br />
        &nbsp;
        <asp:TextBox ID="txtXml" Runat="server" TextMode="MultiLine" Width="710px" Height="296px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmit" Runat="server" Text="Generate XML" OnClick="btnSubmit_Click" />
        
    </form>
</body>
</html>
