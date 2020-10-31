using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module09.Slide20
{
    public class Publisher
    {
       public event EventHandler<NewInfoEventArgs> NewInfo;

       public void CreateNewInfo()
       {
          var del = NewInfo; 
          if( del != null )
          {
             del( this, new NewInfoEventArgs() );
          }
       }
    }
}
