using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace XMLParsing
{
    public partial class XMLParser : Form
    {
        string _XmlPath = null;
        public XMLParser()
        {
            InitializeComponent();
        }

        private void XMLParser_Load(object sender, EventArgs e)
        {
            ofd.InitialDirectory = Path.GetDirectoryName(Application.StartupPath).Replace("bin",String.Empty) + "\\XML";
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtXmlFile.Text = Path.GetFileName(ofd.FileName);
                _XmlPath = ofd.FileName;
            }
        }


    }
}