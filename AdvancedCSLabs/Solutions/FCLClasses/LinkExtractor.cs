using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FCLClasses
{
    public partial class LinkExtractor : Form
    {
        public LinkExtractor()
        {
            InitializeComponent();
        }

        private async Task<string> DownloadStringAsync(Uri uri)
        {
            var wc = new WebClient();
            return await wc.DownloadStringTaskAsync(uri);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            this.fpnlLinks.Controls.Clear();
            try
            {
                //Convert URL typed into textbox into a Uri instance
                Uri uri;
                bool status = Uri.TryCreate(this.txtURL.Text, UriKind.Absolute, out uri);
                if (!status)
                {
                    MessageBox.Show("Ensure you entered a properly formatted URL");
                    return;
                }

                string pageContent = await DownloadStringAsync(uri);

                if (!String.IsNullOrEmpty(pageContent))
                {
                    MatchCollection matches = Regex.Matches(pageContent, 
                        @"<a\shref\s*=\s*[""'](?<href>.*?)[""'][^>]*>(?<title>.*?)</a>",
                        RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    if (matches != null)
                    {
                        foreach (Match m in matches)
                        {
                            string href = m.Groups["href"].Value.ToLower().Trim();
                            string title = m.Groups["title"].Value.Trim();
                            title = Regex.Replace(title, "<[^>]*>", String.Empty,
                                RegexOptions.Singleline | RegexOptions.Compiled);
                            if (!String.IsNullOrEmpty(title))
                            {
                                if (href.StartsWith("javascript")) continue;
                                if (!href.StartsWith("http"))
                                {
                                    string separator = (href.StartsWith("/")) ? String.Empty : "/";
                                    href = String.Concat("http://", uri.Host, separator, href);
                                }
                                CreateLinkLabel(title, href);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No links found");
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error occurred accessing the URL: " + exp.Message);
            }


        }

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
    }
}