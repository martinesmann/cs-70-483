using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Wincubate.Module15.Slide20
{
    [Serializable]
    class ShoppingCartItem : IDeserializationCallback
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

        [OnSerializing]
        public void SerializingMethod(StreamingContext sc)
        {
            Console.WriteLine("[OnSerializing]");
        }

        [OnSerialized]
        public void SerializedMethod(StreamingContext sc)
        {
            Console.WriteLine("[OnSerialized]");
        }

        [OnDeserializing]
        public void DeserializingMethod(StreamingContext sc)
        {
            Console.WriteLine("[OnDeserializing]");
        }

        [OnDeserialized]
        public void DeserializedMethod(StreamingContext sc)
        {
            Console.WriteLine("[OnDeserialized]");

            CalculateTotal();
        }

        #region IDeserializationCallback Members

        public void OnDeserialization(object sender)
        {
            //// Figure 5.1, p. 206
            //Console.WriteLine("IDeserializationCallback.OnDeserialization");
            
            CalculateTotal();
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Tmp\ItemEvents.bin";
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
