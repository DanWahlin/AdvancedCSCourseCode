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

public partial class PerformanceCounters_DemoCustomCounter : System.Web.UI.Page
{

    protected override void OnPreRender(EventArgs e)
    {
        Label1.Text = PerfMonManager.CustomCounter.RawValue.ToString();
        base.OnPreRender(e);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        PerfMonManager.CustomCounter.Increment();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        PerfMonManager.CustomCounter.RawValue = 0;
    }
}
