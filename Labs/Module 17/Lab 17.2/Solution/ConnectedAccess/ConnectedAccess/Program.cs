using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ConnectedAccess
{
   class Program
   {
      static void Main( string[] args )
      {
         using ( SqlConnection connection = new SqlConnection(
            ConfigurationManager.ConnectionStrings[ "MySqlServer" ].ConnectionString ) )
         {
            connection.Open();
            SqlCommand command = new SqlCommand(
               "SELECT * FROM People ORDER by FirstName; " +
               "SELECT * FROM People ORDER by LastName", connection );

            using ( SqlDataReader reader = command.ExecuteReader() )
            {
               do
               {
                  while ( reader.Read() )
                  {
                     Console.WriteLine(
                        string.Format( "{0}: {1} {2} born {3}",
                           reader[ "id" ],
                           reader[ "FirstName" ],
                           reader[ "LastName" ],
                           reader[ "BirthDate" ]
                        )
                     );
                  }

                  Console.WriteLine( "-------" );
               }
               while ( reader.NextResult() );
            }
         }
      }
   }
}
