using System.Reflection;

namespace Wincubate.Module20.Slide17
{
   public static class FancyClass
   {
      public static string WhichVersion()
      {
         return Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
   }
}
