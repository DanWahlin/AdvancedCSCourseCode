using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Diagnostics;

public partial class Debugging_DemoDebugMethods : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Debug.Write("In Button1 Click...");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Debug.WriteLineIf(5 > 3, "5 is greater than 3");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Debug.Assert(5 < 3, "5 is not less than 3");
    }
}
