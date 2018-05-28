using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace craftersmine.Synx.Client.Utils
{
    public sealed class ImageFromBytesConverter
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            if (byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                ms.Position = 0;
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }
    }
}
