using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module20.Slide15
{
   /// <summary>
   /// Class implementing the Disposable pattern of IDesign.
   /// </summary>
   public class A : IDisposable
   {
      public A()
      {
         PerformanceCounterForm.Counter.Increment();
      }

      #region IDisposable Members

      /// <summary>
      /// Destructor used for implementing the Disposable pattern of IDesign.
      /// Cleans up and disposes unmanaged resources if necessary.
      /// </summary>
      ~A()
      {
         Cleanup();
      }

      /// <summary>
      /// IDisposable clean-up method. Frees any resources.
      /// </summary>
      protected virtual void Cleanup()
      {
         PerformanceCounterForm.Counter.Decrement();
      }

      /// <summary>
      /// Gets whether the object is disposed.
      /// </summary>
      protected bool Disposed
      {
         get
         {
            lock( this )
            {
               return m_Disposed;
            }
         }
      }
      bool m_Disposed = false;

      /// <summary>
      /// Method implementing main cleanup required when implementing IDisposable.
      /// Always remember to invoke this method explicitly or implicitly when cleaning up the object!
      /// </summary>
      public void Dispose()
      {
         lock( this )
         {
            if( m_Disposed == false )
            {
               Cleanup();
               m_Disposed = true;
               GC.SuppressFinalize( this );
            }
         }
      }

      #endregion
   }
}
