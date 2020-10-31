using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
   public class LineUp
   {
      private IDictionary<int, ISet<string>> _mapping;

      public LineUp()
      {
         _mapping = new Dictionary<int, ISet<string>>();
      }

      public void Add( int number, string player )
      {
         if ( _mapping.ContainsKey( number ) == false )
         {
            _mapping[ number ] = new HashSet<string>();
         }
         _mapping[ number ].Add( player );
      }

      public IEnumerable<int> GetSharedNumbers()
      {
         foreach ( var kv in _mapping )
         {
            if ( kv.Value.Count() > 1 )
            {
               yield return kv.Key;
            }
         }
      }
   }
}
