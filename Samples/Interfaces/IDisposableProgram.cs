using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Chapter4.Interfaces
{
    class IDisposableProgram
    {
        static void Main()
        {
            //Calling objects that expose the IDisposable Interface
            System.Drawing.Image bm = Bitmap.FromFile("../../Interfaces/dotNet.png");
            Graphics g = Graphics.FromImage(bm);
            SolidBrush sb = new SolidBrush(Color.Red);
            g.DrawString("Beta", new Font("Arial", 35, FontStyle.Bold), sb, new PointF(0, 0));
            bm.Save("../../Interfaces/dotNet2.png",ImageFormat.Png);
            
            //Dispose of resources
            bm.Dispose();
            sb.Dispose();
            g.Dispose();
        }
    }
}
