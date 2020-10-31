using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module14.Slide06
{
   class Program
   {
      static void Main( string[] args )
      {
         Console.WriteLine( "{0,-6} {1,-7} {2,-10} {3,-16} {4,16} {5,16}",
            "Drive", 
            "Format", 
            "Label", 
            "Type", 
            "Size", 
            "Available"
         );

         foreach( DriveInfo di in DriveInfo.GetDrives() )
         {
            if( di.IsReady )
            {
               Console.WriteLine( "{0,-6} {1,-7} {2,-10} {3,-16} {4,16:N0} {5,16:N0}",
                  di.Name, di.DriveFormat, di.VolumeLabel, di.DriveType,
                  di.TotalSize, di.AvailableFreeSpace );
            }
         }
      }
   }
}
