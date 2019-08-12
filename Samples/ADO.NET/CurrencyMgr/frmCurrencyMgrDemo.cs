using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataDemos.CurrencyMgr
{
	/// <summary>
	/// Summary description for frmCurrencyMgrDemo.
	/// </summary>
	public class frmCurrencyMgrDemo : System.Windows.Forms.Form	{

		DataView view = null;
		CurrencyManager manager = null;

		internal System.Windows.Forms.Button btnEnd;
		internal System.Windows.Forms.Button btnForward;
		internal System.Windows.Forms.Button btnBack;
		internal System.Windows.Forms.Button btnStart;
		internal System.Windows.Forms.TextBox txtContactName;
		internal System.Windows.Forms.TextBox txtCustomerID;
		internal System.Windows.Forms.Label lblContactName;
		internal System.Windows.Forms.Label lblCustomerID;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmCurrencyMgrDemo()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		public static void Main() {
			Application.Run(new frmCurrencyMgrDemo());
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnForward = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.txtContactName = new System.Windows.Forms.TextBox();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.lblContactName = new System.Windows.Forms.Label();
			this.lblCustomerID = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(280, 111);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(48, 24);
			this.btnEnd.TabIndex = 15;
			this.btnEnd.Text = ">>";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnForward
			// 
			this.btnForward.Location = new System.Drawing.Point(208, 111);
			this.btnForward.Name = "btnForward";
			this.btnForward.Size = new System.Drawing.Size(48, 24);
			this.btnForward.TabIndex = 14;
			this.btnForward.Text = ">";
			this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(136, 111);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(48, 24);
			this.btnBack.TabIndex = 13;
			this.btnBack.Text = "<";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(64, 111);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(48, 24);
			this.btnStart.TabIndex = 12;
			this.btnStart.Text = "<<";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// txtContactName
			// 
			this.txtContactName.Location = new System.Drawing.Point(136, 71);
			this.txtContactName.Name = "txtContactName";
			this.txtContactName.Size = new System.Drawing.Size(208, 20);
			this.txtContactName.TabIndex = 11;
			this.txtContactName.Text = "";
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(136, 39);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(208, 20);
			this.txtCustomerID.TabIndex = 10;
			this.txtCustomerID.Text = "";
			// 
			// lblContactName
			// 
			this.lblContactName.Location = new System.Drawing.Point(48, 71);
			this.lblContactName.Name = "lblContactName";
			this.lblContactName.Size = new System.Drawing.Size(88, 24);
			this.lblContactName.TabIndex = 9;
			this.lblContactName.Text = "ContactName";
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.Location = new System.Drawing.Point(48, 39);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(88, 24);
			this.lblCustomerID.TabIndex = 8;
			this.lblCustomerID.Text = "CustomerID";
			// 
			// frmCurrencyMgrDemo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 174);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnEnd,
																		  this.btnForward,
																		  this.btnBack,
																		  this.btnStart,
																		  this.txtContactName,
																		  this.txtCustomerID,
																		  this.lblContactName,
																		  this.lblCustomerID});
			this.Name = "frmCurrencyMgrDemo";
			this.Text = "frmCurrencyMgrDemo";
			this.Load += new System.EventHandler(this.frmCurrencyMgrDemo_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnStart_Click(object sender, System.EventArgs e) {
			manager.Position = 0;
		}

		private void btnBack_Click(object sender, System.EventArgs e) {
			if (manager.Position != 0) {
				CurrencyManager currencyManager = manager;
				currencyManager.Position = currencyManager.Position - 1;
			}
		}

		private void btnForward_Click(object sender, System.EventArgs e) {
			if (manager.Position != view.Count - 1) {
				CurrencyManager currencyManager = manager;
				currencyManager.Position = currencyManager.Position + 1;
			}
		}

		private void btnEnd_Click(object sender, System.EventArgs e) {
			manager.Position = view.Count - 1;
		}

		private void frmCurrencyMgrDemo_Load(object sender, System.EventArgs e) {
            string str1 = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
			string str2 = "SELECT * FROM Customers";
			SqlConnection sqlConnection = new SqlConnection(str1);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(str2, sqlConnection);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet, "Customers");
			view = dataSet.Tables["Customers"].DefaultView;
			txtCustomerID.DataBindings.Add(new Binding("Text", view, "CustomerID"));
			txtContactName.DataBindings.Add(new Binding("Text", view, "ContactName"));
			manager = (CurrencyManager)base.BindingContext[view];
			manager.Position = 0;
		}
	}
}
