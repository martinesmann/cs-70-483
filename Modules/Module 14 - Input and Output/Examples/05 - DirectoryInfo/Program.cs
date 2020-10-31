using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module14.Slide05
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Tmp");
            if (di.Exists)
            {
                Console.WriteLine("Directory was last accessed: " + di.LastAccessTime.ToLongTimeString());
            }

            #region Directories
            //DirectoryInfo[] dirs = di.GetDirectories();
            //foreach( DirectoryInfo dir in dirs )
            //{
            //   Console.WriteLine( "Directory: {0}", dir.Name );
            //}
            #endregion

            #region Files
            //FileInfo[] files = di.GetFiles();
            //foreach( FileInfo fi in files )
            //{
            //   Console.WriteLine( "File: {0}", fi.Name );
            //}
            #endregion
        }
    }
}