using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Chapter2 
{
	public partial class StopWatchDemo : Form
	{
		public StopWatchDemo()
		{
			InitializeComponent();

			LoadStaticInfo();
			stopWatch = new Stopwatch();

			LoadInstanceInfo();

			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
		}

        public static void Main()
        {
            Application.Run(new StopWatchDemo());
        }

		private void LoadStaticInfo()
		{
			this.SWFrequency.Text = Stopwatch.Frequency.ToString("N");
			this.checkBox1.Checked = Stopwatch.IsHighResolution;
			this.SWTimeStamp.Text = Stopwatch.GetTimestamp().ToString("N");
		}

		private void LoadInstanceInfo()
		{
			this.ElapsedTimeSpan.Text = stopWatch.Elapsed.ToString();
			this.ElapsedMilliseconds.Text = stopWatch.ElapsedMilliseconds.ToString("N");
			this.ElapsedTicks.Text = stopWatch.ElapsedTicks.ToString("N");
		}

		private void Start_Click(object sender, EventArgs e)
		{
			stopWatch.Start();
		}

		private void Stop_Click(object sender, EventArgs e)
		{
			stopWatch.Stop();
			LoadInstanceInfo();
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			stopWatch.Reset();
			LoadInstanceInfo();
		}

		private void StartNew_Click(object sender, EventArgs e)
		{
			stopWatch = Stopwatch.StartNew();
			LoadInstanceInfo();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (stopWatch.IsRunning == true)
				LoadInstanceInfo();
		}


		private Stopwatch stopWatch;
	}
}