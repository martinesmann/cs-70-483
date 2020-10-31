using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ControllingSerialization
{
   class Program
   {
      static void Main( string[] args )
      {
         string filename = @"C:\Tmp\Customer.xml";
         Customer customer = new Customer
         {
            Id = 87,
            Name = "Jesper Gulmann Henriksen",
            LastUpdated = DateTime.Now,
            BonusCredits = 2
         };

         // XML serialize
         using ( FileStream fs = File.Create( filename ) )
         {
            XmlSerializer xs = new XmlSerializer( typeof( Customer ) );
            xs.Serialize( fs, customer );
         }

         //// XML deserialize
         //Customer retrieved = null;
         //using ( FileStream fs = File.Open( filename, FileMode.Open ) )
         //{
         //   XmlSerializer xs = new XmlSerializer( typeof( Customer ) );
         //   retrieved = xs.Deserialize( fs ) as Customer;
         //}

         //Console.ReadLine();
      }
   }
}
