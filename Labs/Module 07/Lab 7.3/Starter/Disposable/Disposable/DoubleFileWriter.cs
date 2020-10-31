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
            string s = DateTime.Now.ToLongDateString() + Environment.NewLine;
            _fsDate.Write( Encoding.ASCII.GetBytes( s ), 0, s.Length );
        }
    }
}
