using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ControllingSerialization
{
   [XmlRoot( "User" )]
   public class Customer
   {
      [XmlAttribute( "UserId")]
      public int Id { get; set; }
      [XmlElement("FullName")]
      public string Name { get; set; }
      [XmlIgnore]
      public DateTime LastUpdated { get; set; }
      public int BonusCredits { get; set; }
   }
}
