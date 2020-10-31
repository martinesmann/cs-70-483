using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Disposable
{
    class DoubleFileWriter : FileWriter
    {
        protected FileStream _fsDate;

        public DoubleFileWriter()
        {
            _fsDate = File.Create( @"FileWriterDate.txt" );
        }

        public void LogDate()
        {
            if( IsDisposed == true )
            {
                throw new ObjectDisposedException( "Object is already disposed!" );
            }

            string s = DateTime.Now.ToLongDateString() + Environment.NewLine;
            _fsDate.Write( Encoding.ASCII.GetBytes( s ), 0, s.Length );
        }

        protected override void CleanUp( bool disposing )
        {
            if( IsDisposed == false )
            {
                try
                {
                    if( disposing )
                    {
                        // Dispose managed here
                        _fsDate.Dispose();
                    }

                    // Clean up unmanaged here.
                }
                finally
                {
                    base.CleanUp( disposing );
                }
            }
        }
    }
}
