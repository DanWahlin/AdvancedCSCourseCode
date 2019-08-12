<%@ Page Language="C#"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>
            TreeView and XmlDataSource Demo</h3>
        <p>
            <asp:TreeView ID="TreeView1" Runat="server"  ExpandDepth="0" DataSourceID="MenuItemsDataSource" AutoGenerateDataBindings="False" ImageSet="XPFileExplorer" NodeIndent="15">
                <SelectedNodeStyle BackColor="#B5B5B5"></SelectedNodeStyle>
                <DataBindings>
                    <asp:TreeNodeBinding Value="Links" Text="Links"></asp:TreeNodeBinding>
                    <asp:TreeNodeBinding TextField="name" DataMember="link" NavigateUrlField="href"></asp:TreeNodeBinding>
                </DataBindings>
                <NodeStyle VerticalPadding="2" Font-Names="Tahoma" Font-Size="8pt" HorizontalPadding="2"
                    ForeColor="#000000"></NodeStyle>
                <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA"></HoverNodeStyle>
            </asp:TreeView>
            <asp:XmlDataSource ID="MenuItemsDataSource" Runat="server" DataFile="~/XML/Links.xml"
                XPath="links">
            </asp:XmlDataSource>
        </p>
    
    </div>
    </form>
</body>
</html>
