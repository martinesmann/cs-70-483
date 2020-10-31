using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide14
{
    interface IArtist
    {
        void Draw();
    }

    interface IGunslinger
    {
        void Draw();
    }

    class ArtisticCowboy : IArtist, IGunslinger
    {
        void IArtist.Draw()
        {
            Console.WriteLine( "Swing brush and paint on the canvas..." );
        }
        void IGunslinger.Draw()
        {
            Console.WriteLine( "Draw Magnum .45 from gunbelt..." );
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            ArtisticCowboy ac = new ArtisticCowboy();

            //ac.Draw();

            IArtist artist = ac as IArtist;
            artist.Draw();

            IGunslinger gunslinger = ac as IGunslinger;
            gunslinger.Draw();
        }
    }
}
