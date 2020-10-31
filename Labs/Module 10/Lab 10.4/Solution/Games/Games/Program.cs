using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Games
{
    class Program
    {
        static void Main( string[] args )
        {
            string[] wiiGames =
            {
                "Super Mario Galaxy", 
                "Guitar Hero III",
                "Wii Sports",
                "FIFA 09",
                "Wii Fit",
                "Legend of Zelda: Twilight Princess"
            };

            string[] xbox360Games = 
            {
                "Halo",
                "Lips",
                "FIFA 09",
                "Guitar Hero III",
                "Banjo Kazooie"
            };

            // TODO 1: All Wii games sorted by title
            var wiiGamesSortedByTitle = from g in wiiGames
                                        orderby g
                                        select g;

            foreach( var g in wiiGamesSortedByTitle )
            {
                Console.WriteLine( g );
            }

            Console.WriteLine();

            // TODO 2: All Wii games sorted by title length (longest title first)
            var wiiGamesSortedByLengthFirst = from g in wiiGames
                                              orderby g.Length descending
                                              select g;

            foreach( var g in wiiGamesSortedByLengthFirst )
            {
                Console.WriteLine( g );
            }

            Console.WriteLine();

            // TODO 3: All games for either machine sorted by title
            var allGames = from g in wiiGames.Union( xbox360Games )
                           orderby g
                           select g.ToUpper();

            foreach( var g in allGames )
            {
                Console.WriteLine( g );
            }

            Console.WriteLine();

            // TODO 4: All games for Wii (but not for Xbox 360) except those with 'Wii' in the title
            var WiiOnlyMinusWii = from g in wiiGames.Except( xbox360Games )
                                  where ( g.Contains( "Wii" ) == false )
                                  select g;
            foreach( var g in WiiOnlyMinusWii )
            {
                Console.WriteLine( g );
            }

            Console.WriteLine();
        }
    }
}
