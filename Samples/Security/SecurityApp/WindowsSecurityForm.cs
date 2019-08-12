using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Security.Principal;

namespace SecurityApp
{
    public partial class WindowsSecurityForm : Form
    {
        public WindowsSecurityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // using identity in windows application
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            MessageBox.Show(identity.Name);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal =
                new WindowsPrincipal(identity);
            string message = string.Format("Is {0} an admin: {1}",
                identity.Name,
                principal.IsInRole("BUILTIN\\ADMINISTRATORS").ToString()
            );
            MessageBox.Show(message); 
        }
    }
}