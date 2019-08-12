<%@ Control %>
<%@ OutputCache Duration="120" VaryByParam="none" %>
<%@ Register TagPrefix="wc" Namespace="XMLHierMenus" %>
<!-- Following two files must be placed in the appropriate location in your virtual directory 
		for the XML menu system to work correctly -->
<link rel="STYLESHEET" type="text/css" href="menuStyle.css">
	<script Language="JavaScript" src="XMLMenuScript.js"></script>
	<table border="0" cellspacing="0" cellpadding="0" width="640">
		<tr align="left" valign="center">
			<td bgcolor="#02027a" nowrap width="50">
				&nbsp;
			</td>
			<td bgcolor="#02027a" align="left" nowrap>
				<wc:XmlMenu id="menus" runat="server" StartMenuName="Sites" StartMenuImage="images/yellow_arrow_down2.gif" StartMenuStyle="font:10pt arial;font-weight:bold;color: #FFFFFF;text-decoration:none;cursor:hand" MenuImagePath="images/tri2.gif" XmlFilePath="~/XML/menuItems.xml" />
			</td>
			<td bgcolor="#02027a" nowrap width="50">
				&nbsp;
			</td>
			<td bgcolor="#02027a" align="left" nowrap>
				<wc:XmlMenu id="menus2" runat="server" StartMenuName="PhoneBook" StartMenuImage="images/yellow_arrow_down2.gif" StartMenuStyle="font:10pt arial;font-weight:bold;color: #FFFFFF;text-decoration:none;cursor:hand" MenuImagePath="images/tri2.gif" XmlFilePath="~/XML/menuItems2.xml" />
			</td>
		</tr>
	</table>
