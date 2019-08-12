<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoDebugMethods.aspx.cs" Inherits="Debugging_DemoDebugMethods" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Demo Debug.Write" Width="215px" /><br />
        <asp:Button ID="Button3" runat="server" Text="Demo Debug.WriteLineIf" Width="215px" OnClick="Button2_Click" /><br />
        <asp:Button ID="Button2" runat="server" Text="Demo Debug.Assert" Width="215px" OnClick="Button3_Click" />&nbsp;</div>
    </form>
</body>
</html>
