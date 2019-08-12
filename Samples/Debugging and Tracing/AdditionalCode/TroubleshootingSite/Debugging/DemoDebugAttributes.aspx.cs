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

public partial class Debugging_DemoDebugAttributes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Course cs300 = new Course();
        cs300.CourseId = "CS300";
        cs300.Name = "Advanced C# Development With .NET Framework 2.0";
        cs300.Description = "In this course you will learn to blah, blah, blah....";
        Response.Write(cs300.CourseId);
    }
}
