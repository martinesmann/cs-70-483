using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricEncryption
{
   class Program
   {
      static void Main( string[] args )
      {
         string inputFilename = @"..\..\Test.txt";
         string outputFilename = @"..\..\Test.txt.encrypted";
         string decryptedFilename = @"..\..\Test.decrypted.txt";

         // We automatically generate Key and IV instead of
         // generating it via password + salt as in the slide
         byte[] key = null;
         byte[] iv = null;

         // TODO: Create encryption here

         // TODO: Create decryption here

      }
   }
}
