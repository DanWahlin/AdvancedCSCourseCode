namespace FCLClasses
{
    partial class LinkExtractor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.fpnlLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(60, 17);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(326, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://msdn.microsoft.com";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(402, 15);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Extract Links";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // fpnlLinks
            // 
            this.fpnlLinks.AutoScroll = true;
            this.fpnlLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlLinks.Location = new System.Drawing.Point(15, 74);
            this.fpnlLinks.Name = "fpnlLinks";
            this.fpnlLinks.Size = new System.Drawing.Size(486, 434);
            this.fpnlLinks.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Links";
            // 
            // LinkExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fpnlLinks);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Name = "LinkExtractor";
            this.Text = "Link Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.FlowLayoutPanel fpnlLinks;
        private System.Windows.Forms.Label label2;
    }
}

