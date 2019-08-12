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
            #region Generate Key
            // get password from user
            string password = textBoxPassword.Text;

            // create salt from random number
            byte[] salt = new byte[16];
            RandomNumberGenerator random = RandomNumberGenerator.Create();
            random.GetBytes(salt);

            // create 16 byte (128 bit) key generator from password and salt
            Rfc2898DeriveBytes keyGenerator =
                new Rfc2898DeriveBytes(password, salt);

            // create key from keyGenerator
            byte[] key = keyGenerator.GetBytes(16);
            #endregion

            #region Choose algorithm, save salt and IV
            // Create symmetric algorithm
            Rijndael aesAlgorithm = Rijndael.Create();
            aesAlgorithm.Key = key;
            aesAlgorithm.Padding = PaddingMode.Zeros;
            
            // this could have been a FileStream if desired
            MemoryStream memory = new MemoryStream();

            // Write salt and initializing vector unencrypted to stream
            memory.Write(salt, 0, salt.Length);
            memory.Write(aesAlgorithm.IV, 0, aesAlgorithm.IV.Length);
            #endregion
            
            #region Encrypt data
            // create CryptoStream for encryption
            CryptoStream crypto = new CryptoStream(
                memory,
                aesAlgorithm.CreateEncryptor(),
                CryptoStreamMode.Write);

            // obtain data for encryption as byte[]
            byte[] dataToEncrypt = GetBytesFromTextBox();

            // write, flush, and close stream
            crypto.Write(dataToEncrypt, 0, dataToEncrypt.Length);
            crypto.FlushFinalBlock();

            // helper method to update textbox and save memory stream
            UpdateForm(memory);

            crypto.Close(); 
            #endregion            
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

            #region Decrypt the contents
            // create CryptoStream for decryption
            CryptoStream crypto = new CryptoStream(
                encryptedMemory,
                aesAlgorithm.CreateDecryptor(),
                CryptoStreamMode.Read);

            // determine size of encrypted content
            int encryptedSize = (int)encryptedMemory.Length -
                (salt.Length + IV.Length);

            // create byte[] to hold decrypted bytes
            byte[] decryptedBytes = new byte[encryptedSize];

            // decrypt the contents, then close stream
            crypto.Read(decryptedBytes, 0, encryptedSize);
            crypto.Close();

            // use decryptedBytes in helper method
            UpdateForm(decryptedBytes); 
            #endregion

        }
    }
}