using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main( string[] args )
        {
            string shakespeare = "Hamlet: Do you see that cloud, that's almost in shape like a camel?\n" +
                   "Polonius: By the mass, and 't is like a camel, indeed. \n" +
                   "Hamlet: Methinks, it is like a weasel. \n" +
                   "Polonius: It is backed like a weasel. \n" +
                   "Hamlet: Or, like a whale? \n" +
                   "Polonius: Very like a whale.";

            // Indtast antal streng-iterationer
            Console.WriteLine( "Indtast antal streng-iterationer: " );
            int iterations = int.Parse( Console.ReadLine() );

            // Time stamp for begyndelse af program
            DateTime begin = DateTime.Now;

            #region String Manipulations

            //string result = shakespeare;
            //int number = 0;
            //while( number < iterations )
            //{
            //   string oneByOne = string.Empty;
            //   for( int i = 0 ; i < shakespeare.Length ; i++ )
            //   {
            //      oneByOne = result[ i ] + oneByOne;
            //   }

            //   result += oneByOne;
            //   number++;
            //}

            //// Forløbet tid
            //TimeSpan elapsed = DateTime.Now - begin;

            //Console.WriteLine(result);

            #endregion

            #region StringBuilder Manipulations

            StringBuilder result = new StringBuilder( shakespeare );
            int number = 0;
            while( number < iterations )
            {
                StringBuilder oneByOne = new StringBuilder();
                for( int i = 0; i < shakespeare.Length; i++ )
                {
                    oneByOne.Insert( 0, result[ i ] );
                }

                result.Append( oneByOne );
                number++;
            }

            string resultAsString = result.ToString();

            // Forløbet tid
            TimeSpan elapsed = DateTime.Now - begin;

            Console.WriteLine( resultAsString );

            #endregion

            Console.WriteLine( "Programmet kørte {0} millisekunder", elapsed.TotalMilliseconds );
        }
    }
}
