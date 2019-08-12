using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace ThreadsAndDelegates
{
	/// <summary>
	/// Summary description for Lock_Monitor.
	/// </summary>
	public class Lock_Monitor : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label lblThread;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Lock_Monitor()
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
			this.btnSubmit = new System.Windows.Forms.Button();
			this.lblThread = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblOutput
			// 
			this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblOutput.Location = new System.Drawing.Point(8, 24);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(584, 32);
			this.lblOutput.TabIndex = 0;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(16, 80);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.TabIndex = 1;
			this.btnSubmit.Text = "Start";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// lblThread
			// 
			this.lblThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblThread.Location = new System.Drawing.Point(128, 80);
			this.lblThread.Name = "lblThread";
			this.lblThread.Size = new System.Drawing.Size(216, 23);
			this.lblThread.TabIndex = 2;
			// 
			// Lock_Monitor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(608, 118);
			this.Controls.Add(this.lblThread);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblOutput);
			this.Name = "Lock_Monitor";
			this.Text = "Lock";
			this.ResumeLayout(false);

		}
		#endregion

		public static void Main() {
			Application.Run(new Lock_Monitor());
		}

		private delegate void UpdateLabelDelegate(char c, string name);

		private void btnSubmit_Click(object sender, System.EventArgs e) {
			//Create new thread
			Thread t = new Thread(new ThreadStart(WriteChars));
			t.Name = "Thread 1";
			t.Start();

			Thread t2 = new Thread(new ThreadStart(WriteChars));
			t2.Name = "Thread 2";
			t2.Start();
		}

		private void WriteChars() {
			//this.lblThread.Text = Thread.CurrentThread.Name;
			for (char c = 'a';c <= 'z';c++) {
				lock(this) {
					UpdateLabel(c,Thread.CurrentThread.Name);
					//Wake up locked out thread
					Monitor.Pulse(this);
					//Block thread that currently has Lock_Monitor
					//so that waiting thread gets some time
					if (c < 'z') Monitor.Wait(this);
					
				}
			}
		}

		private void UpdateLabel(char c,string tName) {
			//Not on UI thread
			if (this.lblOutput.InvokeRequired) {
				Thread.Sleep(150);
				UpdateLabelDelegate del = new UpdateLabelDelegate(UpdateLabel);
				this.BeginInvoke(del,new object[]{c,tName});
			} else { //On UI thread
				this.lblThread.Text = tName;
				this.lblOutput.Text += c;
				this.lblOutput.Refresh();
			}
		}
	}
}
