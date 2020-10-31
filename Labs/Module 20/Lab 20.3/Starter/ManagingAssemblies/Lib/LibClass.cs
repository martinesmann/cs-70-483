using System.Reflection;

namespace Lib
{
    public static class LibClass
    {
       public static string GetVersion()
       {
          return
             Assembly.GetExecutingAssembly().GetName().Version.ToString()
             + " not in the GAC";
       }
    }
}
