using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace craftersmine.Synx.Client.Utils
{
    public sealed class MD5Compute
    {
        public static string ComputeMD5(string input)
        {
            MD5 _md5 = new MD5CryptoServiceProvider();

            byte[] returned = _md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < returned.Length; i++)
            {
                sb.Append(returned[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}