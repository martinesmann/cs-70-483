using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllingSerialization
{
   public class Customer
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public DateTime LastUpdated { get; set; }
      public int BonusCredits { get; set; }
   }
}
