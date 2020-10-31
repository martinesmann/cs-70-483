using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Wincubate.Module17.Slide05
{
   class Program
   {
      static void Main( string[] args )
      {
         #region List all connection strings

         //ConnectionStringSettingsCollection collection = ConfigurationManager.ConnectionStrings;
         //foreach ( ConnectionStringSettings settings in collection )
         //{
         //   Console.WriteLine( "Name: {0}", settings.Name );
         //   Console.WriteLine( "Connection string: {0}", settings.ConnectionString );
         //   Console.WriteLine( "Provider: {0}", settings.ProviderName );
         //   Console.WriteLine( "Source: {0}", settings.ElementInformation.Source );

         //   Console.WriteLine();
         //}

         #endregion

         #region Using connection
         
         //string connectionString = "data source=localhost; Integrated Security=SSPI; Database=20483;";
         //using ( SqlConnection connection = new SqlConnection( connectionString ) )
         //{
         //   connection.Open();

         //   // ...
         //}

         #endregion
         
         #region ExecuteNonQuery()
         
         //using (SqlConnection connection = new SqlConnection(
         //   ConfigurationManager.ConnectionStrings[ "SqlServer2012" ].ConnectionString ))
         //{
         //   SqlCommand command = connection.CreateCommand();
         //   command.CommandType = CommandType.Text;
         //   command.CommandText = "UPDATE People SET FirstName = 'Hidi' WHERE Id = 7";
         //   connection.Open();
         //   int count = command.ExecuteNonQuery();

         //   Console.WriteLine( "{0} row(s) were affected",
         //      count
         //   );
         //}

         #endregion

         #region ExecuteScalar()

         //using ( SqlConnection connection = new SqlConnection(
         //   ConfigurationManager.ConnectionStrings[ "SqlServer2012" ].ConnectionString ) )
         //{
         //   SqlCommand command = connection.CreateCommand();
         //   command.CommandType = CommandType.Text;
         //   command.CommandText = "SELECT COUNT(*) FROM People";
         //   connection.Open();
         //   object count = command.ExecuteScalar();

         //   Console.WriteLine( "There are {0} people in table",
         //      count
         //   );
         //}

         #endregion
         
         #region ExecuteReader()

         //using ( SqlConnection connection = new SqlConnection(
         //   ConfigurationManager.ConnectionStrings[ "SqlServer2012" ].ConnectionString ) )
         //{
         //   connection.Open();
         //   SqlCommand command = new SqlCommand( "SELECT * FROM People WHERE id IS NOT NULL", connection );

         //   using ( SqlDataReader reader = command.ExecuteReader() )
         //   {
         //      while ( reader.Read() )
         //      {
         //         Console.WriteLine(
         //            string.Format( "{0}: {1} {2} born {3}",
         //               reader[ "id" ],
         //               reader[ "FirstName" ],
         //               reader[ "LastName" ],
         //               reader[ "BirthDate"]
         //            ) 
         //         );
         //      }
         //   }
         //}

         #endregion

         #region ExecuteReader() with multiple results

         //using ( SqlConnection connection = new SqlConnection(
         //   ConfigurationManager.ConnectionStrings[ "SqlServer2012" ].ConnectionString ) )
         //{
         //   connection.Open();
         //   SqlCommand command = new SqlCommand( "SELECT * FROM People WHERE id IS NOT NULL; SELECT * from People WHERE LastName = 'Gulmann'", connection );

         //   using ( SqlDataReader reader = command.ExecuteReader() )
         //   {
         //      do
         //      {
         //         while ( reader.Read() )
         //         {
         //            Console.WriteLine(
         //               string.Format( "{0}: {1} {2} born {3}",
         //                  reader[ "id" ],
         //                  reader[ "FirstName" ],
         //                  reader[ "LastName" ],
         //                  reader[ "BirthDate" ]
         //               )
         //            );
         //         }

         //         Console.WriteLine( "-------" );
         //      }
         //      while ( reader.NextResult() );
         //   }
         //}

         #endregion
      }
   }
}
