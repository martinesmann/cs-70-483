using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Disposable
{
    class FileWriter : IDisposable
    {
        public bool IsDisposed
        {
            get
            {
                return _disposed;
            }
        }
        private bool _disposed = false;

        protected FileStream _fs;

        public FileWriter()
        {
            _fs = File.Create( @"FileWriter.txt" );
        }

        ~FileWriter()
        {
            CleanUp( false );
        }

        // Note: Do NOT make this virtual!
        public void Dispose()
        {
            CleanUp( true );
            GC.SuppressFinalize( this );
        }

        protected virtual void CleanUp( bool disposing )
        {
            if( IsDisposed == false )
            {
                if( disposing )
                {
                    // Dispose managed here
                    _fs.Dispose();
                }

                // Clean up unmanaged here.
            }
            _disposed = true;
        }

        public void Log()
        {
            if( IsDisposed == true )
            {
                throw new ObjectDisposedException( "Object is already disposed!" );
            }

            string s = DateTime.Now.ToLongTimeString() + Environment.NewLine;
            _fs.Write( Encoding.ASCII.GetBytes( s ), 0, s.Length );
        }
    }
}
