using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Chapter2.FTP
{
	public partial class FTPDemo : Form
	{
		public FTPDemo()
		{
			InitializeComponent();

			_ftpClient = new SimpleFTPClient();

			this.openFileDialog1.FileName = "";
			this.openFileDialog1.InitialDirectory = Path.GetTempPath();

			this.saveFileDialog1.FileName = "";
			this.saveFileDialog1.InitialDirectory = Path.GetTempPath();

			this.downloadURI.Text = "ftp://localhost/testfile.txt";

			this.checkBox1.Checked = true;
		}

        [STAThread]
        public static void Main()
        {
            Application.Run(new FTPDemo());
        }

		private void Download_Click(object sender, EventArgs e)
		{
			if (this.DownloadFileName.Text.Length > 0 & this.downloadURI.Text.Length > 0)
			{
				try
				{
					ShowFTPResult(_ftpClient.Download(this.DownloadFileName.Text, new Uri(this.downloadURI.Text)));
				}
				catch (Exception ex)
				{
					MessageBox.Show("There was an error in the download\r\n" + ex.Message, "FTP Sample", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void SetCredentials_Click(object sender, EventArgs e)
		{
			_ftpClient.UserName = this.userName.Text;
			_ftpClient.Password = this.password.Text;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			_ftpClient.IsAnonymousUser = checkBox1.Checked;
		}

		private void Browse_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.ShowDialog();
		}

		private void Browse2_Click(object sender, EventArgs e)
		{
			this.saveFileDialog1.ShowDialog();

			this.DownloadFileName.Text = this.saveFileDialog1.FileName;
		}

		private void ShowFTPResult(FtpStatusCode statusCode)
		{
			MessageBox.Show("The FTP Server returned the following status: " + statusCode.ToString(), "Simple FTP Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		private SimpleFTPClient _ftpClient;
	}
}