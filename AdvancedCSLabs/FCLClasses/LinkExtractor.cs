using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace FCLClasses
{
    public partial class LinkExtractor : Form
    {
        public LinkExtractor()
        {
            InitializeComponent();
        }


        





        #region Supporting Code

        private void CreateLinkLabel(string title, string href)
        {
            LinkLabel lbl = new LinkLabel();
            lbl.Text = title;
            lbl.Width = 150;
            lbl.Height = 25;
            lbl.Links.Add(0, lbl.Text.Length, href);
            lbl.LinkClicked += new LinkLabelLinkClickedEventHandler(lbl_LinkClicked);
            this.fpnlLinks.Controls.Add(lbl);
        }

        void lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;

            // If the value looks like a URL, navigate to it.
            // Otherwise, display it in a message box.
            if (null != target && target.StartsWith("http"))
            {
                System.Diagnostics.Process.Start(target);
            }
            else
            {
                MessageBox.Show("You clicked: " + target);
            }

        }

        #endregion
    }
}