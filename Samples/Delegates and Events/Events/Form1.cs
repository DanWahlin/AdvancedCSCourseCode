using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chapter7.EventsAndDelegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            AssemblyLine al = new AssemblyLine();
            al.StageCompleted += new StageCompletedHandler(al_StageCompleted);
            al.StartAssemblyLine(Int32.Parse(this.txtProdID.Text));
        }

        void al_StageCompleted(object sender, StageCompletedEventArgs e)
        {
            this.txtStageInfo.Text += "We're at stage: " + e.Stage.ToString();
            this.txtStageInfo.Text += Environment.NewLine;
            this.txtStageInfo.Refresh();
        }

    }
}