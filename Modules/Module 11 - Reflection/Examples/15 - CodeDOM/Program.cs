using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CSharp;

namespace Wincubate.Module11.Slide15
{
   class Program
   {
      static void Main( string[] args )
      {
         #region Defining the CodeCOM Model
         
         CodeCompileUnit unit = new CodeCompileUnit();
         CodeNamespace ns = new CodeNamespace( "Wincubate.Module11.Slide15.Code" );
         ns.Imports.Add( new CodeNamespaceImport( "System" ) );
         unit.Namespaces.Add( ns );

         CodeTypeDeclaration type = new CodeTypeDeclaration( "Program" );
         CodeEntryPointMethod main = new CodeEntryPointMethod();
         main.Statements.Add(
            new CodeMethodInvokeExpression(
               new CodeTypeReferenceExpression( "Console" ),
               "WriteLine", 
               new CodePrimitiveExpression( "Hello World!" )
            )
         );         
         type.Members.Add( main );         
         
         ns.Types.Add( type );
         
         #endregion

         #region Generate source code from the CodeDOM Model

         CSharpCodeProvider code = new CSharpCodeProvider();

         using ( StreamWriter writer = new StreamWriter( @"C:\Tmp\Program.cs" ) )
         {
            using ( IndentedTextWriter itw = new IndentedTextWriter( writer ) )
            {
               CodeGeneratorOptions options = new CodeGeneratorOptions
               { 
                  BlankLinesBetweenMembers = true
               };
               code.GenerateCodeFromCompileUnit( unit, itw, options );
            }
         }

         #endregion

         #region Compiling the Source Code

         CompilerParameters parameters = new CompilerParameters()
         {
            GenerateExecutable = true,
            OutputAssembly = @"C:\Tmp\HelloWorld.exe"
         };
         parameters.ReferencedAssemblies.Add( "System.dll" );

         CompilerResults results = code.CompileAssemblyFromFile(
            parameters,
            @"C:\Tmp\Program.cs"
         );

         bool ok = true;
         foreach ( CompilerError error in results.Errors )
         {
            Console.WriteLine( error.ToString() );
            ok = false;
         }

         if ( ok )
         {
            Console.WriteLine( "Compilation succeeded :-)" );
         }

         #endregion
      }
   }
}
