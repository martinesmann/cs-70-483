using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;

namespace Wincubate.Module11.Slide05
{
   class Program
   {
      static void Main(string[] args)
      {
         Assembly assembly = Assembly.GetExecutingAssembly();
         foreach (Type typeInAsm in assembly.GetTypes())
         {
            Console.WriteLine("Type: {0}", typeInAsm);

            //Type typeByName = assembly.GetType( type.FullName );
            //Debug.Assert( typeByName == typeInAsm );
         }

         Type type = typeof(Player);
         
         //BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
         //FieldInfo[] fields = type.GetFields( /* flags */ );

         FieldInfo[] fields = type.GetFields();
         foreach (FieldInfo fi in fields)
         {
            Console.WriteLine("Field: {0}", fi);
         }

         PropertyInfo[] properties = type.GetProperties();
         foreach (PropertyInfo pi in properties)
         {
            Console.WriteLine("Property: {0}", pi);
         }

         ConstructorInfo[] constructors = type.GetConstructors();
         foreach (ConstructorInfo ci in constructors)
         {
            Console.WriteLine("Constructors: {0}", ci);
         }

         MethodInfo[] methods = type.GetMethods();
         foreach (MethodInfo mi in methods)
         {
            Console.WriteLine("Method: {0}", mi);
         }

         EventInfo[] events = type.GetEvents();
         foreach (EventInfo ei in events)
         {
            Console.WriteLine("Event: {0}", ei);
         }
      }
   }
}
