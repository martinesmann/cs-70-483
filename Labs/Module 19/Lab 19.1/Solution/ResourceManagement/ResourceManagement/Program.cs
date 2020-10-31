using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagement
{
   class Program
   {
      static void Main( string[] args )
      {
         string ns = "ResourceManagement.Properties.Resources";
         Assembly assembly = Assembly.GetExecutingAssembly();
         ResourceManager rm = new ResourceManager( ns, assembly );

         CultureInfo ci = new CultureInfo( "en-US" );
         //CultureInfo ci = new CultureInfo( "da-DK" );
         //CultureInfo ci = new CultureInfo( "de-AT" );
         //CultureInfo ci = new CultureInfo( "es-US" );
         //CultureInfo ci = new CultureInfo( "fr" );
         Console.WriteLine( rm.GetString( "Monday", ci ) );
      }
   }
}
