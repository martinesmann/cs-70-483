using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace Wincubate.Module15.Slide13
{
    public class ShoppingCartItem : IXmlSerializable
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

        #region IXmlSerializable Members

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml( XmlReader reader)
        {
            productId = int.Parse(reader.ReadString());
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(productId.ToString());
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Tmp\ItemCustom.xml";
            ShoppingCartItem item = new ShoppingCartItem(1, 19.95M, 2);

            // XML serialize
            using (FileStream fs = File.Create(filename))
            {
                XmlSerializer xs = new XmlSerializer(typeof(ShoppingCartItem));
                xs.Serialize(fs, item);
            }

            // XML deserialize
            ShoppingCartItem retrieved = null;
            using (FileStream fs = File.Open(filename, FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(ShoppingCartItem));
                retrieved = xs.Deserialize(fs) as ShoppingCartItem;
            }

            Console.ReadLine();
        }
    }
}
