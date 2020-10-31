using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace OfficeInterop
{
    class Program
    {
        static void Main( string[] args )
        {
            // TODO 2
            List<Person> persons = new List<Person>
            {
                #region Names
                new Person ( "Gulmann", "Noah", "Kirk" ),
                new Person ( "Gulmann", "Frederikke", "Kirk" ),
                new Person ( "Gulmann", "Ane", "Kirk" ),
                new Person ( "Henriksen", "Jesper", "Gulmann" ),
                new Person ( "Henriksen", "Jørgen", "Gulmann" ),
                new Person ( "Henriksen", "Annie", "Holmer" ),
                new Person ( "Olsen", "Heidi", "Gulmann" ),
                new Person ( "Madsen", "Jesper" ),
                new Person ( "Olesen", "Lone", "Haudrum" ),
                new Person ( "Madsen", "Andreas", "Haudrum" ),
                new Person ( "Byskov", "Peter" ),
                new Person ( "Vestergaard", "Malene" ),
                new Person ( "Hansen", "Thomas", "Lund" ),
                new Person ( "Kristensen", "Thomas", "Govertz" ),
                new Person ( "Thrane", "Maria" ),
                new Person ( "Grønfeldt", "Mads", "Møller" ),
                new Person ( "Foged", "Kim", "Peter" ),
                new Person ( "Kristensen", "Kim", "Bjørndal" ),
                new Person ( "Kristensen", "Maria", "Bjørndal" )
                #endregion
            };

            // TODO 3: Activate Excel and create new workbook

            // TODO 4: Use active sheet and create column headings

            // TODO 5: Iterate through persons and transfer data into sheet

            // TODO 6: Set autoformatting

            // TODO 7: Save sheet and close Excel

            // TODO 8: Create success message
        }
    }
}
