using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SecurityApp
{
    public partial class HashForm : Form
    {
        public HashForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get data from user, convert to byte array
            ASCIIEncoding converter = new ASCIIEncoding();
            byte[] originalData = converter.GetBytes(textBox1.Text);

            // create hashing object
            SHA1Managed hasher = new SHA1Managed();

            // get hashed byte array
            byte[] hashedData = hasher.ComputeHash(originalData);

            label1.Text = converter.GetString(hashedData);
            
        }
    }
}