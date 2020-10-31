using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Wincubate.Module15.Slide16
{
   [DataContract]
   class ShoppingCartItem
   {
      [DataMember]
      public int productId;
      [DataMember]
      public decimal price;
      [DataMember]
      public int quantity;
      [DataMember]
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
         string filename = @"C:\Tmp\Item.json";
         ShoppingCartItem item = new ShoppingCartItem( 1, 19.95M, 2 );

         DataContractJsonSerializer serializer = new DataContractJsonSerializer( typeof( ShoppingCartItem ) );

         // Serializing
         using ( FileStream fs = File.Create( filename ) )
         {
            serializer.WriteObject( fs, item );
         }

         // Deserializing
         ShoppingCartItem retrieved = null;
         using ( FileStream fs = File.Open( filename, FileMode.Open ) )
         {
            retrieved = serializer.ReadObject( fs ) as ShoppingCartItem;
         }

         Console.ReadLine();
      }
   }
}
