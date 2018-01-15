using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Services
{
    public class GenerateUniqueIDs
    {

        public static string UsingGuid()
        {
            var result = Guid.NewGuid().ToString().GetHashCode().ToString("x");
            return result;
        }


        public static string UsingTicks()
        {
            var val = DateTime.Now.Ticks.ToString("x");
            return val;
        }


        public static string RNGCharacterMask()
        {
            const int maxSize = 8;
            var chars = new char[62];
            string a;
            a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            chars = a.ToCharArray();
            var size = maxSize;
            var data = new byte[1];

            var crypto = RandomNumberGenerator.Create();
            crypto.GetBytes(data);
            // crypto.GetNonZeroBytes(data);
            size = maxSize;
            data = new byte[size];
            // crypto.GetNonZeroBytes(data);
            crypto.GetBytes(data);
            var result = new StringBuilder(size);
            foreach (byte b in data)
            { result.Append(chars[b % (chars.Length - 1)]); }
            return result.ToString();
        }


        public static string UsingDateTime() => DateTime.Now.ToString().GetHashCode().ToString("x");
    }
}
