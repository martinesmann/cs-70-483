using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace ReflectionFun
{
   class Program
   {
      static void Main( string[] args )
      {
         #region Defining the CodeCOM Model

         CodeCompileUnit unit = new CodeCompileUnit();
         CodeNamespace ns = new CodeNamespace( "Wincubate.Lab11.Code" );
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

         #region Generating the assembly

         string assemblyFile = @"C:\Tmp\HelloWorld.exe";

         CSharpCodeProvider codeProvider = new CSharpCodeProvider();
         CompilerParameters parameters = new CompilerParameters()
         {
            GenerateExecutable = true,
            OutputAssembly = assemblyFile
         };
         parameters.ReferencedAssemblies.Add( "System.dll" );

         CompilerResults results = codeProvider.CompileAssemblyFromDom( parameters, unit );

         bool ok = true;
         foreach ( CompilerError error in results.Errors )
         {
            Console.WriteLine( error.ToString() );
            ok = false;
         }

         #endregion

         if ( ok )
         {
            Console.WriteLine( "Compilation succeeded :-). Now running assembly...:" + Environment.NewLine );

            #region Use reflection to run program

            Assembly asm = Assembly.LoadFrom( assemblyFile );
            MethodInfo method = asm.EntryPoint;
            method.Invoke( null, new object[ 0 ] );

            #endregion
         }
      }
   }
}
