﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module09.Slide17
{
    public class Subscriber
    {
        public Subscriber( string name, Publisher publisher )
        {
            this.name = name;

            publisher.NewInfo += PublisherUpdated;
        }

        protected void PublisherUpdated( object sender, NewInfoEventArgs e )
        {
            Console.WriteLine( "{0} received new info from publisher: {1}", name, e.TimeStamp );
        }

        private string name;
    }
}
