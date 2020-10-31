using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Wincubate.Module18.Slide11
{
   class Program
   {
      static void Main(string[] args)
      {
         RSACryptoServiceProvider decryptor = new RSACryptoServiceProvider();
         RSAParameters publicKey = decryptor.ExportParameters(false);

         #region Encrypt
         string messageString = "Hello, World!";
         RSACryptoServiceProvider encryptor = new RSACryptoServiceProvider();
         encryptor.ImportParameters(publicKey);
         byte[] messageBytes = Encoding.Unicode.GetBytes(messageString);
         byte[] encryptedMessage = encryptor.Encrypt(messageBytes, false);
         #endregion

         #region Decrypt
         byte[] decryptedBytes = decryptor.Decrypt(encryptedMessage, false);
         Console.WriteLine(Encoding.Unicode.GetString(decryptedBytes));
         #endregion

         Console.ReadLine();
      }
   }
}
