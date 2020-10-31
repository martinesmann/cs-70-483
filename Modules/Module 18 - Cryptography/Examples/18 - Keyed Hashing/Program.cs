using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Wincubate.Module18.Slide18
{
   class Program
   {
      static void Main(string[] args)
      {
         string filename = @"C:\Tmp\Demo.txt";

         while (true)
         {
            Console.WriteLine("Please input password for key generation: ");
            string password = Console.ReadLine();

            byte[] saltValueBytes = Encoding.ASCII.GetBytes("This is my sa1t");
            Rfc2898DeriveBytes passwordKey =
            new Rfc2898DeriveBytes(password, saltValueBytes);
            byte[] secretKey = passwordKey.GetBytes(16);

            HMACSHA1 myHash = new HMACSHA1(secretKey);

            using (FileStream fs = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
               using (BinaryReader reader = new BinaryReader(fs))
               {
                  myHash.ComputeHash(reader.ReadBytes((int)fs.Length));
                  Console.WriteLine(Convert.ToBase64String(myHash.Hash));
               }
            }
         }
      }
   }
}
