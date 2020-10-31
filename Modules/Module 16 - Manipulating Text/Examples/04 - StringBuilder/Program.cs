using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module16.Slide04
{
   class Program
   {
      static void Main( string[] args )
      {
         string tableHeader = "{0,-6} {1,-7} {2,-10} {3,-16} {4,16} {5,16}\n";
         string tableRow = "{0,-6} {1,-7} {2,-10} {3,-16} {4,16:N0} {5,16:N0}\n";

         StringBuilder sb = new StringBuilder();

         foreach( DriveInfo di in DriveInfo.GetDrives() )
         {
            if( di.IsReady )
            {
               sb.AppendFormat( tableRow,
                            di.Name, di.DriveFormat, di.VolumeLabel, di.DriveType,
                            di.TotalSize, di.AvailableFreeSpace,
                            Environment.NewLine );
            }
         }

         string header = string.Format( tableHeader, "Drive", "Format", "Label", "Type", "Size", "Available"  );
         sb.Insert( 0, header );

         Console.WriteLine( sb.ToString() );
      }
   }
}
