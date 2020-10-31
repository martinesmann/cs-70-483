using System;

namespace Wincubate.Module07.Slide22
{
    class Program
    {
        static void Main( string[] args )
        {
            using( MyDisposableClass disp = new MyDisposableClass() )
            {
                //disp.Method1();

                // ...

                //disp.Methodn();
            }
        }
    }
}
