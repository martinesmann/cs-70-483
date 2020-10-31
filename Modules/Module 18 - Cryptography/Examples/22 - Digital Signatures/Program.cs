using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Wincubate.Module18.Slide22
{
   class Program
   {
      static void Main(string[] args)
      {
         string filename = @"C:\Tmp\Demo.txt";

         #region Signing
         string publicKey = null;
         byte[] signature = null;

         DSACryptoServiceProvider signer = new DSACryptoServiceProvider();
         using (FileStream fs = File.Open(filename, FileMode.Open, FileAccess.Read))
         {
            using (BinaryReader reader = new BinaryReader(fs))
            {
               byte[] data = reader.ReadBytes((int)fs.Length);
               signature = signer.SignData(data);

               publicKey = signer.ToXmlString(false);
               Console.WriteLine("Signature: " + Convert.ToBase64String(signature));
            }
         }
         #endregion

         #region Verifying
         DSACryptoServiceProvider verifier = new DSACryptoServiceProvider();
         verifier.FromXmlString(publicKey);
         using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
         {
            using (BinaryReader reader = new BinaryReader(fs))
            {
               byte[] receivedData = reader.ReadBytes((int) fs.Length);
               if (verifier.VerifyData(receivedData, signature))
               {
                  Console.WriteLine("Signature was successfully verified");
               }
               else
               {
                  Console.WriteLine("Signature could NOT be verified");
               }
            }
         }
         #endregion
      }
   }
}
