using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace DualWindowsForm
{
    public partial class Form1 : Form, DualWindowsForm.ServiceReference1.IService1Callback
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy =
                new DualWindowsForm.ServiceReference1.Service1Client(new InstanceContext(this));
            proxy.GetData("Hello");
        }

        #region IService1Callback Members

        public void GetCompletedData(string data)
        {
            MessageBox.Show(data);
        }

        #endregion
    }
}
