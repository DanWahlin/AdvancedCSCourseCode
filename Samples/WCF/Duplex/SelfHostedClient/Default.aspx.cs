using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Address
        string url = "http://localhost:9090/Services/DataService";
        EndpointAddress addr = new EndpointAddress(url);
        //Binding
        WSHttpBinding binding = new WSHttpBinding();
        //Contract
        WcfServiceLibrary1.IService1 proxy =
            ChannelFactory<WcfServiceLibrary1.IService1>
            .CreateChannel(binding, addr);
        //lblOutput.Text = proxy.GetData(5);

    }
}
