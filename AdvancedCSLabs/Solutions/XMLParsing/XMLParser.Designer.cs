namespace XMLParsing
{
    partial class XMLParser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblXmlFile = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtXmlFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnParseXml = new System.Windows.Forms.Button();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblXmlFile
            // 
            this.lblXmlFile.AutoSize = true;
            this.lblXmlFile.Location = new System.Drawing.Point(12, 23);
            this.lblXmlFile.Name = "lblXmlFile";
            this.lblXmlFile.Size = new System.Drawing.Size(51, 13);
            this.lblXmlFile.TabIndex = 0;
            this.lblXmlFile.Text = "XML File:";
            // 
            // ofd
            // 
            this.ofd.Filter = "XML files|*.xml";
            // 
            // txtXmlFile
            // 
            this.txtXmlFile.Enabled = false;
            this.txtXmlFile.Location = new System.Drawing.Point(69, 20);
            this.txtXmlFile.Name = "txtXmlFile";
            this.txtXmlFile.Size = new System.Drawing.Size(363, 20);
            this.txtXmlFile.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(438, 18);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(109, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select XML File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnParseXml
            // 
            this.btnParseXml.Location = new System.Drawing.Point(563, 18);
            this.btnParseXml.Name = "btnParseXml";
            this.btnParseXml.Size = new System.Drawing.Size(75, 23);
            this.btnParseXml.TabIndex = 3;
            this.btnParseXml.Text = "Parse Xml";
            this.btnParseXml.UseVisualStyleBackColor = true;
            this.btnParseXml.Click += new System.EventHandler(this.btnParseXml_Click);
            // 
            // txtProducts
            // 
            this.txtProducts.Location = new System.Drawing.Point(15, 81);
            this.txtProducts.Multiline = true;
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProducts.Size = new System.Drawing.Size(622, 407);
            this.txtProducts.TabIndex = 4;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(15, 62);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(52, 13);
            this.lblProducts.TabIndex = 5;
            this.lblProducts.Text = "Products:";
            // 
            // XMLParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 512);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.txtProducts);
            this.Controls.Add(this.btnParseXml);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtXmlFile);
            this.Controls.Add(this.lblXmlFile);
            this.Name = "XMLParser";
            this.Text = "Products XML Parser";
            this.Load += new System.EventHandler(this.XMLParser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXmlFile;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox txtXmlFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnParseXml;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.Label lblProducts;
    }
}

