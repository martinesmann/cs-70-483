using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
   [AttributeUsage( AttributeTargets.Class, AllowMultiple=true )]
   public class DeveloperInfoAttribute : System.Attribute
   {
      public DeveloperInfoAttribute( string developer )
      {
         Developer = developer;
         Revision = 1;
      }

      public string Developer { get; set; }
      public string Date { get; set; }
      public int Revision { get; set; }
   }
}
