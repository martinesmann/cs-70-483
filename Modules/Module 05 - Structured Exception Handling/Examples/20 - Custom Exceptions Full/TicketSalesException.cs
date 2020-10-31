using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide20
{
    public class TicketSalesException : Exception
    {
        public DateTime TimeStamp { get; protected set; }
        public string Office { get; protected set; }

        public TicketSalesException()
        {
        }

        public TicketSalesException( string message )
            : base( message )
        {
        }

        public TicketSalesException( string message, Exception inner, string office, DateTime timeStamp )
            : base( message, inner )
        {
            Office = office;
            TimeStamp = timeStamp;

            this.HelpLink = "http://www.wincubate.net";
        }

        public override string Message
        {
            get
            {
                return string.Format( "{0} Error Message at {1}: {2}", Office, TimeStamp, base.Message );
            }
        }
    }
}
