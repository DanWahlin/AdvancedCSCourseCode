using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Permissions;

namespace SecurityApp
{
    public partial class CASForm : Form
    {
        public CASForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = SecurityApp.Properties.Settings.Default.File;
            if (File.Exists(file))
            {
                StreamReader reader = File.OpenText(file);
                MessageBox.Show(reader.ReadToEnd());
                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string file = SecurityApp.Properties.Settings.Default.File;
                FileIOPermission permission =
                    new FileIOPermission(FileIOPermissionAccess.Write, file);
                permission.Demand();
                if (File.Exists(file))
                {
                    File.AppendAllText(file, DateTime.Now.ToLongTimeString() +"\r\n");
                }
            }
            catch (SecurityException)
            {
                MessageBox.Show("No permission to write to file");
            }
            
        }
    }
}