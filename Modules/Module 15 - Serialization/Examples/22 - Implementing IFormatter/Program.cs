using System;
using System.Runtime.Serialization;
using System.IO;

namespace Wincubate.Module15.Slide22
{
    [Serializable]
    class ShoppingCartItem
    {
        public int productId;
        public decimal price;
        public int quantity;
        private decimal total;

        public ShoppingCartItem(int _productID, decimal _price, int _quantity)
        {
            productId = _productID;
            price = _price;
            quantity = _quantity;
            total = price * quantity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Tmp\Item.ini";
            ShoppingCartItem item = new ShoppingCartItem(1, 19.95M, 2);

            // Serializing
            using (FileStream fs = File.Create(filename))
            {
                IniFormatter formatter = new IniFormatter();
                formatter.Serialize(fs, item);
            }

            // Deserializing
            ShoppingCartItem retrieved = null;
            using (FileStream fs = File.Open(filename, FileMode.Open))
            {
                IniFormatter formatter = new IniFormatter();
                retrieved = formatter.Deserialize(fs) as ShoppingCartItem;
            }

            Console.WriteLine();
        }
    }
}
