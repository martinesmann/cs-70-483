using System.Reflection;

namespace Lib
{
    public static class LibClass
    {
       public static string GetVersion()
       {
          return
             Assembly.GetExecutingAssembly().GetName().Version.ToString()
             + " in the GAC";
       }
    }
}
