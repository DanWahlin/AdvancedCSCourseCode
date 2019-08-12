using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace ThreadsAndDelegates
{
	/// <summary>
	/// Summary description for Synchronous.
	/// </summary>
	public class Synchronous : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ProgressBar pbStatus;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Synchronous()
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
			this.lblOutput.Location = new System.Drawing.Point(166, 32);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.TabIndex = 8;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(14, 32);
			this.btnStart.Name = "btnStart";
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// pbStatus
			// 
			this.pbStatus.Location = new System.Drawing.Point(14, 96);
			this.pbStatus.Name = "pbStatus";
			this.pbStatus.Size = new System.Drawing.Size(264, 23);
			this.pbStatus.TabIndex = 6;
			// 
			// Synchronous
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 150);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.pbStatus);
			this.Name = "Synchronous";
			this.Text = "Synchronous";
			this.ResumeLayout(false);

		}
		#endregion

		public static void Main() {
			Application.Run(new Synchronous());
		}

        //No threading so message box will show at end
		private void btnStart_Click(object sender, System.EventArgs e) {
			StartProcess(100);
			MessageBox.Show("Finally finished StartProcess()!!");
		}


        private void StartProcess(int max)
        {
            this.pbStatus.Maximum = max;
            for (int i = 0; i <= max; i++)
            {
                Thread.Sleep(10);
                this.lblOutput.Text = i.ToString();
                this.pbStatus.Value = i;
            }
        }
	}
}
