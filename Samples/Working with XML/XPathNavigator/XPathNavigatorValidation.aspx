<%@ Page Language="C#" CodeFile="XPathNavigatorValidation.aspx.cs" Inherits="XPathNavigatorValidation_aspx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>XPathDocument Validation</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>
            Validating XML Documents with the XPathDocument Class</h3>
        <p>
            <asp:TextBox ID="txtXml" Runat="server" TextMode="MultiLine" Rows="20" Columns="100"></asp:TextBox>&nbsp;<br />
            <br />
            &nbsp;
            <asp:Button ID="btnSubmit" Runat="server" Text="Validate XML" OnClick="btnSubmit_Click" />
            <asp:Label ID="lblOutput" Runat="server" Font-Bold="True"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
