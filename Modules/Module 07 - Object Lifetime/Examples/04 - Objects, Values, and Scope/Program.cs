﻿using System;

namespace Wincubate.Module07.Slide04
{
    class A
    {
        public A( int x )
        {
            this.x = x;
        }
        public int x;
    }

    class Program
    {
        static void Main()
        {
            bool b = true;
            A longLivingVariable;

            if( b )
            {
                int i = 0;
                while( true )
                {
                    A c = new A( i );
                    i++;

                    if( i % 100 == 0 )
                    {
                        longLivingVariable = c;
                    }
                }
            }
        }
    }
}
