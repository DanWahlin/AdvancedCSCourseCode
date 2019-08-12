using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataDemos.MasterDetail
{
	/// <summary>
	/// Summary description for MasterDetail.
	/// </summary>
	public class frmMasterDetail : System.Windows.Forms.Form {
		private DataView custView = null;
		private DataView ordersView = null;
		internal System.Windows.Forms.Label lblOrders;
		internal System.Windows.Forms.Label lblCustomers;
		internal System.Windows.Forms.DataGrid dgOrders;
		internal System.Windows.Forms.DataGrid dgCustomers;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMasterDetail()
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
			Application.Run(new frmMasterDetail());
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblOrders = new System.Windows.Forms.Label();
			this.lblCustomers = new System.Windows.Forms.Label();
			this.dgOrders = new System.Windows.Forms.DataGrid();
			this.dgCustomers = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// lblOrders
			// 
			this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblOrders.Location = new System.Drawing.Point(24, 224);
			this.lblOrders.Name = "lblOrders";
			this.lblOrders.Size = new System.Drawing.Size(80, 24);
			this.lblOrders.TabIndex = 7;
			this.lblOrders.Text = "Orders:";
			// 
			// lblCustomers
			// 
			this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCustomers.Location = new System.Drawing.Point(24, 8);
			this.lblCustomers.Name = "lblCustomers";
			this.lblCustomers.Size = new System.Drawing.Size(80, 24);
			this.lblCustomers.TabIndex = 6;
			this.lblCustomers.Text = "Customers:";
			// 
			// dgOrders
			// 
			this.dgOrders.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgOrders.BackColor = System.Drawing.Color.GhostWhite;
			this.dgOrders.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgOrders.CaptionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgOrders.CaptionForeColor = System.Drawing.Color.White;
			this.dgOrders.DataMember = "";
			this.dgOrders.FlatMode = true;
			this.dgOrders.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dgOrders.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgOrders.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgOrders.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgOrders.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dgOrders.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgOrders.LinkColor = System.Drawing.Color.Teal;
			this.dgOrders.Location = new System.Drawing.Point(24, 248);
			this.dgOrders.Name = "dgOrders";
			this.dgOrders.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgOrders.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgOrders.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgOrders.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgOrders.Size = new System.Drawing.Size(632, 176);
			this.dgOrders.TabIndex = 5;
			// 
			// dgCustomers
			// 
			this.dgCustomers.AlternatingBackColor = System.Drawing.Color.GhostWhite;
			this.dgCustomers.BackColor = System.Drawing.Color.GhostWhite;
			this.dgCustomers.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgCustomers.CaptionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgCustomers.CaptionForeColor = System.Drawing.Color.White;
			this.dgCustomers.DataMember = "";
			this.dgCustomers.FlatMode = true;
			this.dgCustomers.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dgCustomers.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dgCustomers.GridLineColor = System.Drawing.Color.RoyalBlue;
			this.dgCustomers.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dgCustomers.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dgCustomers.HeaderForeColor = System.Drawing.Color.Lavender;
			this.dgCustomers.LinkColor = System.Drawing.Color.Teal;
			this.dgCustomers.Location = new System.Drawing.Point(24, 32);
			this.dgCustomers.Name = "dgCustomers";
			this.dgCustomers.ParentRowsBackColor = System.Drawing.Color.Lavender;
			this.dgCustomers.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dgCustomers.SelectionBackColor = System.Drawing.Color.Teal;
			this.dgCustomers.SelectionForeColor = System.Drawing.Color.PaleGreen;
			this.dgCustomers.Size = new System.Drawing.Size(632, 176);
			this.dgCustomers.TabIndex = 4;
			this.dgCustomers.CurrentCellChanged += new System.EventHandler(this.dgCustomers_CurrentCellChanged);
			// 
			// frmMasterDetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(688, 446);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblOrders,
																		  this.lblCustomers,
																		  this.dgOrders,
																		  this.dgCustomers});
			this.Name = "frmMasterDetail";
			this.Text = "MasterDetail";
			this.Load += new System.EventHandler(this.MasterDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void MasterDetail_Load(object sender, System.EventArgs e) {

            string str1 = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
			string str2 = "SELECT * FROM Customers;SELECT * FROM Orders";
			SqlConnection sqlConnection = new SqlConnection(str1);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(str2, sqlConnection);
			sqlDataAdapter.TableMappings.Add("Table", "Customers");
			sqlDataAdapter.TableMappings.Add("Table1", "Orders");
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet);
			custView = dataSet.Tables["Customers"].DefaultView;
			ordersView = dataSet.Tables["Orders"].DefaultView;
			FilterOrders(0);
			dgCustomers.DataSource = custView;
			dgOrders.DataSource = ordersView;
		}

		private void FilterOrders(int row) {
			string str = custView[row]["CustomerID"].ToString();
			ordersView.RowFilter = String.Concat("CustomerID = '", str, "'");
		}

		private void dgCustomers_CurrentCellChanged(object sender, EventArgs e) {
			FilterOrders(dgCustomers.CurrentRowIndex);
		}

	}
}
