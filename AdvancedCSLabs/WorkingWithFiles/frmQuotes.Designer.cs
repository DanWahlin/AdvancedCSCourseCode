namespace Lab10
{
    partial class frmQuotes
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
            this.lblNewQuote = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStreamReader = new System.Windows.Forms.Button();
            this.lblQuotes = new System.Windows.Forms.Label();
            this.txtNewQuote = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtFileText = new System.Windows.Forms.TextBox();
            this.btnFileStream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewQuote
            // 
            this.lblNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewQuote.Location = new System.Drawing.Point(11, 346);
            this.lblNewQuote.Name = "lblNewQuote";
            this.lblNewQuote.Size = new System.Drawing.Size(72, 16);
            this.lblNewQuote.TabIndex = 23;
            this.lblNewQuote.Text = "New Quote";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(483, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 32);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStreamReader
            // 
            this.btnStreamReader.Location = new System.Drawing.Point(483, 98);
            this.btnStreamReader.Name = "btnStreamReader";
            this.btnStreamReader.Size = new System.Drawing.Size(96, 32);
            this.btnStreamReader.TabIndex = 21;
            this.btnStreamReader.Text = "Read Quotes (StreamReader)";
            this.btnStreamReader.Click += new System.EventHandler(this.btnStreamReader_Click);
            // 
            // lblQuotes
            // 
            this.lblQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotes.Location = new System.Drawing.Point(11, 18);
            this.lblQuotes.Name = "lblQuotes";
            this.lblQuotes.Size = new System.Drawing.Size(72, 16);
            this.lblQuotes.TabIndex = 20;
            this.lblQuotes.Text = "Quotes";
            // 
            // txtNewQuote
            // 
            this.txtNewQuote.Location = new System.Drawing.Point(11, 370);
            this.txtNewQuote.Multiline = true;
            this.txtNewQuote.Name = "txtNewQuote";
            this.txtNewQuote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNewQuote.Size = new System.Drawing.Size(464, 40);
            this.txtNewQuote.TabIndex = 19;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(491, 378);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 32);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert Quote";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtFileText
            // 
            this.txtFileText.Location = new System.Drawing.Point(11, 42);
            this.txtFileText.Multiline = true;
            this.txtFileText.Name = "txtFileText";
            this.txtFileText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileText.Size = new System.Drawing.Size(464, 288);
            this.txtFileText.TabIndex = 17;
            // 
            // btnFileStream
            // 
            this.btnFileStream.Location = new System.Drawing.Point(483, 42);
            this.btnFileStream.Name = "btnFileStream";
            this.btnFileStream.Size = new System.Drawing.Size(96, 32);
            this.btnFileStream.TabIndex = 16;
            this.btnFileStream.Text = "Read Quotes (FileStream)";
            this.btnFileStream.Click += new System.EventHandler(this.btnFileStream_Click);
            // 
            // frmQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 430);
            this.Controls.Add(this.lblNewQuote);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStreamReader);
            this.Controls.Add(this.lblQuotes);
            this.Controls.Add(this.txtNewQuote);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtFileText);
            this.Controls.Add(this.btnFileStream);
            this.Name = "frmQuotes";
            this.Text = "frmQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblNewQuote;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnStreamReader;
        internal System.Windows.Forms.Label lblQuotes;
        internal System.Windows.Forms.TextBox txtNewQuote;
        internal System.Windows.Forms.Button btnInsert;
        internal System.Windows.Forms.TextBox txtFileText;
        internal System.Windows.Forms.Button btnFileStream;
    }
}