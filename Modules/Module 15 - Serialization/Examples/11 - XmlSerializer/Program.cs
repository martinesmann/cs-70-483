using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Wincubate.Module15.Slide11
{
   public class ShoppingCartItem
   {
      public int productId;
      public decimal price;
      public int quantity;
      public decimal total;

      public ShoppingCartItem()
      {
      }

      public ShoppingCartItem( int _productID, decimal _price, int _quantity )
      {
         productId = _productID;
         price = _price;
         quantity = _quantity;

         CalculateTotal();
      }

      void CalculateTotal()
      {
         total = price * quantity;
      }
   }

   class Program
   {
      static void Main( string[] args )
      {
         string filename = @"C:\Tmp\Item.xml";
         ShoppingCartItem item = new ShoppingCartItem( 1, 19.95M, 2 );

         // XML serialize
         using( FileStream fs = File.Create( filename ) )
         {
            XmlSerializer xs = new XmlSerializer( typeof( ShoppingCartItem ) );
            xs.Serialize( fs, item );
         }

         // XML deserialize
         ShoppingCartItem retrieved = null;
         using( FileStream fs = File.Open( filename, FileMode.Open ) )
         {
            XmlSerializer xs = new XmlSerializer( typeof( ShoppingCartItem ) );
            retrieved = xs.Deserialize( fs ) as ShoppingCartItem;
         }

         Console.ReadLine();
      }
   }
}
