namespace Chapter2.Compression
{
    public partial class GZipDemo
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog ( );
            this.Compress = new System.Windows.Forms.Button ( );
            this.Decompress = new System.Windows.Forms.Button ( );
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.DestinationFile = new System.Windows.Forms.TextBox ( );
            this.BrowseDestination = new System.Windows.Forms.Button ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.SourceFile = new System.Windows.Forms.TextBox ( );
            this.BrowseSource = new System.Windows.Forms.Button ( );
            this.groupBox1.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Compress
            // 
            this.Compress.Location = new System.Drawing.Point ( 121, 118 );
            this.Compress.Name = "Compress";
            this.Compress.Size = new System.Drawing.Size ( 98, 23 );
            this.Compress.TabIndex = 7;
            this.Compress.Text = "Compress";
            this.Compress.Click += new System.EventHandler ( this.Compress_Click );
            // 
            // Decompress
            // 
            this.Decompress.Location = new System.Drawing.Point ( 241, 118 );
            this.Decompress.Name = "Decompress";
            this.Decompress.Size = new System.Drawing.Size ( 98, 23 );
            this.Decompress.TabIndex = 8;
            this.Decompress.Text = "Decompress";
            this.Decompress.Click += new System.EventHandler ( this.Decompress_Click );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add ( this.label2 );
            this.groupBox1.Controls.Add ( this.DestinationFile );
            this.groupBox1.Controls.Add ( this.BrowseDestination );
            this.groupBox1.Controls.Add ( this.label1 );
            this.groupBox1.Controls.Add ( this.SourceFile );
            this.groupBox1.Controls.Add ( this.BrowseSource );
            this.groupBox1.Location = new System.Drawing.Point ( 12, 12 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size ( 435, 100 );
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point ( 11, 61 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size ( 78, 13 );
            this.label2.TabIndex = 12;
            this.label2.Text = "Destination File:";
            // 
            // DestinationFile
            // 
            this.DestinationFile.Location = new System.Drawing.Point ( 96, 58 );
            this.DestinationFile.Name = "DestinationFile";
            this.DestinationFile.Size = new System.Drawing.Size ( 236, 20 );
            this.DestinationFile.TabIndex = 11;
            // 
            // BrowseDestination
            // 
            this.BrowseDestination.Location = new System.Drawing.Point ( 348, 56 );
            this.BrowseDestination.Name = "BrowseDestination";
            this.BrowseDestination.Size = new System.Drawing.Size ( 75, 23 );
            this.BrowseDestination.TabIndex = 10;
            this.BrowseDestination.Text = "Browse";
            this.BrowseDestination.Click += new System.EventHandler ( this.BrowseDestination_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point ( 11, 26 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size ( 59, 13 );
            this.label1.TabIndex = 9;
            this.label1.Text = "Source File:";
            // 
            // SourceFile
            // 
            this.SourceFile.Location = new System.Drawing.Point ( 96, 23 );
            this.SourceFile.Name = "SourceFile";
            this.SourceFile.Size = new System.Drawing.Size ( 236, 20 );
            this.SourceFile.TabIndex = 8;
            // 
            // BrowseSource
            // 
            this.BrowseSource.Location = new System.Drawing.Point ( 348, 21 );
            this.BrowseSource.Name = "BrowseSource";
            this.BrowseSource.Size = new System.Drawing.Size ( 75, 23 );
            this.BrowseSource.TabIndex = 7;
            this.BrowseSource.Text = "Browse";
            this.BrowseSource.Click += new System.EventHandler ( this.BrowseSource_Click );
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size ( 461, 157 );
            this.Controls.Add ( this.groupBox1 );
            this.Controls.Add ( this.Decompress );
            this.Controls.Add ( this.Compress );
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compression Sample";
            this.groupBox1.ResumeLayout ( false );
            this.groupBox1.PerformLayout ( );
            this.ResumeLayout ( false );

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Compress;
        private System.Windows.Forms.Button Decompress;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DestinationFile;
        private System.Windows.Forms.Button BrowseDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SourceFile;
        private System.Windows.Forms.Button BrowseSource;
    }
}

