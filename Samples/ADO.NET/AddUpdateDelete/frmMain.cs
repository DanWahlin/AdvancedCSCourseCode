using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataDemos.AddUpdateDelete {
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form {

        private string ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
		private bool HasConnected = false;
		private string Mode  = "Update";

		internal System.Windows.Forms.Button btnRefresh;
		internal System.Windows.Forms.Label lblProductList;
		internal System.Windows.Forms.Button btnDelete;
		internal System.Windows.Forms.Button btnUpdate;
		internal System.Windows.Forms.MainMenu mnuMain;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem mnuExit;
		internal System.Windows.Forms.Button btnAdd;
		internal System.Windows.Forms.GroupBox gbHorvRule;
		internal System.Windows.Forms.Label lblQtyPerUnit;
		internal System.Windows.Forms.Label lblReorderLevel;
		internal System.Windows.Forms.Label lblUnitsOnOrder;
		internal System.Windows.Forms.Label lblUnitsInStock;
		internal System.Windows.Forms.Label lblUnitPrice;
		internal System.Windows.Forms.Label lblCategories;
		internal System.Windows.Forms.Label lblSuppliers;
		internal System.Windows.Forms.Label lblProductName;
		internal System.Windows.Forms.Label lblProductID;
		internal System.Windows.Forms.ListBox lstProducts;
		internal System.Windows.Forms.CheckBox chkDiscontinued;
		internal System.Windows.Forms.ComboBox cbCategories;
		internal System.Windows.Forms.ComboBox cbSuppliers;
		internal System.Windows.Forms.TextBox txtQtyPerUnit;
		internal System.Windows.Forms.TextBox txtReorderLevel;
		internal System.Windows.Forms.TextBox txtUnitsInStock;
		internal System.Windows.Forms.TextBox txtUnitsOnOrder;
		internal System.Windows.Forms.TextBox txtUnitPrice;
		internal System.Windows.Forms.TextBox txtProductName;
		internal System.Windows.Forms.TextBox txtProductID;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain() {
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
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		public static void Main() {
			Application.Run(new frmMain());
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnRefresh = new System.Windows.Forms.Button();
			this.lblProductList = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.mnuMain = new System.Windows.Forms.MainMenu();
			this.MenuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gbHorvRule = new System.Windows.Forms.GroupBox();
			this.lblQtyPerUnit = new System.Windows.Forms.Label();
			this.lblReorderLevel = new System.Windows.Forms.Label();
			this.lblUnitsOnOrder = new System.Windows.Forms.Label();
			this.lblUnitsInStock = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblCategories = new System.Windows.Forms.Label();
			this.lblSuppliers = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblProductID = new System.Windows.Forms.Label();
			this.lstProducts = new System.Windows.Forms.ListBox();
			this.chkDiscontinued = new System.Windows.Forms.CheckBox();
			this.cbCategories = new System.Windows.Forms.ComboBox();
			this.cbSuppliers = new System.Windows.Forms.ComboBox();
			this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
			this.txtReorderLevel = new System.Windows.Forms.TextBox();
			this.txtUnitsInStock = new System.Windows.Forms.TextBox();
			this.txtUnitsOnOrder = new System.Windows.Forms.TextBox();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnRefresh
			// 
			this.btnRefresh.AccessibleDescription = "Refresh Button";
			this.btnRefresh.AccessibleName = "Refresh Button";
			this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnRefresh.Location = new System.Drawing.Point(456, 147);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(88, 27);
			this.btnRefresh.TabIndex = 48;
			this.btnRefresh.Text = "&Refresh";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// lblProductList
			// 
			this.lblProductList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblProductList.Location = new System.Drawing.Point(33, 12);
			this.lblProductList.Name = "lblProductList";
			this.lblProductList.Size = new System.Drawing.Size(84, 19);
			this.lblProductList.TabIndex = 23;
			this.lblProductList.Text = "Product List";
			// 
			// btnDelete
			// 
			this.btnDelete.AccessibleDescription = "Delete Button";
			this.btnDelete.AccessibleName = "Delete Button";
			this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnDelete.Location = new System.Drawing.Point(454, 106);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(88, 27);
			this.btnDelete.TabIndex = 47;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.AccessibleDescription = "Update Button";
			this.btnUpdate.AccessibleName = "Update Button";
			this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnUpdate.Location = new System.Drawing.Point(454, 68);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 27);
			this.btnUpdate.TabIndex = 46;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// mnuMain
			// 
			this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.MenuItem1});
			// 
			// MenuItem1
			// 
			this.MenuItem1.Index = 0;
			this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuExit});
			this.MenuItem1.Text = "&File";
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 0;
			this.mnuExit.Text = "E&xit";
			// 
			// btnAdd
			// 
			this.btnAdd.AccessibleDescription = "Add Button";
			this.btnAdd.AccessibleName = "Add Button";
			this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnAdd.Location = new System.Drawing.Point(454, 31);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(88, 27);
			this.btnAdd.TabIndex = 44;
			this.btnAdd.Text = "&Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// gbHorvRule
			// 
			this.gbHorvRule.Location = new System.Drawing.Point(436, 12);
			this.gbHorvRule.Name = "gbHorvRule";
			this.gbHorvRule.Size = new System.Drawing.Size(9, 327);
			this.gbHorvRule.TabIndex = 45;
			this.gbHorvRule.TabStop = false;
			// 
			// lblQtyPerUnit
			// 
			this.lblQtyPerUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblQtyPerUnit.Location = new System.Drawing.Point(33, 293);
			this.lblQtyPerUnit.Name = "lblQtyPerUnit";
			this.lblQtyPerUnit.Size = new System.Drawing.Size(84, 19);
			this.lblQtyPerUnit.TabIndex = 41;
			this.lblQtyPerUnit.Text = "Qty Per Unit";
			// 
			// lblReorderLevel
			// 
			this.lblReorderLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblReorderLevel.Location = new System.Drawing.Point(229, 246);
			this.lblReorderLevel.Name = "lblReorderLevel";
			this.lblReorderLevel.Size = new System.Drawing.Size(95, 18);
			this.lblReorderLevel.TabIndex = 37;
			this.lblReorderLevel.Text = "Reorder Level";
			// 
			// lblUnitsOnOrder
			// 
			this.lblUnitsOnOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblUnitsOnOrder.Location = new System.Drawing.Point(333, 246);
			this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
			this.lblUnitsOnOrder.Size = new System.Drawing.Size(93, 18);
			this.lblUnitsOnOrder.TabIndex = 39;
			this.lblUnitsOnOrder.Text = "Units On Order";
			// 
			// lblUnitsInStock
			// 
			this.lblUnitsInStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblUnitsInStock.Location = new System.Drawing.Point(229, 199);
			this.lblUnitsInStock.Name = "lblUnitsInStock";
			this.lblUnitsInStock.Size = new System.Drawing.Size(95, 19);
			this.lblUnitsInStock.TabIndex = 30;
			this.lblUnitsInStock.Text = "Units In Stock";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblUnitPrice.Location = new System.Drawing.Point(333, 199);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(84, 19);
			this.lblUnitPrice.TabIndex = 32;
			this.lblUnitPrice.Tag = "";
			this.lblUnitPrice.Text = "Unit Price";
			// 
			// lblCategories
			// 
			this.lblCategories.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblCategories.Location = new System.Drawing.Point(33, 246);
			this.lblCategories.Name = "lblCategories";
			this.lblCategories.Size = new System.Drawing.Size(84, 18);
			this.lblCategories.TabIndex = 34;
			this.lblCategories.Text = "Categories";
			// 
			// lblSuppliers
			// 
			this.lblSuppliers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblSuppliers.Location = new System.Drawing.Point(33, 199);
			this.lblSuppliers.Name = "lblSuppliers";
			this.lblSuppliers.Size = new System.Drawing.Size(84, 19);
			this.lblSuppliers.TabIndex = 28;
			this.lblSuppliers.Text = "Suppliers";
			// 
			// lblProductName
			// 
			this.lblProductName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblProductName.Location = new System.Drawing.Point(127, 153);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(168, 19);
			this.lblProductName.TabIndex = 26;
			this.lblProductName.Text = "Product Name";
			// 
			// lblProductID
			// 
			this.lblProductID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblProductID.Location = new System.Drawing.Point(33, 153);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(84, 19);
			this.lblProductID.TabIndex = 35;
			this.lblProductID.Text = "Product ID";
			// 
			// lstProducts
			// 
			this.lstProducts.AccessibleDescription = "Listing of products";
			this.lstProducts.AccessibleName = "Product List";
			this.lstProducts.Location = new System.Drawing.Point(33, 31);
			this.lstProducts.Name = "lstProducts";
			this.lstProducts.Size = new System.Drawing.Size(393, 82);
			this.lstProducts.TabIndex = 25;
			this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
			// 
			// chkDiscontinued
			// 
			this.chkDiscontinued.AccessibleDescription = "Discontinued Check box";
			this.chkDiscontinued.AccessibleName = "Discontinued";
			this.chkDiscontinued.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkDiscontinued.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.chkDiscontinued.Location = new System.Drawing.Point(276, 302);
			this.chkDiscontinued.Name = "chkDiscontinued";
			this.chkDiscontinued.Size = new System.Drawing.Size(112, 37);
			this.chkDiscontinued.TabIndex = 43;
			this.chkDiscontinued.Text = "Discontinued";
			// 
			// cbCategories
			// 
			this.cbCategories.AccessibleDescription = "Categories Combo box";
			this.cbCategories.AccessibleName = "Categories";
			this.cbCategories.ItemHeight = 13;
			this.cbCategories.Location = new System.Drawing.Point(33, 264);
			this.cbCategories.Name = "cbCategories";
			this.cbCategories.Size = new System.Drawing.Size(169, 21);
			this.cbCategories.TabIndex = 36;
			// 
			// cbSuppliers
			// 
			this.cbSuppliers.AccessibleDescription = "Suppliers Combo box";
			this.cbSuppliers.AccessibleName = "Suppliers";
			this.cbSuppliers.ItemHeight = 13;
			this.cbSuppliers.Location = new System.Drawing.Point(33, 218);
			this.cbSuppliers.Name = "cbSuppliers";
			this.cbSuppliers.Size = new System.Drawing.Size(169, 21);
			this.cbSuppliers.TabIndex = 29;
			// 
			// txtQtyPerUnit
			// 
			this.txtQtyPerUnit.AccessibleDescription = "Quantity Per Unit Text Box";
			this.txtQtyPerUnit.AccessibleName = "Quantity Per Unit Text Box";
			this.txtQtyPerUnit.Location = new System.Drawing.Point(33, 312);
			this.txtQtyPerUnit.Name = "txtQtyPerUnit";
			this.txtQtyPerUnit.Size = new System.Drawing.Size(216, 20);
			this.txtQtyPerUnit.TabIndex = 42;
			this.txtQtyPerUnit.Text = "";
			// 
			// txtReorderLevel
			// 
			this.txtReorderLevel.AccessibleDescription = "Reorder Level text box";
			this.txtReorderLevel.AccessibleName = "Reorder LEvel";
			this.txtReorderLevel.Location = new System.Drawing.Point(229, 264);
			this.txtReorderLevel.Name = "txtReorderLevel";
			this.txtReorderLevel.Size = new System.Drawing.Size(75, 20);
			this.txtReorderLevel.TabIndex = 38;
			this.txtReorderLevel.Text = "";
			// 
			// txtUnitsInStock
			// 
			this.txtUnitsInStock.AccessibleDescription = "Units In Stock Text box";
			this.txtUnitsInStock.AccessibleName = "Units In Stock";
			this.txtUnitsInStock.Location = new System.Drawing.Point(229, 218);
			this.txtUnitsInStock.Name = "txtUnitsInStock";
			this.txtUnitsInStock.Size = new System.Drawing.Size(75, 20);
			this.txtUnitsInStock.TabIndex = 31;
			this.txtUnitsInStock.Text = "";
			// 
			// txtUnitsOnOrder
			// 
			this.txtUnitsOnOrder.AccessibleDescription = "Units on Order text box";
			this.txtUnitsOnOrder.AccessibleName = "Units on Order";
			this.txtUnitsOnOrder.Location = new System.Drawing.Point(333, 264);
			this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
			this.txtUnitsOnOrder.Size = new System.Drawing.Size(75, 20);
			this.txtUnitsOnOrder.TabIndex = 40;
			this.txtUnitsOnOrder.Text = "";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.AccessibleDescription = "Unit Price Text box";
			this.txtUnitPrice.AccessibleName = "Unit Price";
			this.txtUnitPrice.Location = new System.Drawing.Point(333, 218);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(75, 20);
			this.txtUnitPrice.TabIndex = 33;
			this.txtUnitPrice.Text = "";
			// 
			// txtProductName
			// 
			this.txtProductName.AccessibleDescription = "Product Name Text box";
			this.txtProductName.AccessibleName = "Product Name";
			this.txtProductName.Location = new System.Drawing.Point(127, 172);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(299, 20);
			this.txtProductName.TabIndex = 27;
			this.txtProductName.Text = "";
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(33, 172);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.ReadOnly = true;
			this.txtProductID.Size = new System.Drawing.Size(84, 20);
			this.txtProductID.TabIndex = 24;
			this.txtProductID.Text = "";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 350);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblProductList,
																		  this.btnDelete,
																		  this.btnUpdate,
																		  this.btnAdd,
																		  this.gbHorvRule,
																		  this.lblQtyPerUnit,
																		  this.lblReorderLevel,
																		  this.lblUnitsOnOrder,
																		  this.lblUnitsInStock,
																		  this.lblUnitPrice,
																		  this.lblCategories,
																		  this.lblSuppliers,
																		  this.lblProductName,
																		  this.lblProductID,
																		  this.lstProducts,
																		  this.chkDiscontinued,
																		  this.cbCategories,
																		  this.cbSuppliers,
																		  this.txtQtyPerUnit,
																		  this.txtReorderLevel,
																		  this.txtUnitsInStock,
																		  this.txtUnitsOnOrder,
																		  this.txtUnitPrice,
																		  this.txtProductName,
																		  this.txtProductID,
																		  this.btnRefresh});
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAdd_Click(object sender, System.EventArgs e) {
			ClearForm();
			Mode = "Add";

			btnDelete.Enabled = false;
			btnAdd.Enabled = false;
		}

		private void btnUpdate_Click(object sender, System.EventArgs e) {
			//Check mode to determine action
			if ( Mode == "Add") {
				AddProduct();
			} else {
				UpdateProduct();
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e) {
			DeleteProduct();
		}

		private void btnRefresh_Click(object sender, System.EventArgs e) {
			RefreshControls();
		}

		private void RefreshControls() {
			PopulateCategoryCombo();
			PopulateSupplierCombo();
			PopulateProductList();
		}

        private void AddProduct() {
            // This  is used to add a product record to the database
            // when the user clicks the Update button and the mode is set
            // to ADD

            // Validate form values.
            if (!IsValidForm())  {
                this.Close(); 
            }

            SqlConnection cnSQL = null;
            SqlCommand cmSQL = null;
            String strSQL = null;

            String ProductName  = txtProductName.Text;

            try {
                // Build Insert statement to insert new product into the products table
                strSQL = "INSERT Products VALUES (" +
                         PrepareStr(ProductName) + "," +
                         ((ListItem)cbSuppliers.Items[cbSuppliers.SelectedIndex]).ID + "," +
                         ((ListItem)cbCategories.Items[cbCategories.SelectedIndex]).ID + "," +
                         PrepareStr(txtQtyPerUnit.Text) + "," +
                         txtUnitPrice.Text + "," +
                         txtUnitsInStock.Text + "," +
                         txtUnitsOnOrder.Text + "," +
                         txtReorderLevel.Text + "," +
						 (string)((chkDiscontinued.Checked)?"1":"0") + ")";


                cnSQL = new SqlConnection(ConnectionString);
                cnSQL.Open();

                cmSQL = new SqlCommand(strSQL, cnSQL);
                cmSQL.ExecuteNonQuery();

                // Close and Clean up objects
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();

                // Refresh Product List
                PopulateProductList();
                FindProductByName(lstProducts, ProductName);

            } catch  (SqlException Exp) {
                MessageBox.Show(Exp.Message);

            } catch  (Exception Exp) {
                MessageBox.Show(Exp.Message);
            }
        }

        private void ClearForm() {

            // Clear the data entry form.
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtQtyPerUnit.Text = "";
            txtUnitPrice.Text = "0.00";
            txtUnitsInStock.Text = "0";
            txtUnitsOnOrder.Text = "0";
            txtReorderLevel.Text = "0";
            chkDiscontinued.Checked = false;
            cbSuppliers.SelectedIndex = -1;
            cbCategories.SelectedIndex = -1;

        }

        private void DeleteProduct() {
            // This  is used to delete the product record from the database
            // when the user clicks the delete button

            SqlConnection cnSQL = null;
            SqlCommand cmSQL = null;
            String strSQL = null;
            int intRowsAffected;
            DialogResult  response  = 
                MessageBox.Show("Are you sure you'd like to delete this product?","Delete?",MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes) {
                try {
                    // Build Delete statement to delete the current product from table
                    strSQL = "DELETE FROM Products " +
                             "WHERE ProductID = " + Int32.Parse(txtProductID.Text);

                    cnSQL = new SqlConnection(ConnectionString);
                    cnSQL.Open();

                    cmSQL = new SqlCommand(strSQL, cnSQL);
                    intRowsAffected = cmSQL.ExecuteNonQuery();

                    if ( intRowsAffected != 1) {
                        MessageBox.Show("Delete Failed. Product ID " + txtProductID.Text +
                               " not found.");
                    }

                    // Close and Clean up objects
                    cnSQL.Close();
                    cmSQL.Dispose();
                    cnSQL.Dispose();
                    PopulateProductList();
                } catch  (SqlException e) {
                    MessageBox.Show(e.Message);

                } catch  (Exception e) { 
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void  FindItemByID(ComboBox cbCombo, string strID) {
            // This  is used to find an Item in a combobox and
            // set the selected index of the combo box to that item
            bool bFound = false;
            ListItem listItem = null;
            int ItemCount;

            listItem = new ListItem();

            ItemCount = 0;
			while (!bFound || ItemCount <= cbCombo.Items.Count - 1) {
				listItem = (ListItem)cbCombo.Items[ItemCount];

				if (listItem.ID == Int32.Parse(strID))  {
					cbCombo.SelectedIndex = ItemCount;
					bFound = true;
				}
				ItemCount += 1;
			}

            if ( !bFound)  {
                cbCombo.SelectedIndex = -1;
            }

        }

        private void FindProductByName(ListBox lbList,String strValue) {
            // This  is used to find a Product in the product
            // list box and set the selected index of the list box
            // to that item

            bool bIsFound = false;
            ListItem listItem = null;
            int ItemCount;

            listItem = new ListItem();

            ItemCount = 0;
            // } through the list until the item is found
			while (!bIsFound || ItemCount <= lbList.Items.Count - 1) {
				listItem = (ListItem)lbList.Items[ItemCount];

				if ( listItem.Value == strValue)  {
					lbList.SelectedIndex = ItemCount;
					bIsFound = true;
				}
				ItemCount += 1;
			}

            if ( !bIsFound)  {
                lbList.SelectedIndex = 0;
            }

        }

        private bool IsValidForm() {
            // Check to make sure each field ha valid value
            if ( txtProductName.Text == "" ||
               txtQtyPerUnit.Text == "" ||
               txtUnitPrice.Text == "" ||
               txtUnitsInStock.Text == "" ||
               txtUnitsOnOrder.Text == "" ||
               txtReorderLevel.Text == "" ||
               cbCategories.SelectedIndex == -1 ||
               cbSuppliers.SelectedIndex == -1 ||
               !IsNumeric(txtUnitPrice.Text) ||
               !IsNumeric(txtUnitsInStock.Text) ||
               !IsNumeric(txtUnitsOnOrder.Text) ||
               !IsNumeric(txtReorderLevel.Text))  {

                MessageBox.Show("Please enter a valid value for each field.");
                return false;
            } else {
                return true;
            }
        }

		private bool IsNumeric(string val) {
			try {
				Double.Parse(val);
				return true;
			}
			catch {
				return false;
			}
		}

        private void PopulateCategoryCombo() {
            // This procedure populates the list box on the
            // form with a list of Categories from the
            // Northwind database.

            SqlConnection cnSQL = null;
            SqlCommand cmSQL = null;
            SqlDataReader drSQL = null;
            String strSQL = null;
            ListItem objListItem = null;

            try {
                // Build Select statement to query Category Name from the Categories
                // table.
                strSQL = "SELECT CategoryID, CategoryName FROM Categories";

                cnSQL = new SqlConnection(ConnectionString);
                cnSQL.Open();

                cmSQL = new SqlCommand(strSQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();

                cbCategories.Items.Clear();

                // } through the result set and add the category 
                // names to the combo box.
                while ( drSQL.Read()) {
                    objListItem = new ListItem(drSQL["CategoryName"].ToString(),
                                               Int32.Parse(drSQL["CategoryID"].ToString()));
                    cbCategories.Items.Add(objListItem);
                }

                HasConnected = true;

                // Close and Clean up objects
                drSQL.Close();
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();

            } catch  (SqlException e) {
                MessageBox.Show(e.Message);
            } catch  (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void PopulateForm() {
            SqlConnection cnSQL = null;
            SqlCommand cmSQL = null;
            SqlDataReader drSQL = null;
            String strSQL = null;
            ListItem objListItem = null;
            String strID = null;

            try {

                // Get Primary Key from Listbox
                objListItem = (ListItem)lstProducts.SelectedItem;

                // Build Select statement to query product information from the products
                // table 
                strSQL = "SELECT ProductID, " +
                         "       ProductName, " +
                         "       QuantityPerUnit, " +
                         "       UnitPrice, " +
                         "       UnitsInStock, " +
                         "       UnitsOnOrder, " +
                         "       ReorderLevel, " +
                         "       Discontinued, " +
                         "       SupplierID, " +
                         "       CategoryID " +
                         "FROM Products " +
                         "WHERE ProductID = " + objListItem.ID;

                cnSQL = new SqlConnection(ConnectionString);
                cnSQL.Open();

                cmSQL = new SqlCommand(strSQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();

                if ( drSQL.Read())  {
                    // Populate form with the data
                    txtProductID.Text = drSQL["ProductID"].ToString();
                    txtProductName.Text = drSQL["ProductName"].ToString();
                    txtQtyPerUnit.Text = drSQL["QuantityPerUnit"].ToString();
                    txtUnitPrice.Text = drSQL["UnitPrice"].ToString();
                    txtUnitsInStock.Text = drSQL["UnitsInStock"].ToString();
                    txtUnitsOnOrder.Text = drSQL["UnitsOnOrder"].ToString();
                    txtReorderLevel.Text = drSQL["ReorderLevel"].ToString();
                    chkDiscontinued.Checked = Convert.ToBoolean(drSQL["Discontinued"].ToString());
                    strID = drSQL["SupplierID"].ToString();
                    FindItemByID(cbSuppliers, strID);
                    strID = drSQL["CategoryID"].ToString();
                    FindItemByID(cbCategories, strID);
                }

                // Close and Clean up objects
                drSQL.Close();
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();

            } catch  (SqlException e) {
                MessageBox.Show(e.Message);

            } catch  (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void PopulateProductList() {
            // This procedure populates the list box on the
            // form with a list of available products from the
            // Northwind database.

            SqlConnection cnSQL = null;
            SqlCommand cmSQL = null;
            SqlDataReader drSQL = null;
            String strSQL = null;
            ListItem objListItem = null;

            try {
                // Build Select statement to query product names from the products
                // table.
                strSQL = "SELECT ProductName, ProductID FROM Products";

                cnSQL = new SqlConnection(ConnectionString);
                cnSQL.Open();

                cmSQL = new SqlCommand(strSQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();

                lstProducts.Items.Clear();

                // } through the result set using the datareader class.  
                // The datareader is used here because all that is needed 
                // is a forward only cursor which is more efficient.             
                while ( drSQL.Read()) {
                    objListItem = new ListItem(drSQL["ProductName"].ToString(), 
                                               Int32.Parse(drSQL["ProductID"].ToString()));
                    lstProducts.Items.Add(objListItem);
                }

                if ( lstProducts.Items.Count > 0)  {
                    lstProducts.SetSelected(0, true);
                }

                // Close and Clean up objects
                drSQL.Close();
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();

            } catch  (SqlException e) {
                MessageBox.Show(e.Message);

            } catch  (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void  PopulateSupplierCombo() {
            // This procedure populates the supplier combo box
            // on the form with a list of available Suppliers 
            // from the Northwind database.

            SqlConnection cnSQL = null;
            SqlCommand cmSQL = null;
            SqlDataReader drSQL = null;
            String strSQL = null; 
            ListItem objListItem = null;

            try {
                // Build Select statement to query Suppliers Name from the Suppliers
                // table.
                strSQL = "SELECT SupplierID, CompanyName FROM Suppliers";

                cnSQL = new SqlConnection(ConnectionString);
                cnSQL.Open();

                cmSQL = new SqlCommand(strSQL, cnSQL);
                drSQL = cmSQL.ExecuteReader();

                cbSuppliers.Items.Clear();

                // } through the result set and add the supplier names to the combo
                // box.
                while ( drSQL.Read()) {
                    objListItem = new ListItem(drSQL["CompanyName"].ToString(), 
                                               Int32.Parse(drSQL["SupplierID"].ToString()));
                    cbSuppliers.Items.Add(objListItem);
                }

                // Close and Clean up objects
                drSQL.Close();
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();

            } catch  (SqlException e) {
                MessageBox.Show(e.Message);

            } catch  (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private string PrepareStr(String strValue ) {
            // This  accepts a string and creates a string that can
            // be used in a SQL statement by adding single quotes around
            // it and handling empty values.
            if ( strValue.Trim() == "")  {
                return "NULL";
            } else {
                return "'" + strValue.Trim() + "'";
            }
        } 

        private void  UpdateProduct() {
            // This  is used to update and existing record with values
            // from the form.
            SqlConnection cnSQL = null; 
            SqlCommand cmSQL = null;
            String strSQL = null;
            int intRowsAffected;

            // Validate form values.
            if ( !IsValidForm())  {
                this.Close(); 
            }

            try {
                // Build update statement to update product table with data
                // on form.
                strSQL = "UPDATE Products SET" +
                         " ProductName = " + PrepareStr(txtProductName.Text) +
                         " ,QuantityPerUnit = " + PrepareStr(txtQtyPerUnit.Text) +
                         " ,UnitPrice = " + txtUnitPrice.Text +
                         " ,UnitsInStock = " + txtUnitsInStock.Text +
                         " ,UnitsOnOrder = " + txtUnitsOnOrder.Text +
                         " ,ReorderLevel = " + txtReorderLevel.Text +
                         " ,SupplierID = " + ((ListItem)cbSuppliers.Items[cbSuppliers.SelectedIndex]).ID +
                         " ,CategoryID = " + ((ListItem)cbCategories.Items[cbCategories.SelectedIndex]).ID +
					" ,Discontinued = " + ((chkDiscontinued.Checked) ? "1": "0") + " " +
                         "WHERE ProductID = " + Int32.Parse(txtProductID.Text);

                cnSQL = new SqlConnection(ConnectionString);
                cnSQL.Open();

                cmSQL = new SqlCommand(strSQL, cnSQL);
                intRowsAffected = cmSQL.ExecuteNonQuery();

                if ( intRowsAffected != 1)  {
                    MessageBox.Show("Update Failed.");
                }

                // Close and Clean up objects
                cnSQL.Close();
                cmSQL.Dispose();
                cnSQL.Dispose();
                PopulateProductList();
            } catch  (SqlException e) {
                MessageBox.Show(e.Message);

            } catch  (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

		private void frmMain_Load(object sender, System.EventArgs e) {
			PopulateCategoryCombo();
            PopulateSupplierCombo();
            PopulateProductList();
		}

		private void lstProducts_SelectedIndexChanged(object sender, System.EventArgs e) {
			PopulateForm();
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            Mode = "Update";
		}
	}
}