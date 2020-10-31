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
         if ( PerformanceCounterCategory.Exists( CategoryName ) == false )
         {
            CounterCreationDataCollection ccdc = new CounterCreationDataCollection
            {
               new CounterCreationData(
                  "# A objects in the application",
                  "Total number of A instances",
                  PerformanceCounterType.NumberOfItems32
               ),
               new CounterCreationData(
                  "# A objects created per second",
                  "Total number of A instances created per second",
                  PerformanceCounterType.RateOfCountsPerSecond32
               )
            };

            PerformanceCounterCategory.Create(
               CategoryName,
               CategoryHelp,
               PerformanceCounterCategoryType.MultiInstance,
               ccdc
            );
         }
      }

      private void OnCreatePerformanceCountersClick( object sender, EventArgs e )
      {
         if ( CounterTotal == null )
         {
            // TODO 2: Create performance counter for Total Number of A Objects
            CounterTotal = new PerformanceCounter(
               CategoryName,
               "# A objects in the application",
               Assembly.GetEntryAssembly().FullName,
               false
            );
         }

         if ( CounterRate == null )
         {
            // TODO 3: Create performance counter for Rate of A Objects being created per second
            CounterRate = new PerformanceCounter(
               CategoryName,
               "# A objects created per second",
               Assembly.GetEntryAssembly().FullName,
               false
            );
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
         MessageBox.Show( CounterTotal.RawValue.ToString() );
      }

      private void OnDeletePerformanceCounterCategoryClick( object sender, EventArgs e )
      {
         // TODO 5: Create performance counter category (if it exists)
         if ( PerformanceCounterCategory.Exists( CategoryName ) )
         {
            PerformanceCounterCategory.Delete( CategoryName );
         }
      }
   }
}
