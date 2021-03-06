namespace Chapter2.FTP
{
	public partial class FTPDemo
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.Download = new System.Windows.Forms.Button();
			this.downloadURI = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Browse2 = new System.Windows.Forms.Button();
			this.DownloadFileName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.SetCredentials = new System.Windows.Forms.Button();
			this.password = new System.Windows.Forms.TextBox();
			this.userName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.Download);
			this.groupBox2.Controls.Add(this.downloadURI);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.Browse2);
			this.groupBox2.Controls.Add(this.DownloadFileName);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(437, 136);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Download";
			// 
			// Download
			// 
			this.Download.Location = new System.Drawing.Point(353, 69);
			this.Download.Name = "Download";
			this.Download.Size = new System.Drawing.Size(75, 23);
			this.Download.TabIndex = 6;
			this.Download.Text = "Download";
			this.Download.Click += new System.EventHandler(this.Download_Click);
			// 
			// downloadURI
			// 
			this.downloadURI.Location = new System.Drawing.Point(46, 67);
			this.downloadURI.Name = "downloadURI";
			this.downloadURI.Size = new System.Drawing.Size(292, 20);
			this.downloadURI.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "File:";
			// 
			// Browse2
			// 
			this.Browse2.Location = new System.Drawing.Point(353, 31);
			this.Browse2.Name = "Browse2";
			this.Browse2.Size = new System.Drawing.Size(75, 23);
			this.Browse2.TabIndex = 6;
			this.Browse2.Text = "Browse";
			this.Browse2.Click += new System.EventHandler(this.Browse2_Click);
			// 
			// DownloadFileName
			// 
			this.DownloadFileName.Location = new System.Drawing.Point(46, 33);
			this.DownloadFileName.Name = "DownloadFileName";
			this.DownloadFileName.Size = new System.Drawing.Size(292, 20);
			this.DownloadFileName.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Uri:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(22, 164);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(128, 17);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Use Anonomous User:";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.SetCredentials);
			this.groupBox3.Controls.Add(this.password);
			this.groupBox3.Controls.Add(this.userName);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Location = new System.Drawing.Point(12, 197);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(437, 100);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Credentials";
			// 
			// SetCredentials
			// 
			this.SetCredentials.Location = new System.Drawing.Point(289, 33);
			this.SetCredentials.Name = "SetCredentials";
			this.SetCredentials.Size = new System.Drawing.Size(75, 23);
			this.SetCredentials.TabIndex = 7;
			this.SetCredentials.Text = "Set";
			this.SetCredentials.Click += new System.EventHandler(this.SetCredentials_Click);
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(70, 58);
			this.password.Name = "password";
			this.password.PasswordChar = '●';
			this.password.Size = new System.Drawing.Size(186, 20);
			this.password.TabIndex = 8;
			this.password.UseSystemPasswordChar = true;
			// 
			// userName
			// 
			this.userName.Location = new System.Drawing.Point(70, 30);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(186, 20);
			this.userName.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Username:";
			// 
			// FTPDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 306);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "FTPDemo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simple FTP Client";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox DownloadFileName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Browse2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button Download;
		private System.Windows.Forms.TextBox downloadURI;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox userName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button SetCredentials;
	}
}

