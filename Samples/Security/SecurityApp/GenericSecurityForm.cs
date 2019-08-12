using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Threading;
using System.Security.Permissions;

namespace SecurityApp
{
    public partial class GenericSecurityForm : Form
    {
        public GenericSecurityForm()
        {
            InitializeComponent();
        }

        private string[] GetRoles(string name)
        {
            // possible code that accesses a database

            // in this example, returning same roles 
            return new string[] { "admin", "sales", "director" };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create a custom identity
            GenericIdentity identity =
                new GenericIdentity(textBox1.Text, "Custom");

            // obtain roles of user through helper method
            string[] roles = GetRoles(identity.Name);

            // create custom principal
            GenericPrincipal principal =
                new GenericPrincipal(identity, roles);

            // store principal in current thread 
            Thread.CurrentPrincipal = principal;

            // get custom principal from current thread
            GenericPrincipal gp = (GenericPrincipal)Thread.CurrentPrincipal;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DoSomething();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role="Director")]
        private void DoSomething()
        {
            // write code only the Director role can execute...
            MessageBox.Show("Only directors can see this...");
        }
    }
}