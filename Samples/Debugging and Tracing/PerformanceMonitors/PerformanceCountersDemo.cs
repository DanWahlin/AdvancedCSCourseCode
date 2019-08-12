using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DebuggingAndTracing.PerformanceMonitors
{
    public partial class PerformanceCountersDemo : Form
    {
        public PerformanceCountersDemo()
        {
            InitializeComponent();
        }

        private void PerformanceCountersDemo_Load(object sender, EventArgs e)
        {
            GetPerformanceData();
        }

        private void GetPerformanceData()
        {
            this.lblExceptionsThrownValue.Text = pcExceptionsThrown.NextValue().ToString();
            this.lblILBytesJittedValue.Text = pcILBytesJitted.NextValue().ToString() + " bytes";
            this.lblBytesInHeapsValue.Text = pcBytesInHeaps.NextValue().ToString() + " bytes";
            this.lblGen0CollectionsValue.Text = pcGen0Collections.NextValue().ToString();
            this.lblMemoryValue.Text = pcMemory.NextValue().ToString() + " MB";
            this.lblDiskSpaceValue.Text = pcDiskSpace.NextValue().ToString() + " MB";

            this.lblLastUpdated.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        static void Main()
        {
            Application.Run(new PerformanceCountersDemo());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetPerformanceData();
        }
    }
}