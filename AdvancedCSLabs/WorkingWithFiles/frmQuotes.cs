using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab10
{
    public partial class frmQuotes : Form
    {
        public frmQuotes()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new frmQuotes());
        }

        private void btnFileStream_Click(object sender, EventArgs e)
        {

        }

        private void btnStreamReader_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtFileText.Text = String.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}