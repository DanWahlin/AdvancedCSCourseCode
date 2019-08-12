using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using ServerConfig.Biz;

namespace ServerConfig
{
	/// <summary>
	/// Summary description for NorthwindDemo.
	/// </summary>
	public partial class NorthwindDemo : System.Web.UI.Page
	{

	
		public void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

        public void btnSubmit_Click(object sender, System.EventArgs e)
        {
			//Call business layer (see Biz folder Northwind.cs class)
			this.gvCustomers.DataSource = Northwind.GetCustomers();
            this.gvCustomers.DataBind();
		}
}
}
