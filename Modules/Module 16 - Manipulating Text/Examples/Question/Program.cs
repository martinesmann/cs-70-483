using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question
{
   class Program
   {
      static void Main( string[] args )
      {
      }

      bool ContainsEmail( string input )
      {
         string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b";
         Regex r = new Regex( pattern, RegexOptions.Compiled );
         return r.IsMatch( input );
      }
   }
}
