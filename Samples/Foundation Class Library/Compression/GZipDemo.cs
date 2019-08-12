using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Chapter2.Compression
{
    public partial class GZipDemo : Form
    {
        public GZipDemo()
        {
            InitializeComponent();

            _zipUtil = new ZipUtil ( );

            this.openFileDialog1.FileName = "";
            this.saveFileDialog1.FileName = "";
        }

        public static void Main()
        {
            Application.Run(new GZipDemo());
        }

        private void BrowseDestination_Click ( object sender, EventArgs e )
        {
            this.saveFileDialog1.FileName = "";

            if ( this.saveFileDialog1.ShowDialog ( ) == DialogResult.OK )
                this.DestinationFile.Text = this.saveFileDialog1.FileName;
        }

        private void BrowseSource_Click ( object sender, EventArgs e )
        {
            if ( this.openFileDialog1.ShowDialog ( ) == DialogResult.OK )
            {
                this.SourceFile.Text = this.openFileDialog1.FileName;
                string newFileName = Path.GetFileNameWithoutExtension ( this.SourceFile.Text ) + ".zip";
                this.saveFileDialog1.FileName = newFileName;
            }
        }

        private void Compress_Click ( object sender, EventArgs e )
        {
            if ( this.SourceFile.Text.Length > 0 & this.DestinationFile.Text.Length > 0 )
            {
                _zipUtil.CompressFile ( this.SourceFile.Text, this.DestinationFile.Text );

                MessageBox.Show ( "Successfully compressed " + this.SourceFile.Text + " to " + this.DestinationFile.Text, "Compression Sample", MessageBoxButtons.OK, MessageBoxIcon.Information );

                this.DestinationFile.Text = "";
                this.SourceFile.Text = "";
            }
        }

        private void Decompress_Click ( object sender, EventArgs e )
        {
            if ( this.SourceFile.Text.Length > 0 & this.DestinationFile.Text.Length > 0 )
            {
                _zipUtil.DecompressFile ( this.SourceFile.Text, this.DestinationFile.Text );

                MessageBox.Show ( "Successfully decompressed " + this.SourceFile.Text + " to " + this.DestinationFile.Text, "Compression Sample", MessageBoxButtons.OK, MessageBoxIcon.Information );

                this.DestinationFile.Text = "";
                this.SourceFile.Text = "";
            }
        }


       private ZipUtil _zipUtil;
    }
}