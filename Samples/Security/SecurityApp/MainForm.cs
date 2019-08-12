using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SecurityApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CASForm form = new CASForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SymmetricForm form = new SymmetricForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AsymmetricForm form = new AsymmetricForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HashForm form = new HashForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowsSecurityForm form = new WindowsSecurityForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GenericSecurityForm form = new GenericSecurityForm();
            form.Show();
        }


    }
}