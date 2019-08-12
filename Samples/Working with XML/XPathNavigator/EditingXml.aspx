<%@ Page Language="C#" CodeFile="EditingXml.aspx.cs" Inherits="EditingXml_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Editing with the XPathNavigator Class</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            Editing XML with XPathNavigator<br />
        </h2>
        This example demonstrates how the Links.xml file can be edited using the
        new XPathNavigator editing capabilities.<br />
        <br />
        <asp:DataList ID="dlLinks" Runat="server" BorderColor="#DEDFDE" BackColor="White" BorderWidth="0px" GridLines="Vertical" BorderStyle="None" CellPadding="4" DataSourceID="XmlDataSource1" OnItemCommand="dlLinks_ItemCommand" ForeColor="Black">
            <FooterStyle BackColor="#CCCC99"></FooterStyle>
            <ItemTemplate>
                <asp:Label ID="titleLabel" Font-Bold="true" Runat="server" Text='<%# Eval("name") %>'></asp:Label><br />
                <asp:hyperlink ID="hrefLabel" Runat="server" Text='<%# Eval("href") %>' NavigateUrl='<%# Eval("href") %>'></asp:hyperlink><br />
                <br />
                &nbsp;<asp:LinkButton ID="lbEdit" Runat="server" CommandName="Edit" CommandArgument='<%# Eval("id") %>'>Edit</asp:LinkButton>&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lbDelete" Runat="server" CommandName="Delete" CommandArgument='<%# Eval("id") %>' OnClientClick="if (!confirm('Are you sure you want to delete this link?')) return false;">Delete</asp:LinkButton>
                <br />
            </ItemTemplate>
            <AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
            <ItemStyle BackColor="#F7F7DE"></ItemStyle>
            <SelectedItemStyle ForeColor="White" Font-Bold="True" BackColor="#CE5D5A"></SelectedItemStyle>
            <HeaderStyle ForeColor="White" Font-Bold="True" BackColor="#6B696B"></HeaderStyle>
        </asp:DataList>
        <asp:XmlDataSource ID="XmlDataSource1" Runat="server" DataFile="~/XML/Links.xml" EnableCaching="false">
        </asp:XmlDataSource>
        &nbsp;
        <br />
        <br />
        <b>ID: </b>
        <asp:Label ID="lblID" Runat="server" />
        <br />
        <br />
        <b>Name: </b>
        <asp:TextBox ID="txtName" Runat="server" Width="589px"></asp:TextBox>
        <br />
        <br />
        <b>URL:&nbsp;</b>&nbsp;
        <asp:TextBox ID="txtURL" Runat="server" Width="588px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAddLink" Runat="server" Text="Submit Link" OnClick="btnAddLink_Click" />
        <asp:Label ID="lblOutput" Runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
