namespace Chapter2
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;

    /// <summary>
    ///      Summary description for Form1.
    /// </summary>
    public class DirectorySearcherForm : System.Windows.Forms.Form
    {
        private DirectorySearcher directorySearcher;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;

        public DirectorySearcherForm()
        {
            //
            // Required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // Add any constructor code after InitializeComponent call here.
            //
        }

        #region Windows Form Designer generated code
        /// <summary>
        ///      Required method for designer support. Do not modify
        ///      the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directorySearcher = new DirectorySearcher();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.directorySearcher.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right);
            this.directorySearcher.Location = new System.Drawing.Point(8, 72);
            this.directorySearcher.SearchCriteria = null;
            this.directorySearcher.Size = new System.Drawing.Size(271, 173);
            this.directorySearcher.TabIndex = 2;
            this.directorySearcher.SearchComplete += new System.EventHandler(this.directorySearcher_SearchComplete);
            this.searchButton.Location = new System.Drawing.Point(8, 16);
            this.searchButton.Size = new System.Drawing.Size(88, 40);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "&Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right);
            this.searchText.Location = new System.Drawing.Point(104, 24);
            this.searchText.Size = new System.Drawing.Size(175, 20);
            this.searchText.TabIndex = 1;
            this.searchText.Text = "c:\\*.cs";
            this.searchLabel.ForeColor = System.Drawing.Color.Red;
            this.searchLabel.Location = new System.Drawing.Point(104, 48);
            this.searchLabel.Size = new System.Drawing.Size(176, 16);
            this.searchLabel.TabIndex = 3;
            this.ClientSize = new System.Drawing.Size(291, 264);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {this.searchLabel,
                                                        this.directorySearcher,
                                                        this.searchText,
                                                        this.searchButton});
            this.Text = "Search Directories";

        }
        #endregion

        /// <summary>
        ///    The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new DirectorySearcherForm());
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            directorySearcher.SearchCriteria = searchText.Text;
            searchLabel.Text = "Searching...";
            directorySearcher.BeginSearch();
        }

        private void directorySearcher_SearchComplete(object sender, System.EventArgs e)
        {
            searchLabel.Text = string.Empty;
        }
    }
}

