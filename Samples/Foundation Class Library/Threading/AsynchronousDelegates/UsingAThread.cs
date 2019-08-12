using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace ThreadsAndDelegates {
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class UsingAThread : System.Windows.Forms.Form {
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ProgressBar pbStatus;
		private System.Windows.Forms.Label lblOutput;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UsingAThread() {
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
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
		private void InitializeComponent() {
			this.pbStatus = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pbStatus
			// 
			this.pbStatus.Location = new System.Drawing.Point(16, 128);
			this.pbStatus.Name = "pbStatus";
			this.pbStatus.Size = new System.Drawing.Size(264, 23);
			this.pbStatus.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(16, 48);
			this.btnStart.Name = "btnStart";
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblOutput
			// 
			this.lblOutput.Location = new System.Drawing.Point(168, 48);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 166);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pbStatus);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new UsingAThread());
		}

		int _max;
		private void btnStart_Click(object sender, System.EventArgs e) {
			_max = 100;
			Thread t = new Thread(new System.Threading.ThreadStart(StartProcess));
			t.Start();
			MessageBox.Show("Done with operation!!");
		}

        delegate void StartProcessHandler();
		private void StartProcess() {
            if (this.pbStatus.InvokeRequired)
            {

                StartProcessHandler sph = new StartProcessHandler(StartProcess);
                this.Invoke(sph);
            }
            else
            {
                this.Refresh();
                this.pbStatus.Maximum = _max;
                for (int i = 0; i <= _max; i++)
                {
                    Thread.Sleep(10);
                    this.lblOutput.Text = i.ToString();
                    this.pbStatus.Value = i;
                }
            }
		}
	}
}