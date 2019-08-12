namespace Chapter7.EventsAndDelegates
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtStageInfo = new System.Windows.Forms.TextBox();
            this.lblStageInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(250, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(79, 14);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(146, 20);
            this.txtProdID.TabIndex = 1;
            this.txtProdID.Text = "2";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(12, 17);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID:";
            // 
            // txtStageInfo
            // 
            this.txtStageInfo.Location = new System.Drawing.Point(15, 75);
            this.txtStageInfo.Multiline = true;
            this.txtStageInfo.Name = "txtStageInfo";
            this.txtStageInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtStageInfo.Size = new System.Drawing.Size(325, 268);
            this.txtStageInfo.TabIndex = 3;
            // 
            // lblStageInfo
            // 
            this.lblStageInfo.AutoSize = true;
            this.lblStageInfo.Location = new System.Drawing.Point(12, 59);
            this.lblStageInfo.Name = "lblStageInfo";
            this.lblStageInfo.Size = new System.Drawing.Size(163, 13);
            this.lblStageInfo.TabIndex = 4;
            this.lblStageInfo.Text = "Assembly Line Stage Information:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 355);
            this.Controls.Add(this.lblStageInfo);
            this.Controls.Add(this.txtStageInfo);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Assembly Line Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtStageInfo;
        private System.Windows.Forms.Label lblStageInfo;
    }
}

