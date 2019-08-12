using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;


namespace DataDemos.General {
	/// <summary>
	/// Summary description for frmData.
	/// </summary>
	public class frmData : System.Windows.Forms.Form {
		internal System.Windows.Forms.Label lblDataView;
		internal System.Windows.Forms.TextBox txtDataView;
		internal System.Windows.Forms.CheckBox chkGridChange;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.CheckBox chkSort;
		internal System.Windows.Forms.Label lblSort;
		internal System.Windows.Forms.Label lblCustomersCombo;
		internal System.Windows.Forms.ComboBox cmbCustomers;
		internal System.Windows.Forms.DataGrid dgCustomers;
		internal System.Windows.Forms.Button btnBindGrid;
		internal System.Windows.Forms.Button btnCreateDataSet;
		internal System.Windows.Forms.Button btnCommand;
		internal System.Windows.Forms.Button btnConnection;
		internal System.Windows.Forms.Label lblConnString;
		internal System.Windows.Forms.TextBox txtConnString;


		const string sql  = "SELECT * FROM Customers";
		DataView view = null;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmData() {
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
		protected override void Dispose( bool disposing ) {
			if ( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		public static void Main() {
			Application.Run(new frmData());
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.lblDataView = new System.Windows.Forms.Label();
            this.txtDataView = new System.Windows.Forms.TextBox();
            this.chkGridChange = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkSort = new System.Windows.Forms.CheckBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblCustomersCombo = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.dgCustomers = new System.Windows.Forms.DataGrid();
            this.btnBindGrid = new System.Windows.Forms.Button();
            this.btnCreateDataSet = new System.Windows.Forms.Button();
            this.btnCommand = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblConnString = new System.Windows.Forms.Label();
            this.txtConnString = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataView
            // 
            this.lblDataView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataView.Location = new System.Drawing.Point(20, 40);
            this.lblDataView.Name = "lblDataView";
            this.lblDataView.Size = new System.Drawing.Size(104, 24);
            this.lblDataView.TabIndex = 32;
            this.lblDataView.Text = "DataView Filter";
            // 
            // txtDataView
            // 
            this.txtDataView.Location = new System.Drawing.Point(140, 40);
            this.txtDataView.Name = "txtDataView";
            this.txtDataView.Size = new System.Drawing.Size(464, 20);
            this.txtDataView.TabIndex = 31;
            // 
            // chkGridChange
            // 
            this.chkGridChange.Location = new System.Drawing.Point(644, 160);
            this.chkGridChange.Name = "chkGridChange";
            this.chkGridChange.Size = new System.Drawing.Size(16, 16);
            this.chkGridChange.TabIndex = 30;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(532, 160);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 24);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "Show Grid Change?";
            // 
            // chkSort
            // 
            this.chkSort.Location = new System.Drawing.Point(436, 160);
            this.chkSort.Name = "chkSort";
            this.chkSort.Size = new System.Drawing.Size(16, 16);
            this.chkSort.TabIndex = 28;
            this.chkSort.Text = "CheckBox1";
            // 
            // lblSort
            // 
            this.lblSort.Location = new System.Drawing.Point(332, 160);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(104, 24);
            this.lblSort.TabIndex = 27;
            this.lblSort.Text = "Sort Descending?";
            // 
            // lblCustomersCombo
            // 
            this.lblCustomersCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersCombo.Location = new System.Drawing.Point(36, 160);
            this.lblCustomersCombo.Name = "lblCustomersCombo";
            this.lblCustomersCombo.Size = new System.Drawing.Size(80, 24);
            this.lblCustomersCombo.TabIndex = 26;
            this.lblCustomersCombo.Text = "Customers:";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.Location = new System.Drawing.Point(124, 160);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(176, 21);
            this.cmbCustomers.TabIndex = 25;
            // 
            // dgCustomers
            // 
            this.dgCustomers.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dgCustomers.BackColor = System.Drawing.Color.Gainsboro;
            this.dgCustomers.BackgroundColor = System.Drawing.Color.Silver;
            this.dgCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCustomers.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dgCustomers.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dgCustomers.DataMember = "";
            this.dgCustomers.FlatMode = true;
            this.dgCustomers.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgCustomers.ForeColor = System.Drawing.Color.Black;
            this.dgCustomers.GridLineColor = System.Drawing.Color.DimGray;
            this.dgCustomers.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dgCustomers.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dgCustomers.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgCustomers.HeaderForeColor = System.Drawing.Color.White;
            this.dgCustomers.LinkColor = System.Drawing.Color.MidnightBlue;
            this.dgCustomers.Location = new System.Drawing.Point(28, 208);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ParentRowsBackColor = System.Drawing.Color.DarkGray;
            this.dgCustomers.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dgCustomers.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dgCustomers.SelectionForeColor = System.Drawing.Color.White;
            this.dgCustomers.Size = new System.Drawing.Size(640, 280);
            this.dgCustomers.TabIndex = 24;
            this.dgCustomers.CurrentCellChanged += new System.EventHandler(this.dgCustomers_CurrentCellChanged);
            // 
            // btnBindGrid
            // 
            this.btnBindGrid.Location = new System.Drawing.Point(490, 96);
            this.btnBindGrid.Name = "btnBindGrid";
            this.btnBindGrid.Size = new System.Drawing.Size(82, 21);
            this.btnBindGrid.TabIndex = 23;
            this.btnBindGrid.Text = "Bind Controls";
            this.btnBindGrid.Click += new System.EventHandler(this.btnBindGrid_Click);
            // 
            // btnCreateDataSet
            // 
            this.btnCreateDataSet.Location = new System.Drawing.Point(380, 96);
            this.btnCreateDataSet.Name = "btnCreateDataSet";
            this.btnCreateDataSet.Size = new System.Drawing.Size(81, 21);
            this.btnCreateDataSet.TabIndex = 22;
            this.btnCreateDataSet.Text = "Fill DataSet";
            this.btnCreateDataSet.Click += new System.EventHandler(this.btnCreateDataSet_Click);
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(252, 96);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(107, 21);
            this.btnCommand.TabIndex = 21;
            this.btnCommand.Text = "Create Command";
            this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(124, 96);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(107, 21);
            this.btnConnection.TabIndex = 20;
            this.btnConnection.Text = "Create Connection";
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lblConnString
            // 
            this.lblConnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnString.Location = new System.Drawing.Point(20, 8);
            this.lblConnString.Name = "lblConnString";
            this.lblConnString.Size = new System.Drawing.Size(104, 24);
            this.lblConnString.TabIndex = 19;
            this.lblConnString.Text = "Connection String:";
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(140, 8);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(464, 20);
            this.txtConnString.TabIndex = 18;
            this.txtConnString.Text = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            // 
            // frmData
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(704, 502);
            this.Controls.Add(this.lblDataView);
            this.Controls.Add(this.txtDataView);
            this.Controls.Add(this.chkGridChange);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.chkSort);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblCustomersCombo);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.dgCustomers);
            this.Controls.Add(this.btnBindGrid);
            this.Controls.Add(this.btnCreateDataSet);
            this.Controls.Add(this.btnCommand);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.lblConnString);
            this.Controls.Add(this.txtConnString);
            this.Name = "frmData";
            this.Text = "frmData";
            this.Load += new System.EventHandler(this.frmData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void btnConnection_Click(object sender, System.EventArgs e) {
			SqlConnection conn = null;
			try {
				conn = CreateConnection();
				conn.Open();
				MessageBox.Show("Connection created successfully");
			} catch (Exception exp) {
				MessageBox.Show("Connection not created successfully: " + exp.Message);
			} finally {
				if (conn.State != ConnectionState.Closed) conn.Close();
			}
		}

		private void btnCommand_Click(object sender, System.EventArgs e) {
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Field Names Returned from SqlDataReader:\r\n");
			SqlConnection sqlConnection = null;
			SqlDataReader sqlDataReader = null;
			try {
				sqlConnection = CreateConnection();
				sqlConnection.Open();
				sqlDataReader = new SqlCommand("SELECT * FROM Customers", sqlConnection).ExecuteReader();
				for (int i = 0; i < sqlDataReader.FieldCount; i++) {
					stringBuilder.Append(String.Concat(sqlDataReader.GetName(i).ToString(), "\r\n"));
				}
				MessageBox.Show(stringBuilder.ToString());
			}
			catch (Exception exp) {
				MessageBox.Show(String.Concat("Command not created successfully: ", exp.Message));
			}
			finally {
				sqlDataReader.Close();
				if (sqlConnection.State != ConnectionState.Closed) {
					sqlConnection.Close();
				}
			}
		}

		private SqlConnection CreateConnection() {
			SqlConnection conn;
			try {
				conn = new SqlConnection(txtConnString.Text);
			}
			catch (SqlException sqlExp) {
				throw new System.Exception("Connection string not valid: " + sqlExp.Message);
			}
			return conn;
		}

		private void btnCreateDataSet_Click(object sender, System.EventArgs e) {
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DataSet XML:\r\n");
			SqlConnection sqlConnection = null;

			try {
				sqlConnection = CreateConnection();
				sqlConnection.Open();
				SqlDataAdapter sqlDataAdapter = 
					new SqlDataAdapter("SELECT * FROM Customers", sqlConnection);
				DataSet dataSet = new DataSet();
				sqlDataAdapter.Fill(dataSet, "Customers");
				stringBuilder.Append(dataSet.GetXml());
				MessageBox.Show(stringBuilder.ToString());
			}
			catch (Exception exp) {
				MessageBox.Show(String.Concat("DataSet not created successfully: ", exp.Message));
			}
			finally {
				if (sqlConnection.State != ConnectionState.Closed) {
					sqlConnection.Close();
				}
			}
		}

		private void btnBindGrid_Click(object sender, System.EventArgs e) {
			CheckSortFilter();
			cmbCustomers.DisplayMember = "ContactName";
			cmbCustomers.ValueMember = "CustomerID";
			cmbCustomers.DataSource = view;
			dgCustomers.DataSource = view;
		}

		private void frmData_Load(object sender, System.EventArgs e) {
			SqlConnection sqlConnection = null;
			try {
				sqlConnection = CreateConnection();
				sqlConnection.Open();
				SqlDataAdapter sqlDataAdapter = 
					new SqlDataAdapter("SELECT * FROM Customers", sqlConnection);
				DataSet dataSet = new DataSet();
				sqlDataAdapter.Fill(dataSet, "Customers");
				view = new DataView(dataSet.Tables["Customers"]);
				cmbCustomers.DisplayMember = "ContactName";
				cmbCustomers.ValueMember = "CustomerID";
			}
			catch (Exception exp) {
				MessageBox.Show(String.Concat("DataView not filled successfully: ", exp.Message));
			}
			finally {
				if (sqlConnection.State != ConnectionState.Closed) {
					sqlConnection.Close();
				}
			}
		}

		private void dgCustomers_CurrentCellChanged(object sender, System.EventArgs e) {
			if (chkGridChange.Checked) {
                MessageBox.Show("Currently on row: " + dgCustomers.CurrentCell.RowNumber.ToString());
			}
		}

		private void CheckSortFilter() {
			if (chkSort.Checked) {
				view.Sort = "ContactName DESC";
			} else {
				view.Sort = "";
			}

			if (txtDataView.Text != String.Empty) {
				view.RowFilter = txtDataView.Text;
			}
			else {
				view.RowFilter = "";
			}
		}

	}
}
