using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Configuration;

namespace XmlImportService {
	public class XmlImporter : System.ServiceProcess.ServiceBase {
		private XmlFileWatcher watcher = null;
		private System.ComponentModel.Container components = null;

		public XmlImporter()
		{
			// This call is required by the Windows.Forms Component Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitComponent call
		}

		// The main entry point for the process
		static void Main() {
			System.ServiceProcess.ServiceBase[] ServicesToRun;
	
			// More than one user Service may run within the same process. To add
			// another service to this process, change the following line to
			// create a second service object. For example,
			//
			//   ServicesToRun = New System.ServiceProcess.ServiceBase[] {new Service1(), new MySecondUserService()};
			//
			ServicesToRun = new System.ServiceProcess.ServiceBase[] { new XmlImporter() };

			System.ServiceProcess.ServiceBase.Run(ServicesToRun);
		}

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// XmlImporter
			// 
			this.CanPauseAndContinue = true;
			this.ServiceName = "XmlImportService";

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Set things in motion so your service can do its work.
		/// </summary>
		protected override void OnStart(string[] args) {
			//Get directory from config file
			string directory = ConfigurationManager.AppSettings["XmlWatchDirectory"];
			string file = ConfigurationManager.AppSettings["XmlWatchDirectoryFile"];
			if (watcher == null) watcher = new XmlFileWatcher(directory,file);
			watcher.StartXmlFileWatcher();
		}
 
		protected override void OnStop() {
            watcher.StopXmlFileWatcher();
		}
	}
}
