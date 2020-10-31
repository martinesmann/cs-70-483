using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Wincubate.Module18.Slide06
{
   class Program
   {
      static void Main(string[] args)
      {
         string inputFilename = @"C:\Tmp\Demo.txt";
         string outputFilename = @"C:\Tmp\Demo.txt.enc";
         // string decryptedFilename = @"C:\Tmp\Demo.decrypted.txt";

         // We automatically generate Key and IV instead of
         // generating it via password + salt as in the slide
         byte[] key = null;
         byte[] iv = null;

         #region Encrypt
         // Create the Stream objects
         using (FileStream inputFile = new FileStream(inputFilename, FileMode.Open, FileAccess.Read),
                outputFile = new FileStream(outputFilename, FileMode.OpenOrCreate, FileAccess.Write))
         {
            // Create the SymmetricAlgorithm object
            SymmetricAlgorithm myAlg = new RijndaelManaged();

            // Specify a key (optional) and save it
            myAlg.GenerateKey();
            key = myAlg.Key;
            iv = myAlg.IV;

            // Read the unencrypted file into data
            byte[] data = new byte[inputFile.Length];
            inputFile.Read(data, 0, (int)inputFile.Length);

            // Create the ICryptoTransform object
            ICryptoTransform encryptor = myAlg.CreateEncryptor();

            // Create the CryptoStream object
            using (CryptoStream encryptStream = new CryptoStream(outputFile, encryptor, CryptoStreamMode.Write))
            {
               // Write the contents to the CryptoStream
               encryptStream.Write(data, 0, data.Length);
            }
         }
         #endregion

         #region Decrypt
         //// Create the Stream objects
         //using (FileStream inputFile = new FileStream(outputFilename, FileMode.Open, FileAccess.Read),
         //       decryptedFile = new FileStream(decryptedFilename, FileMode.OpenOrCreate, FileAccess.Write))
         //{
         //   // Create the SymmetricAlgorithm object
         //   SymmetricAlgorithm myAlg = new RijndaelManaged();

         //   // Restore key
         //   myAlg.Key = key;
         //   myAlg.IV = iv;

         //   // Create the ICryptoTransform object
         //   ICryptoTransform decryptor = myAlg.CreateDecryptor();

         //   // Create the CryptoStream object
         //   using (CryptoStream decryptStream = new CryptoStream(inputFile, decryptor, CryptoStreamMode.Read))
         //   {
         //      // Read the encrypted file into data
         //      byte[] data = new byte[inputFile.Length];
         //      decryptStream.Read(data, 0, data.Length);

         //      decryptedFile.Write(data, 0, (int)data.Length);
         //   }
         //}
         #endregion
      }
   }
}
