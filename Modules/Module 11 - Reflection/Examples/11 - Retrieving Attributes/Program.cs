using System;
using System.Reflection;

namespace Wincubate.Module11.Slide11
{
   class Program
   {
      static void Main(string[] args)
      {
         Assembly assembly = Assembly.GetExecutingAssembly();
         
         foreach( Attribute attribute in assembly.GetCustomAttributes(false))
         {
            if (attribute.GetType() == typeof(AssemblyCopyrightAttribute))
            {
               Console.WriteLine("Copyright: {0}",
                  (attribute as AssemblyCopyrightAttribute).Copyright);
            }

            if (attribute.GetType() == typeof(AssemblyCompanyAttribute))
            {
               Console.WriteLine("Company: {0}",
                  (attribute as AssemblyCompanyAttribute).Company);
            }

            if (attribute.GetType() == typeof(AssemblyDescriptionAttribute))
            {
               Console.WriteLine("Description: {0}",
                  (attribute as AssemblyDescriptionAttribute).Description);
            }
         }
      }
   }
}
