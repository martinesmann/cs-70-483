using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Wincubate.Module15.Slide06
{
   [Serializable]
   class ShoppingCartItem
   {
      public int productId;
      public decimal price;
      public int quantity;
      private decimal total;

      public ShoppingCartItem( int _productID, decimal _price, int _quantity )
      {
         productId = _productID;
         price = _price;
         quantity = _quantity;
         total = price * quantity;
      }
   }

   class Program
   {
      static void Main( string[] args )
      {
         string filename = @"C:\Tmp\Item.bin";
         ShoppingCartItem item = new ShoppingCartItem( 1, 19.95M, 2 );

         // Serializing
         using( FileStream fs = File.Create( filename ) )
         {
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize( fs, item );
         }

         // Deserializing
         ShoppingCartItem retrieved = null;
         using( FileStream fs = File.Open( filename, FileMode.Open ) )
         {
            IFormatter formatter = new BinaryFormatter();
            retrieved = formatter.Deserialize( fs ) as ShoppingCartItem;
         }

         Console.ReadLine();
      }
   }
}
