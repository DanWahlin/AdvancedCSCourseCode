namespace DebuggingAndTracing.PerformanceMonitors
{
    partial class PerformanceCountersDemo
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
            this.lblExceptionsThrown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExceptionsThrownValue = new System.Windows.Forms.Label();
            this.lblILBytesJittedValue = new System.Windows.Forms.Label();
            this.lblILBytesJItted = new System.Windows.Forms.Label();
            this.pcExceptionsThrown = new System.Diagnostics.PerformanceCounter();
            this.pcILBytesJitted = new System.Diagnostics.PerformanceCounter();
            this.pcBytesInHeaps = new System.Diagnostics.PerformanceCounter();
            this.lblBytesInHeapsValue = new System.Windows.Forms.Label();
            this.lblBytesInHeaps = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblGen0CollectionsValue = new System.Windows.Forms.Label();
            this.lblGen0Collections = new System.Windows.Forms.Label();
            this.pcGen0Collections = new System.Diagnostics.PerformanceCounter();
            this.lblMemoryValue = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.pcMemory = new System.Diagnostics.PerformanceCounter();
            this.lblDiskSpaceValue = new System.Windows.Forms.Label();
            this.lblDiskSpace = new System.Windows.Forms.Label();
            this.pcDiskSpace = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pcExceptionsThrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcILBytesJitted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBytesInHeaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGen0Collections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDiskSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExceptionsThrown
            // 
            this.lblExceptionsThrown.AutoSize = true;
            this.lblExceptionsThrown.Location = new System.Drawing.Point(13, 74);
            this.lblExceptionsThrown.Name = "lblExceptionsThrown";
            this.lblExceptionsThrown.Size = new System.Drawing.Size(101, 13);
            this.lblExceptionsThrown.TabIndex = 0;
            this.lblExceptionsThrown.Text = "Exceptions Thrown:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = ".NET Performance Counters";
            // 
            // lblExceptionsThrownValue
            // 
            this.lblExceptionsThrownValue.AutoSize = true;
            this.lblExceptionsThrownValue.Location = new System.Drawing.Point(159, 74);
            this.lblExceptionsThrownValue.Name = "lblExceptionsThrownValue";
            this.lblExceptionsThrownValue.Size = new System.Drawing.Size(0, 13);
            this.lblExceptionsThrownValue.TabIndex = 2;
            // 
            // lblILBytesJittedValue
            // 
            this.lblILBytesJittedValue.AutoSize = true;
            this.lblILBytesJittedValue.Location = new System.Drawing.Point(159, 106);
            this.lblILBytesJittedValue.Name = "lblILBytesJittedValue";
            this.lblILBytesJittedValue.Size = new System.Drawing.Size(0, 13);
            this.lblILBytesJittedValue.TabIndex = 4;
            // 
            // lblILBytesJItted
            // 
            this.lblILBytesJItted.AutoSize = true;
            this.lblILBytesJItted.Location = new System.Drawing.Point(13, 106);
            this.lblILBytesJItted.Name = "lblILBytesJItted";
            this.lblILBytesJItted.Size = new System.Drawing.Size(76, 13);
            this.lblILBytesJItted.TabIndex = 3;
            this.lblILBytesJItted.Text = "IL Bytes Jitted:";
            // 
            // pcExceptionsThrown
            // 
            this.pcExceptionsThrown.CategoryName = ".NET CLR Exceptions";
            this.pcExceptionsThrown.CounterName = "# of Exceps Thrown";
            this.pcExceptionsThrown.InstanceName = "_Global_";
            // 
            // pcILBytesJitted
            // 
            this.pcILBytesJitted.CategoryName = ".NET CLR Jit";
            this.pcILBytesJitted.CounterName = "Total # of IL Bytes Jitted";
            this.pcILBytesJitted.InstanceName = "_Global_";
            // 
            // pcBytesInHeaps
            // 
            this.pcBytesInHeaps.CategoryName = ".NET CLR Memory";
            this.pcBytesInHeaps.CounterName = "# Bytes in all Heaps";
            this.pcBytesInHeaps.InstanceName = "_Global_";
            // 
            // lblBytesInHeapsValue
            // 
            this.lblBytesInHeapsValue.AutoSize = true;
            this.lblBytesInHeapsValue.Location = new System.Drawing.Point(159, 140);
            this.lblBytesInHeapsValue.Name = "lblBytesInHeapsValue";
            this.lblBytesInHeapsValue.Size = new System.Drawing.Size(0, 13);
            this.lblBytesInHeapsValue.TabIndex = 6;
            // 
            // lblBytesInHeaps
            // 
            this.lblBytesInHeaps.AutoSize = true;
            this.lblBytesInHeaps.Location = new System.Drawing.Point(13, 140);
            this.lblBytesInHeaps.Name = "lblBytesInHeaps";
            this.lblBytesInHeaps.Size = new System.Drawing.Size(91, 13);
            this.lblBytesInHeaps.TabIndex = 5;
            this.lblBytesInHeaps.Text = "# Bytes in Heaps:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(13, 305);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(0, 13);
            this.lblLastUpdated.TabIndex = 7;
            // 
            // lblGen0CollectionsValue
            // 
            this.lblGen0CollectionsValue.AutoSize = true;
            this.lblGen0CollectionsValue.Location = new System.Drawing.Point(159, 176);
            this.lblGen0CollectionsValue.Name = "lblGen0CollectionsValue";
            this.lblGen0CollectionsValue.Size = new System.Drawing.Size(0, 13);
            this.lblGen0CollectionsValue.TabIndex = 9;
            // 
            // lblGen0Collections
            // 
            this.lblGen0Collections.AutoSize = true;
            this.lblGen0Collections.Location = new System.Drawing.Point(13, 176);
            this.lblGen0Collections.Name = "lblGen0Collections";
            this.lblGen0Collections.Size = new System.Drawing.Size(93, 13);
            this.lblGen0Collections.TabIndex = 8;
            this.lblGen0Collections.Text = "Gen 0 Collections:";
            // 
            // pcGen0Collections
            // 
            this.pcGen0Collections.CategoryName = ".NET CLR Memory";
            this.pcGen0Collections.CounterName = "# Gen 0 Collections";
            this.pcGen0Collections.InstanceName = "_Global_";
            // 
            // lblMemoryValue
            // 
            this.lblMemoryValue.AutoSize = true;
            this.lblMemoryValue.Location = new System.Drawing.Point(159, 212);
            this.lblMemoryValue.Name = "lblMemoryValue";
            this.lblMemoryValue.Size = new System.Drawing.Size(0, 13);
            this.lblMemoryValue.TabIndex = 11;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(13, 212);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(47, 13);
            this.lblMemory.TabIndex = 10;
            this.lblMemory.Text = "Memory:";
            // 
            // pcMemory
            // 
            this.pcMemory.CategoryName = "Memory";
            this.pcMemory.CounterName = "Available MBytes";
            // 
            // lblDiskSpaceValue
            // 
            this.lblDiskSpaceValue.AutoSize = true;
            this.lblDiskSpaceValue.Location = new System.Drawing.Point(159, 244);
            this.lblDiskSpaceValue.Name = "lblDiskSpaceValue";
            this.lblDiskSpaceValue.Size = new System.Drawing.Size(0, 13);
            this.lblDiskSpaceValue.TabIndex = 13;
            // 
            // lblDiskSpace
            // 
            this.lblDiskSpace.AutoSize = true;
            this.lblDiskSpace.Location = new System.Drawing.Point(13, 244);
            this.lblDiskSpace.Name = "lblDiskSpace";
            this.lblDiskSpace.Size = new System.Drawing.Size(83, 13);
            this.lblDiskSpace.TabIndex = 12;
            this.lblDiskSpace.Text = "C:\\ Disk Space:";
            // 
            // pcDiskSpace
            // 
            this.pcDiskSpace.CategoryName = "LogicalDisk";
            this.pcDiskSpace.CounterName = "Free Megabytes";
            this.pcDiskSpace.InstanceName = "C:";
            // 
            // PerformanceCountersDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 338);
            this.Controls.Add(this.lblDiskSpaceValue);
            this.Controls.Add(this.lblDiskSpace);
            this.Controls.Add(this.lblMemoryValue);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.lblGen0CollectionsValue);
            this.Controls.Add(this.lblGen0Collections);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.lblBytesInHeapsValue);
            this.Controls.Add(this.lblBytesInHeaps);
            this.Controls.Add(this.lblILBytesJittedValue);
            this.Controls.Add(this.lblILBytesJItted);
            this.Controls.Add(this.lblExceptionsThrownValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExceptionsThrown);
            this.Name = "PerformanceCountersDemo";
            this.Text = "Performance Counters";
            this.Load += new System.EventHandler(this.PerformanceCountersDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcExceptionsThrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcILBytesJitted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBytesInHeaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcGen0Collections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDiskSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExceptionsThrown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExceptionsThrownValue;
        private System.Windows.Forms.Label lblILBytesJittedValue;
        private System.Windows.Forms.Label lblILBytesJItted;
        private System.Diagnostics.PerformanceCounter pcExceptionsThrown;
        private System.Diagnostics.PerformanceCounter pcILBytesJitted;
        private System.Diagnostics.PerformanceCounter pcBytesInHeaps;
        private System.Windows.Forms.Label lblBytesInHeapsValue;
        private System.Windows.Forms.Label lblBytesInHeaps;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.Label lblGen0CollectionsValue;
        private System.Windows.Forms.Label lblGen0Collections;
        private System.Diagnostics.PerformanceCounter pcGen0Collections;
        private System.Windows.Forms.Label lblMemoryValue;
        private System.Windows.Forms.Label lblMemory;
        private System.Diagnostics.PerformanceCounter pcMemory;
        private System.Windows.Forms.Label lblDiskSpaceValue;
        private System.Windows.Forms.Label lblDiskSpace;
        private System.Diagnostics.PerformanceCounter pcDiskSpace;
    }
}