using System;

namespace Wincubate.Module11.Slide05
{
   [AttributeUsage(AttributeTargets.Class)]
   public class DeveloperInfoAttribute : System.Attribute
   {
      public DeveloperInfoAttribute(string developer)
      {
         Developer = developer;
      }

      public string Developer { get; set; }
      public string Date { get; set; }
      public int Revision { get; set; }
   }
}
