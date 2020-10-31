using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Disposable
{
    class Program
    {
        static void Main( string[] args )
        {
            using( DoubleFileWriter fileWriter = new DoubleFileWriter() )
            {
                fileWriter.Log();
                fileWriter.Log();
                fileWriter.Log();

                fileWriter.LogDate();
                fileWriter.LogDate();

                // FileWriter is no longer needed
            }

            Console.WriteLine( "Waiting to terminate..." );
            Console.ReadLine();
        }
    }
}
