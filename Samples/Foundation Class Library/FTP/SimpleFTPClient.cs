using System;
using System.Text;
using System.IO;
using System.Net;

namespace Chapter2.FTP
{
	class SimpleFTPClient
	{
		public FtpStatusCode Download(string destinationFile, Uri downloadUri)
		{
			try
			{
				// Check if the URI is and FTP site
				if (downloadUri.Scheme != Uri.UriSchemeFtp)
				{
					throw new ArgumentException("URI is not an FTp site");
				}

				// Set up the request
				FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(downloadUri);

				// use the provided credentials
				if (this._isAnonymousUser == false)
				{
					ftpRequest.Credentials = new NetworkCredential(this._userName, this._password);
				}

				// Download a file. Look at the other methods to see all of the potential FTP features
				ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

				// get the response object
				FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();


				Stream stream = null;
				StreamReader reader = null;
				StreamWriter writer = null;

				// get the file as a stream from the response object and write it as 
				// a file stream to the local PC
				try
				{
					stream = ftpResponse.GetResponseStream();
					reader = new StreamReader(stream, Encoding.UTF8);

					writer = new StreamWriter(destinationFile, false);
					writer.Write(reader.ReadToEnd());

					return ftpResponse.StatusCode;
				}
				finally
				{
					// Allways close all streams
					stream.Close();
					reader.Close();
					writer.Close();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public string UserName
		{
			get { return this._userName; }
			set { this._userName = value; }
		}
		public string Password
		{
			get { return this._password; }
			set { this._password = value; }
		}
		public bool IsAnonymousUser
		{
			get { return this._isAnonymousUser; }
			set { this._isAnonymousUser = value; }
		}

		private string _userName;
		private string _password;
		private bool _isAnonymousUser;
	}
}
