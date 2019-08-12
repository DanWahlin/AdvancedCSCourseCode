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

namespace RSSDemo {

	public partial class GetRSSFeeds_aspx : System.Web.UI.Page {

		public void btnGetFeeds_Click(object sender, System.EventArgs e) {
			string[] rssURLs = new string[]{this.txtRss1.Text,this.txtRss2.Text,
											   this.txtRss4.Text,this.txtRss5.Text};
			int numberToShow = (this.txtRandom.Text ==String.Empty)?0:Int32.Parse(this.txtRandom.Text);
			string rssOutput = RSSGrabber.GetRssItems(rssURLs,numberToShow);
			LiteralControl lit = new LiteralControl(rssOutput);
			lit.Text = lit.Text.Replace("&lt;","<");
			lit.Text = lit.Text.Replace("&gt;",">");
			lit.Text = lit.Text.Replace("&amp;","&");

			this.phRSSOutput.Controls.Add(lit);
		}

	}
}
