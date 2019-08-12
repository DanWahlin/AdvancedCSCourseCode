using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.ServiceReference1;
using System.ServiceModel;

namespace Client
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer cust1 = new Customer();
            cust1.CustomerID = "ZZZZZ";
            cust1.CompanyName = "ACME Corp";
            cust1.ContactName = "John Doe";

            //This will cause a duplicate ID to be inserted and will result in an exception
            Customer cust2 = new Customer();
            cust2.CustomerID = "ALFKI";
            cust2.CompanyName = "ACME Corp";
            cust2.ContactName = "Jane Doe";
            Service1Client proxy = new Service1Client();

            try
            {
                proxy.InsertCustomers(new Customer[]{cust1,cust2});
                this.lblStatus.Text = "Customers Inserted";
            }
            catch (FaultException<OperationStatusFault> ex)
            {
                this.lblStatus.Text = ex.Detail.Message;
            }
        }
    }
}
