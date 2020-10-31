using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Wincubate.Module16.Slide15
{
   class Program
   {
      static void Main( string[] args )
      {
         //Regex regex = new Regex( @"(?<char>\w)\k<char>" );
         //Console.WriteLine( regex.IsMatch( "aa" ) );
         //Console.WriteLine( regex.IsMatch( "aaa" ) );
         //Console.WriteLine( regex.IsMatch( "abab" ) );

         //Regex regex = new Regex(@"(?<43>\w)\'43'");
         //Console.WriteLine(regex.IsMatch("aa"));
         //Console.WriteLine(regex.IsMatch("aaa"));
         //Console.WriteLine(regex.IsMatch("abab"));

         string input = "aababb";
         Regex regex = new Regex(@"(?<1>a)(?<1>\1b)*");
         Console.WriteLine(regex.IsMatch(input));

         //input += "abbb";
         //Console.WriteLine( regex.IsMatch( input ) );
      }
   }
}
