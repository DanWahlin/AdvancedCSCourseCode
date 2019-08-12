using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

  using System.Security.Cryptography;
using System.IO;

namespace SecurityApp
{
    public partial class SymmetricForm : Form
    {
        public SymmetricForm()
        {
            InitializeComponent();
        }

        MemoryStream encryptedMemory = null;
        private void  UpdateForm(MemoryStream memory)
        {
            byte[] encrytedData = (byte[])memory.GetBuffer().Clone();
            encryptedMemory = new MemoryStream(encrytedData);
            ASCIIEncoding stringConverter = new ASCIIEncoding();
            textBoxData.Text = stringConverter.GetString(encrytedData);
            textBoxData.ReadOnly = true;
            encryptedMemory.Position = 0;
        }

        private void UpdateForm(byte[] decryptedBytes)
        {
            ASCIIEncoding stringConverter = new ASCIIEncoding();
            textBoxData.ReadOnly = false;
            textBoxData.Text = stringConverter.GetString(decryptedBytes);
        }

        private byte[] GetBytesFromTextBox()
        {
            ASCIIEncoding byteConverter = new ASCIIEncoding();
            StringBuilder text = new StringBuilder();
            foreach (string line in textBoxData.Lines)
            {
                text.Append(line);
            }
            return byteConverter.GetBytes(text.ToString());
        }



        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            //Add encryption code here

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            #region Retrieve salt and IV from memory stream & generate key
            // use same algorithm to decrypt
            Rijndael aesAlgorithm = Rijndael.Create();
            aesAlgorithm.Padding = PaddingMode.Zeros;

            // obtain salt and IV from memory stream
            byte[] salt = new byte[16];
            byte[] IV = new byte[aesAlgorithm.IV.Length];
            encryptedMemory.Read(salt, 0, salt.Length);
            encryptedMemory.Read(IV, 0, IV.Length);

            string password = textBoxPassword.Text;

            // regenerate key based on password and salt
            Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, salt);
            aesAlgorithm.Key = keyGenerator.GetBytes(16);
            aesAlgorithm.IV = IV; 
            #endregion

            //Add code here



        }
    }
}