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

namespace Wincubate.Module20.Slide15
{
   public partial class PerformanceCounterForm : Form
   {
      public static PerformanceCounter Counter = null;
      
      List<A> m_List = new List<A>();

      public PerformanceCounterForm()
      {
         InitializeComponent();
      }

      private void btnCreatePerformanceCounter_Click( object sender, EventArgs e )
      {
         PerformanceCounterCategory category =
            PerformanceCounterCategory.Create(
               "Wincubate",
               "Counters for the 70-483 course",
               PerformanceCounterCategoryType.MultiInstance,
               "A instances",
               "Number of live A objects in the application" );
      }

      private void btnCreatePerformanceCounter_Click_1( object sender, EventArgs e )
      {
         Debug.Assert( Counter == null );

         Counter = new PerformanceCounter( "Wincubate", "A instances", Assembly.GetEntryAssembly().FullName, false );
      }

      private void btnCreateA_Click( object sender, EventArgs e )
      {
         Debug.Assert( Counter != null );

         A a = new A();
         m_List.Add( a );
      }

      private void btnDisposeA_Click( object sender, EventArgs e )
      {
         Debug.Assert( Counter != null );

         if( m_List.Count > 0 )
         {
            A a = m_List[ 0 ];
            a.Dispose();

            m_List.RemoveAt( 0 );
         }
      }

      private void btnGetCounterValue_Click( object sender, EventArgs e )
      {
         Debug.Assert( Counter != null );

         MessageBox.Show( Counter.RawValue.ToString() );
      }

      private void btnDeletePerformanceCounterCategory_Click( object sender, EventArgs e )
      {
         PerformanceCounterCategory.Delete( "Wincubate" );
      }
   }
}
