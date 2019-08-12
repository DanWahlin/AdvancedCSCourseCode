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
    public partial class AsymmetricForm : Form
    {
        public AsymmetricForm()
        {
            InitializeComponent();
        }

        private RSACryptoServiceProvider GetRSA(string containerName)
        {
            // create Cryptography Service Provider parameters
            CspParameters cspParams = new CspParameters();

            // establish key container name from method argument
            cspParams.KeyContainerName = containerName;
            
            // associate key container with RSACryptoServiceProvider
            RSACryptoServiceProvider rsa = 
                new RSACryptoServiceProvider(cspParams);
            
            // show the public key xml
            MessageBox.Show(rsa.ToXmlString(false));

            // return RSACryptoServiceProvider object
            return rsa;
        }

        byte[] encryptedData = null;

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            // Get asymmetric algorithm object from helper method
            RSACryptoServiceProvider rsa = GetRSA("CS300");

            //// false means: use public key for encryption
            //rsa.ImportParameters(rsa.ExportParameters(false));

            // convert string to byte array
            ASCIIEncoding converter = new ASCIIEncoding();
            byte[] dataToEncrypt = converter.GetBytes(textBox1.Text);

            // encrypt without padding
            encryptedData = rsa.Encrypt(dataToEncrypt, false);

            textBox1.Text = converter.GetString(encryptedData);
            textBox1.ReadOnly = true;

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (encryptedData == null) return;
 
            // get asymmetric algorithm object from helper method
            RSACryptoServiceProvider rsa = GetRSA("CS300");

            //// true means: use private key for decryption
            //rsa.ImportParameters(rsa.ExportParameters(true));

            // decrypt without padding
            byte[] decryptedData = rsa.Decrypt(encryptedData, false);

            ASCIIEncoding converter = new ASCIIEncoding();
            textBox1.Text = converter.GetString(decryptedData);
            textBox1.ReadOnly = false;
            encryptedData = null;
        }
    }
}