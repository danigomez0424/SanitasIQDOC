Imports System
Imports System.CodeDom.Compiler
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports Ranorex
Imports Ranorex.Core.Resolver

Namespace __RxMain
    ''' <summary>
    ''' Modified Program class that ensures that the Ranorex System gets initialized And cleaned up
    ''' correctly. This file Is auto-generated during project build. This class will invoke the
    ''' original 'Main' method implementation as needed.
    ''' </summary>
    <GeneratedCode("Ranorex", "9.3")>
    Module __RxProgram

        ''' <summary>
        ''' The entry point of the application.
        ''' <returns>The return value of the projects original 'Main' implementation.</returns>
        ''' </summary>
        <STAThread()>
        Function Main() As Integer
            Try
                AssemblyLoader.Initialize()

                RanorexInit()

                Return MainInvoker.Invoke(Assembly.GetExecutingAssembly(), "", Nothing)
            Catch exc As Exception
                Console.WriteLine(exc.ToString())
                Return PrerequisiteChecker.HandleTestExecutableMainException(exc)
            End Try
        End Function

        <MethodImpl(MethodImplOptions.NoInlining)>
        Private Sub RanorexInit()
            TestingBootstrapper.SetupCore()
        End Sub
    End Module
End Namespace
