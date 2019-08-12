using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace ThreadsAndDelegates
{
	/// <summary>
	/// Summary description for Asynchronous_Good.
	/// </summary>
	public class Asynchronous_Good : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ProgressBar pbStatus;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Asynchronous_Good()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblOutput = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.pbStatus = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// lblOutput
			// 
			this.lblOutput.Location = new System.Drawing.Point(166, 40);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.TabIndex = 8;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(14, 40);
			this.btnStart.Name = "btnStart";
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// pbStatus
			// 
			this.pbStatus.Location = new System.Drawing.Point(14, 104);
			this.pbStatus.Name = "pbStatus";
			this.pbStatus.Size = new System.Drawing.Size(264, 23);
			this.pbStatus.TabIndex = 6;
			// 
			// Asynchronous_Good
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 166);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pbStatus);
			this.Name = "Asynchronous_Good";
			this.Text = "Asynchronous_Good";
			this.ResumeLayout(false);

		}
		#endregion

		public static void Main() {
			Application.Run(new Asynchronous_Good());
		}

		private delegate void ShowProgressDelegate(int val);
		private delegate void StartProcessDelegate(int max);
		private void btnStart_Click(object sender, System.EventArgs e) {
			int max = 100;
			this.pbStatus.Maximum = max;
			//Call long running process
			StartProcessDelegate startDel = new StartProcessDelegate(StartProcess);
			//startDel.BeginInvoke executes delegate on new thread
			startDel.BeginInvoke(max,null,null);
			//Show message box to demonstrate that StartProcess()
			//is running asynchronously
			MessageBox.Show("Called after async process started.");
		}

		//Called Asynchronously
		private void StartProcess(int max) {
			ShowProgress(0);
			for (int i=0;i<=max;i++) {
				Thread.Sleep(15);
				ShowProgress(i);
			}
		}

		private void ShowProgress(int i) {
			//On helper thread so invoke on UI thread to avoid 
			//updating UI controls from alternate thread			
			if (this.lblOutput.InvokeRequired == true) { 
				ShowProgressDelegate del = new ShowProgressDelegate(ShowProgress);
				//this.BeginInvoke executes delegate on thread used by form (UI thread)
				this.BeginInvoke(del, new object[] {i});
			} else { //On UI thread so we are safe to update
				this.lblOutput.Text = i.ToString();		
				this.pbStatus.Value =i;
			}
		}
	}
}
