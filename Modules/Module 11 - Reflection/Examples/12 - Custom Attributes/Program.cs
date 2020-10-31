using System;
using System.Reflection;
using Wincubate.Module11.Slide05;

namespace Wincubate.Module11.Slide12
{
   class Program
   {
      static void Main(string[] args)
      {
         MemberInfo type = typeof(Player);
         object[] attributes = type.GetCustomAttributes(false);

         // Iterate through attributes
         foreach (object attr in attributes)
         {
            if (attr is DeveloperInfoAttribute)
            {
               DeveloperInfoAttribute dia = attr as DeveloperInfoAttribute;
               Console.WriteLine("Revision {2} developed by {0} on {1}",
                  dia.Developer,
                  dia.Date,
                  dia.Revision
               );
            }
         }
      }
   }
}
