using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module09.Question
{
   #region Background
   public class Customer
   {
      string _name;

      public Customer( string name )
      {
         _name = name;
      }
   }
   #endregion

   public delegate void AddCustomerCallback( int n );
   public class CustomerTracker
   {
      List<Customer> _customers = new List<Customer>();
      public void AddCustomer( string name, AddCustomerCallback callback )
      {
         _customers.Add( new Customer( name ) );
         callback( _customers.Count );
      }
   }

   public class Handler
   {
      CustomerTracker _tracker = new CustomerTracker();
      public void Add( string name )
      {
         _tracker.AddCustomer( name, delegate( int i )
         {
            Console.WriteLine( "There are {0} customer(s)", i );
         }
         );
      }
   }

   class Program
   {
      static void Main( string[] args )
      {
         Handler h = new Handler();
         h.Add( "Jesper" );
      }
   }

}
