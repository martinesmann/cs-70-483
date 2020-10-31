using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Wincubate.Module15.Slide21
{
    [Serializable]
    class ShoppingCartItem
    {
        public int productId;
        public decimal price;
        public int quantity;
        private decimal total;

        //[OptionalField(VersionAdded = 2)]
        public int carriedSinceYear;

        public ShoppingCartItem(int _productID, decimal _price, int _quantity)
        {
            productId = _productID;
            price = _price;
            quantity = _quantity;
            total = price * quantity;
            //carriedSinceYear = 2009;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Tmp\Itemv1.soap";
            ShoppingCartItem item = new ShoppingCartItem(1, 19.95M, 2);

            // Serializing
            using (FileStream fs = File.Create(filename))
            {
                IFormatter formatter = new SoapFormatter();
                formatter.Serialize(fs, item);
            }

            //// Deserializing
            //ShoppingCartItem retrieved = null;
            //using (FileStream fs = File.Open(filename, FileMode.Open))
            //{
            //    IFormatter formatter = new SoapFormatter();
            //    retrieved = formatter.Deserialize(fs) as ShoppingCartItem;
            //}

            Console.ReadLine();
        }
    }
}
