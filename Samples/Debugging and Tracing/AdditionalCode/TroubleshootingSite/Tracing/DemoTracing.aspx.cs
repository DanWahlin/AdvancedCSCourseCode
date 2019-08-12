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

public partial class Tracing_DemoTracing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /* It is the experience of the courseware authors
         * that web applications can not make direct calls to 
         * methods of System.Diagnostics.Trace.  However,
         * you can call a class library that in turn calls 
         * System.Diagnostics.Trace
         */
        
        TraceManager.WriteLine("Inside Button1_Click");
       
    }
}
