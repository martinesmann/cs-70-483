using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module17.Question
{
   class Person
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
   }
   class Program
   {
      static void Main( string[] args )
      {
         List<Person> persons = new List<Person>();
         using ( SqlConnection connection = new SqlConnection( ConfigurationManager.ConnectionStrings[ "SqlServer2012" ].ConnectionString ) )
         {
            SqlCommand command = new SqlCommand( "SELECT FirstName, LastName FROM People", connection );
            connection.Open();
            using ( SqlDataReader reader = command.ExecuteReader() )
            {
               while ( reader.Read() )
               {
                  persons.Add( new Person
                  {
                     FirstName = reader[ "FirstName" ].ToString(),
                     LastName = reader[ "LastName" ].ToString()
                  } );
               }
            }
         }
      }
   }
}
