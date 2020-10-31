using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Wincubate.Module16.Slide11
{
   class Program
   {
      static void Main( string[] args )
      {
         string input = "Company Name: Contoso, Inc.";
         Match m = Regex.Match( input, @"Company Name: (.*$)" );

         //Console.WriteLine( m.Groups[ 0 ] );

         Console.WriteLine( m.Groups[ 1 ] );
      }
   }
}
