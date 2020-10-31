using System;
using System.IO;
using System.Security.Cryptography;

namespace Wincubate.Module18.Slide16
{
   class Program
   {
      static void Main(string[] args)
      {
         string filename = @"C:\Tmp\Demo.txt";

         MD5 myHash = new MD5CryptoServiceProvider();

         while (true)
         {
            using (FileStream fs = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
               BinaryReader reader = new BinaryReader(fs);
               myHash.ComputeHash(reader.ReadBytes((int)fs.Length));

               Console.WriteLine(Convert.ToBase64String(myHash.Hash));
            }

            Console.ReadLine();
         }
      }
   }
}
