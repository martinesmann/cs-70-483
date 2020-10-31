using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace CustomPerformanceCounter
{
   public partial class PerformanceCounterForm : Form
   {
      // PerformanceCounter constants
      public static string CategoryName = "Wincubate";
      public static string CategoryHelp = "Counters for the 70-483 course";

      public static PerformanceCounter CounterTotal = null;
      public static PerformanceCounter CounterRate = null;
      
      // State
      private List<A> _list = new List<A>();

      public PerformanceCounterForm()
      {
         InitializeComponent();
      }

      private void OnCreatePerformanceCounterCategoryClick( object sender, EventArgs e )
      {
         // TODO 1: Create performance counter category (if it does not exist)
      }

      private void OnCreatePerformanceCountersClick( object sender, EventArgs e )
      {
         if ( CounterTotal == null )
         {
            // TODO 2: Create performance counter for Total Number of A Objects
            // CounterTotal = ...;
         }

         if ( CounterRate == null )
         {
            // TODO 3: Create performance counter for Rate of A Objects being created per second
            // CounterRate = ...;
         }
      }

      private void OnCreateAInstanceClick( object sender, EventArgs e )
      {
         Debug.Assert( CounterTotal != null );
         Debug.Assert( CounterRate != null );

         A a = new A();
         _list.Add( a );
      }

      private void OnDisposeAInstanceClick( object sender, EventArgs e )
      {
         Debug.Assert( CounterTotal != null );
         Debug.Assert( CounterRate != null );

         if( _list.Count > 0 )
         {
            A a = _list[ 0 ];
            a.Dispose();

            _list.RemoveAt( 0 );
         }
      }

      private void OnGetCounterValueClick( object sender, EventArgs e )
      {
         Debug.Assert( CounterTotal != null );

         // TODO 4: Display CounterTotal value in MessageBox
      }

      private void OnDeletePerformanceCounterCategoryClick( object sender, EventArgs e )
      {
         // TODO 5: Create performance counter category (if it exists)
      }
   }
}
