using System;
using System.Reflection;
using Wincubate.Module11.Slide05;

namespace Wincubate.Module11.Slide07
{
   class Program
   {
      static void Main(string[] args)
      {
         Type t = typeof( Player );
         
         // Create Player object
         ConstructorInfo ci = t.GetConstructor(new Type[] { typeof(string), typeof(int) });
         object player = ci.Invoke( new object[] { "Davit Devdariani", 30 });

         MethodInfo setPositionMethod = t.GetMethod("SetPosition");
         setPositionMethod.Invoke(player, new Object[] { Position.Midfielder });

         Console.WriteLine(player);
      }
   }
}
