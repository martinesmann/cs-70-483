using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Wincubate.Module15.Slide19
{
    [Serializable]
    class ShoppingCartItem : ISerializable
    {
        public int productId;
        public decimal price;
        public int quantity;
        [NonSerialized]
        public decimal total;

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

        #region ISerializable Members

        protected ShoppingCartItem(SerializationInfo info,
        StreamingContext context)
        {
            productId = info.GetInt32("ProductID");
            price = info.GetDecimal("Price");
            quantity = info.GetInt32("Quantity");

            CalculateTotal();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ProductID", productId);
            info.AddValue("Price", price);
            info.AddValue("Quantity", quantity);
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Tmp\ItemCustom.bin";
            ShoppingCartItem item = new ShoppingCartItem(1, 19.95M, 2);

            // Serializing
            using (FileStream fs = File.Create(filename))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, item);
            }

            // Deserializing
            ShoppingCartItem retrieved = null;
            using (FileStream fs = File.Open(filename, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                retrieved = formatter.Deserialize(fs) as ShoppingCartItem;
            }

            Console.ReadLine();
        }
    }
}
