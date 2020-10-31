using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
   class Program
   {
      static void Main( string[] args )
      {
         MemberInfo type = typeof( TestClass );
         object[] attributes = type.GetCustomAttributes( false );

         // Iterate through attributes
         foreach ( object attr in attributes )
         {
            if ( attr is DeveloperInfoAttribute )
            {
               DeveloperInfoAttribute dia = attr as DeveloperInfoAttribute;
               Console.WriteLine( "Revision {2} developed by {0} on {1}",
                  dia.Developer,
                  dia.Date,
                  dia.Revision
               );
            }
         }
      }
   }
}
