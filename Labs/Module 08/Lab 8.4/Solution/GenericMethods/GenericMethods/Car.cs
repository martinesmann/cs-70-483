using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMethods
{
    public class Car : IComparable<Car>
    {
        public const int MaxSpeed = 100;

        private int currSpeed;
        private string petName;

        public string ID
        {
            get
            {
                return carID;
            }
        }
        private string carID;

        public Car( string name, int currSp, string id )
        {
            currSpeed = currSp;
            petName = name;
            carID = id;
        }

        public int Speed
        {
            get
            {
                return currSpeed;
            }
            set
            {
                currSpeed = value;
            }
        }
        public string PetName
        {
            get
            {
                return petName;
            }
            set
            {
                petName = value;
            }
        }

        public int CompareTo( Car obj )
        {
            return ( carID.CompareTo( obj.carID ) );
        }
    }
}
