<%@ Page language="c#" CodeFile="NorthwindDemo.aspx.cs" Inherits="ServerConfig.NorthwindDemo" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>NorthwindDemo</title>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Button id="btnSubmit" runat="server"
				Text="Get Data" Width="112px" OnClick="btnSubmit_Click"></asp:Button>
            &nbsp;
            <br />
            <br />
            <br />
			<asp:GridView ID="gvCustomers" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" >
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="#DCDCDC" />
            </asp:GridView>
		</form>
	</body>
</HTML>
