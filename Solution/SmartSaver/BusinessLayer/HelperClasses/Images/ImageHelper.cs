using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver.Logic.HelperClasses.Images
{
    public class ImageHelper
    {
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
