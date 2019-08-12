namespace Chapter2
{
	partial class StopWatchDemo
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SWTimeStamp = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SWFrequency = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ElapsedTicks = new System.Windows.Forms.TextBox();
			this.ElapsedMilliseconds = new System.Windows.Forms.TextBox();
			this.ElapsedTimeSpan = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.StartNew = new System.Windows.Forms.Button();
			this.Reset = new System.Windows.Forms.Button();
			this.Stop = new System.Windows.Forms.Button();
			this.Start = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.SWTimeStamp);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.SWFrequency);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(340, 121);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Static properties and methods";
			// 
			// SWTimeStamp
			// 
			this.SWTimeStamp.Enabled = false;
			this.SWTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SWTimeStamp.Location = new System.Drawing.Point(155, 84);
			this.SWTimeStamp.Name = "SWTimeStamp";
			this.SWTimeStamp.Size = new System.Drawing.Size(146, 20);
			this.SWTimeStamp.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Time Stamp (tick count):";
			// 
			// SWFrequency
			// 
			this.SWFrequency.Enabled = false;
			this.SWFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SWFrequency.Location = new System.Drawing.Point(155, 49);
			this.SWFrequency.Name = "SWFrequency";
			this.SWFrequency.Size = new System.Drawing.Size(146, 20);
			this.SWFrequency.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Frequency (ticks/second):";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(15, 21);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Is Stopwatch a high resolution timer?";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ElapsedTicks);
			this.groupBox2.Controls.Add(this.ElapsedMilliseconds);
			this.groupBox2.Controls.Add(this.ElapsedTimeSpan);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.StartNew);
			this.groupBox2.Controls.Add(this.Reset);
			this.groupBox2.Controls.Add(this.Stop);
			this.groupBox2.Controls.Add(this.Start);
			this.groupBox2.Location = new System.Drawing.Point(12, 150);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(340, 171);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Instance properties and methods";
			// 
			// ElapsedTicks
			// 
			this.ElapsedTicks.Enabled = false;
			this.ElapsedTicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ElapsedTicks.Location = new System.Drawing.Point(137, 76);
			this.ElapsedTicks.Name = "ElapsedTicks";
			this.ElapsedTicks.Size = new System.Drawing.Size(164, 20);
			this.ElapsedTicks.TabIndex = 9;
			// 
			// ElapsedMilliseconds
			// 
			this.ElapsedMilliseconds.Enabled = false;
			this.ElapsedMilliseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ElapsedMilliseconds.Location = new System.Drawing.Point(137, 48);
			this.ElapsedMilliseconds.Name = "ElapsedMilliseconds";
			this.ElapsedMilliseconds.Size = new System.Drawing.Size(164, 20);
			this.ElapsedMilliseconds.TabIndex = 8;
			// 
			// ElapsedTimeSpan
			// 
			this.ElapsedTimeSpan.Enabled = false;
			this.ElapsedTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ElapsedTimeSpan.Location = new System.Drawing.Point(137, 20);
			this.ElapsedTimeSpan.Name = "ElapsedTimeSpan";
			this.ElapsedTimeSpan.Size = new System.Drawing.Size(164, 20);
			this.ElapsedTimeSpan.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(43, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Elapsed Ticks:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Elapsed Milliseconds:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Elapsed TimeSpan:";
			// 
			// StartNew
			// 
			this.StartNew.Location = new System.Drawing.Point(249, 121);
			this.StartNew.Name = "StartNew";
			this.StartNew.Size = new System.Drawing.Size(75, 23);
			this.StartNew.TabIndex = 3;
			this.StartNew.Text = "Start new";
			this.StartNew.Click += new System.EventHandler(this.StartNew_Click);
			// 
			// Reset
			// 
			this.Reset.Location = new System.Drawing.Point(168, 121);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(75, 23);
			this.Reset.TabIndex = 2;
			this.Reset.Text = "Reset";
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// Stop
			// 
			this.Stop.Location = new System.Drawing.Point(87, 121);
			this.Stop.Name = "Stop";
			this.Stop.Size = new System.Drawing.Size(75, 23);
			this.Stop.TabIndex = 1;
			this.Stop.Text = "Stop";
			this.Stop.Click += new System.EventHandler(this.Stop_Click);
			// 
			// Start
			// 
			this.Start.Location = new System.Drawing.Point(6, 121);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(75, 23);
			this.Start.TabIndex = 0;
			this.Start.Text = "Start";
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// StopWatchDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 333);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "StopWatchDemo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stopwatch Sample";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox SWFrequency;
		private System.Windows.Forms.TextBox SWTimeStamp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button Stop;
		private System.Windows.Forms.Button Start;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button StartNew;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ElapsedTicks;
		private System.Windows.Forms.TextBox ElapsedMilliseconds;
		private System.Windows.Forms.TextBox ElapsedTimeSpan;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Timer timer1;
	}
}

