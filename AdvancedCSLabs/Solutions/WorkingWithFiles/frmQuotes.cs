using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab10
{
    public partial class frmQuotes : Form
    {
        private const string FILE_PATH = "..\\..\\Quotes.txt";

        public frmQuotes()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new frmQuotes());
        }

        private void btnFileStream_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            FileStream fileStream = File.OpenRead(FILE_PATH);
            byte[] buffer = new byte[500];
            while (fileStream.Read(buffer, 0, buffer.Length) > 0)
            {
                char[] chars =
                    ASCIIEncoding.ASCII.GetChars(buffer, 0, buffer.Length);
                sb.Append(chars, 0, chars.Length);
                sb.Append(Environment.NewLine);
                Array.Clear(buffer, 0, buffer.Length);
            }
            fileStream.Close();
            this.txtFileText.Text = sb.ToString();
        }

        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader reader = new StreamReader(FILE_PATH);
            while (reader.Peek() > -1)
            {
                sb.Append(reader.ReadLine());
                sb.Append(Environment.NewLine);
            }
            reader.Close();
            this.txtFileText.Text = sb.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtFileText.Text = String.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(FILE_PATH, true);
            writer.Write("\r\n" + txtNewQuote.Text);
            writer.Close();
            txtNewQuote.Text = String.Empty;
        }
    }
}