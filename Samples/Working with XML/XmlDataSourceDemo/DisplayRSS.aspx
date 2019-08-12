<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>
            Using XPath with the XmlDataSource Control and XPathBinder Class</h3>
        <asp:DataList ID="dlRSSItems" Runat="server" DataSourceID="RSSDataSource" BorderColor="#DEDFDE"
            BackColor="White" BorderWidth="1px" GridLines="Vertical" BorderStyle="None"
            CellPadding="4" ForeColor="Black">
            <FooterStyle BackColor="#CCCC99"></FooterStyle>
            <FooterTemplate>
                        </ul>
                    </td>
                </tr>
            </FooterTemplate>
            <ItemTemplate>
                <li>
                    <a style="text-decoration:none;" href='<%# XPath("link") %>'><%# XPath("title") %></a> 
                    (<%# DateTime.Parse(XPath("pubDate").ToString()).ToShortDateString() %>)
                </li>                
            </ItemTemplate>
            <AlternatingItemTemplate>
                <li>
                    <a style="text-decoration:none;" href='<%# XPath("link") %>'><%# XPath("title") %></a> 
                    (<%# DateTime.Parse(XPath("pubDate").ToString()).ToShortDateString() %>)                </li>                
            </AlternatingItemTemplate>
            <AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
            <ItemStyle BackColor="#F7F7DE"></ItemStyle>
            <SelectedItemStyle ForeColor="White" Font-Bold="True" BackColor="#CE5D5A"></SelectedItemStyle>
            <HeaderTemplate>
                <tr>
                    <td style="background-color:Navy;color:White;font-family:Arial;color:White;">
                        MSDN RSS Articles:
                    </td>
                </tr>
                <tr>
                    <td>                   
                        <ul>
                    </td>
                </tr>
            </HeaderTemplate>
            <HeaderStyle ForeColor="White" Font-Bold="True" BackColor="#6B696B"></HeaderStyle>
        </asp:DataList>
        <asp:XmlDataSource ID="RSSDataSource" Runat="server" DataFile="~/XML/MSDN.xml" XPath="rss/channel/item">
        </asp:XmlDataSource>
    
    </div>
    </form>
</body>
</html>
