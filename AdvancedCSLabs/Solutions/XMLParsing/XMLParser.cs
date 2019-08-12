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

        private void btnParseXml_Click(object sender, EventArgs e)
        {
            XmlProductReader reader = new XmlProductReader();
            List<Product> products = reader.ParseProducts(_XmlPath);
            if (products != null)
            {
                Type prodType = typeof(Product);
                StringBuilder sb = new StringBuilder();
                foreach (Product p in products)
                {
                    sb.Append("Product: ");
                    sb.Append(p.ModelNumber);
                    sb.AppendLine();
                    sb.Append("------------------------------------------------------------------------");
                    sb.AppendLine();
                    foreach (PropertyInfo prop in prodType.GetProperties())
                    {
                        sb.Append(prop.Name);
                        sb.Append(": ");
                        sb.Append(prop.GetValue(p, null));
                        sb.AppendLine();
                    }
                    sb.AppendLine();
                }
                this.txtProducts.Text = sb.ToString();
            }
        }
    }
}