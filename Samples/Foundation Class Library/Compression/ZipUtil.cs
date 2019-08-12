using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Chapter2.Compression
{
    class ZipUtil
    {
        public void CompressFile ( string sourceFile, string destinationFile )
        {
            // make sure the source file is there
            if ( File.Exists ( sourceFile ) == false )
                throw new FileNotFoundException ( );

            // Create the streams and byte arrays needed
            byte[] buffer = null;
            FileStream sourceStream = null;
            FileStream destinationStream = null;
            GZipStream compressedStream = null;

            try
            {
                // Read the bytes from the source file into a byte array
                sourceStream = new FileStream ( sourceFile, FileMode.Open, FileAccess.Read, FileShare.Read );

                // Read the source stream values into the buffer
                buffer = new byte[sourceStream.Length];
                int checkCounter = sourceStream.Read ( buffer, 0, buffer.Length );

                if ( checkCounter != buffer.Length )
                {
                    throw new ApplicationException ( );
                }

                // Open the FileStream to write to
                destinationStream = new FileStream ( destinationFile, FileMode.OpenOrCreate, FileAccess.Write );

                // Create a compression stream pointing to the destiantion stream
                compressedStream = new GZipStream ( destinationStream, CompressionMode.Compress, true );

                // Now write the compressed data to the destination file
                compressedStream.Write ( buffer, 0, buffer.Length );
            }
            catch ( ApplicationException ex )
            {
                MessageBox.Show ( ex.Message, "An Error occured during compression", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally
            {
                // Make sure we allways close all streams
                if ( sourceStream != null )
                    sourceStream.Close ( );

                if ( compressedStream != null )
                    compressedStream.Close ( );

                if ( destinationStream != null )
                    destinationStream.Close ( );
            }
        }

        public void DecompressFile ( string sourceFile, string destinationFile )
        {
            // make sure the source file is there
            if ( File.Exists ( sourceFile ) == false )
                throw new FileNotFoundException ( );

            // Create the streams and byte arrays needed
            FileStream sourceStream = null;
            FileStream destinationStream = null;
            GZipStream decompressedStream = null;
            byte[] quartetBuffer = null;

            try
            {
                // Read in the compressed source stream
                sourceStream = new FileStream ( sourceFile, FileMode.Open );

                // Create a compression stream pointing to the destiantion stream
                decompressedStream = new GZipStream ( sourceStream, CompressionMode.Decompress, true );

                // Read the footer to determine the length of the destiantion file
                quartetBuffer = new byte[4];
                int position = (int)sourceStream.Length - 4;
                sourceStream.Position = position;
                sourceStream.Read ( quartetBuffer, 0, 4 );
                sourceStream.Position = 0;
                int checkLength = BitConverter.ToInt32 ( quartetBuffer, 0 );

                byte[] buffer = new byte[checkLength + 100];

                int offset = 0;
                int total = 0;

                // Read the compressed data into the buffer
                while ( true )
                {
                    int bytesRead = decompressedStream.Read ( buffer, offset, 100 );

                    if ( bytesRead == 0 )
                        break;

                    offset += bytesRead;
                    total += bytesRead;
                }

                // Now write everything to the destination file
                destinationStream = new FileStream ( destinationFile, FileMode.Create );
                destinationStream.Write ( buffer, 0, total );

                // and flush everyhting to clean out the buffer
                destinationStream.Flush ( );
            }
            catch ( ApplicationException ex )
            {
                MessageBox.Show ( ex.Message, "An Error occured during compression", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally
            {
                // Make sure we allways close all streams
                if ( sourceStream != null )
                    sourceStream.Close ( );

                if ( decompressedStream != null )
                    decompressedStream.Close ( );

                if ( destinationStream != null )
                    destinationStream.Close ( );
            }

        }
    }
}
