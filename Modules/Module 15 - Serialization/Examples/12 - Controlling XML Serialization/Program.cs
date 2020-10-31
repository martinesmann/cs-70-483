using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Wincubate.Module15.Slide12
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

      public ShoppingCartItem(int _productID, decimal _price, int _quantity)
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

   public class DiscountedShoppingCartItem : ShoppingCartItem
   {
      public string discountCode;

      public DiscountedShoppingCartItem()
         : base()
      {
      }

      public DiscountedShoppingCartItem(int _productID, decimal _price, int _quantity, string discountCode)
         : base(_productID, _price, _quantity)
      {
         this.discountCode = discountCode;
      }
   }

   public class ShoppingCart
   {
      [XmlArray]
      //[XmlArrayItem(typeof(ShoppingCartItem))]
      //[XmlArrayItem(typeof(DiscountedShoppingCartItem))]
      public ShoppingCartItem[] items;
   }

   class Program
   {
      static void Main(string[] args)
      {
         string filename = @"C:\Tmp\Cart.xml";

         ShoppingCart cart = new ShoppingCart();

         ShoppingCartItem[] items = {
                new ShoppingCartItem( 1, 19.95M, 2 ),
                new ShoppingCartItem( 2, 29.95M, 1 ),
                //new DiscountedShoppingCartItem( 3, 99.95M, 1, "Tieto 70-536" )
         };
         cart.items = items;

         // Serialize
         using (FileStream fs = File.Create(filename))
         {
            XmlSerializer xs = new XmlSerializer(typeof(ShoppingCart));
            xs.Serialize(fs, cart);
         }

         //// XML deserialize
         //ShoppingCart retrieved = null;
         //using (FileStream fs = File.Open(filename, FileMode.Open))
         //{
         //    XmlSerializer xs = new XmlSerializer(typeof(ShoppingCart));
         //    retrieved = xs.Deserialize(fs) as ShoppingCart;
         //}

         Console.ReadLine();
      }
   }
}
