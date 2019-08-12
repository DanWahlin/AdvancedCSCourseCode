<%@ Page %>
<%@ Register Tagprefix="wc" Tagname="XmlMenuControl" Src="XmlHierMenusControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<body bgcolor="#ffffff">
		<wc:XmlMenuControl id="menuControl" runat="server" />
		<br />
		<table border="0" cellspacing="0" cellpadding="0" width="640">
			<tr>
				<td colspan="4">
					&nbsp;
				</td>
			</tr>
			<tr>
				<td colspan="4" align="middle" bgcolor="#efefef">
					<font size="2" face="arial"><b>Click one of the links above to start the menu.</b>
						<br>
						This example is dynamically created from the menuitems.xml and menuitems2.xml files.</font>
				</td>
			</tr>
		</table>
	</body>
</HTML>
