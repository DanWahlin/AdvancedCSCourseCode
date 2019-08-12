<%@ Page language="c#" CodeFile="GetRSSFeeds.aspx.cs" Inherits="RSSDemo.GetRSSFeeds_aspx" %>
<HTML>
	<HEAD>
		<title>Aggregate RSS Feeds</title>
	</HEAD>
	<body bgColor="#ffffff">
		<h2>RSS Demo</h2>
		<form id="Form1" method="post" runat="server">
			<table>
				<tr>
					<td><b>RSS Feed:</b>
						<asp:TextBox id="txtRss1" Runat="server" Text="http://www.xmlforasp.net/XML/RssGenerator.aspx"
							Columns="70" /></td>
				</tr>
				<tr>
					<td>
						<b>RSS Feed:</b>
						<asp:TextBox id="txtRss2" Runat="server" Columns="70" Text="http://www.espn.com/espn/rss/news" /></td>
				</tr>
				<TR>
					<TD><STRONG>RSS Feed:
							<asp:TextBox id="txtRss4" Runat="server" Columns="70"></asp:TextBox></STRONG></TD>
				</TR>
				<TR>
					<TD><STRONG>RSS Feed:
							<asp:TextBox id="txtRss5" Runat="server" Columns="70"></asp:TextBox></STRONG></TD>
				</TR>
			</table>
			<br>
			<b>Number to Show:</b>
			<asp:TextBox ID="txtRandom" Runat="server" MaxLength="3" Width="32px"></asp:TextBox>&nbsp;(leave 
			blank to show all RSS feed items)
			<BR>
			<p><asp:button id="btnGetFeeds" Runat="server" Text="Show RSS" OnClick="btnGetFeeds_Click"></asp:button><BR>
				<BR>
				<asp:PlaceHolder ID="phRSSOutput" runat="server"></asp:PlaceHolder>
		</form>
	</body>
</HTML>
