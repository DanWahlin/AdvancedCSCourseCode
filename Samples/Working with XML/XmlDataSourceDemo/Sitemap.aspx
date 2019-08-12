<%@ Page Language="C#"  %>

<html>

  <!-- For the hover styles of the Menu control to  -->
  <!-- work correctly, you must include this head   -->
  <!-- element.                                     -->
  <head id="Head1" runat="server">
  </head>

  <body>
    <form id="Form1" runat="server">
    
      <h3>
          XML Menu DataBinding Example</h3>
    
      <!-- Bind the Menu control to a SiteMapDataSource control.  -->
      <asp:menu id="NavigationMenu"
        disappearafter="2000"
        staticdisplaylevels="2"
        staticsubmenuindent="" 
        target="_blank"
        datasourceid="MenuSource"   
        runat="server" DynamicHorizontalOffset="2" BorderStyle="None">
        
        <staticmenuitemstyle backcolor="LightSteelBlue"
          forecolor="Black" HorizontalPadding="5" VerticalPadding="2"/>
        <dynamicmenuitemstyle backcolor="Black"
          forecolor="Silver" HorizontalPadding="5" VerticalPadding="2"/>
        <dynamichoverstyle Font-Bold="True"/>
        <statichoverstyle Font-Bold="True"/>

      </asp:menu>
      
      <asp:SiteMapDataSource id="MenuSource"
        runat="server"/>        

    </form>
  </body>
</html>

