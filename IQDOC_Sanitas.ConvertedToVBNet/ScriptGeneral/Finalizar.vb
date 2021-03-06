﻿'//////////////////////////////////////////////////////////////////////////////
'
' This file was automatically generated by RANOREX.
' DO NOT MODIFY THIS FILE! It is regenerated by the designer.
' All your modifications will be lost!
' http://www.ranorex.com
'
'//////////////////////////////////////////////////////////////////////////////

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Threading
Imports WinForms = System.Windows.Forms

Imports Ranorex
Imports Ranorex.Core
Imports Ranorex.Core.Testing
Imports Ranorex.Core.Repository

Namespace IQDOC_Sanitas.ScriptGeneral
    ''' <summary>
    '''The Finalizar recording.
    ''' </summary>
    <TestModule("6c2700a8-5b72-41b4-88dc-6791600aa0df", ModuleType.Recording, 1)> _
    Partial Public Class Finalizar
        Implements ITestModule
    
        ''' <summary>
        ''' Holds an instance of the Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        ''' </summary>
        Public Shared repo as Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository = Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository.Instance
    
        Shared _instance as Finalizar = new Finalizar()
    
        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Sub New()
        End Sub
    
        ''' <summary>
        ''' Gets a static instance of this recording.
        ''' </summary>
        Public Shared ReadOnly Property Instance As Finalizar
            Get
                Return _instance
            End Get
        End Property

#Region "Variables"

#End Region

        ''' <summary>
        ''' Starts the replay of the static recording <see cref="Instance"/>.
        ''' </summary>
            <System.CodeDom.Compiler.GeneratedCode("Ranorex", Global.Ranorex.Core.Constants.CodeGenVersion)> _
        Public Shared Sub Start()
            TestModuleRunner.Run(Instance)
        End Sub
    
        ''' <summary>
        ''' Performs the playback of actions in this recording.
        ''' </summary>
        ''' <remarks>You should not call this method directly, instead pass the module
        ''' instance to the <see cref="TestModuleRunner.Run"/> method
        ''' that will in turn invoke this method.</remarks>
        <System.CodeDom.Compiler.GeneratedCode("Ranorex", Global.Ranorex.Core.Constants.CodeGenVersion)> _
        Sub Run() Implements ITestModule.Run
            Mouse.DefaultMoveTime = 300
            Keyboard.DefaultKeyPressTime = 20
            Delay.SpeedFactor = 1.00
    
            Init()
    
            Try
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)"+Chr(13)+""+Chr(10)+"Mouse Left Click item 'Salir_Cof.Aceptar' at Center.", repo.Salir_Cof.AceptarInfo, new RecordItemIndex(0))
                repo.Salir_Cof.Aceptar.Click()
                Delay.Milliseconds(0)
            Catch ex As Exception
                Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " & ex.Message, New RecordItemIndex(0))
            End Try
    
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.CmdTerminar' at Center.", repo.MDIPrincipal.CmdTerminarInfo, new RecordItemIndex(1))
            repo.MDIPrincipal.CmdTerminar.Click()
            Delay.Milliseconds(0)
            
        End Sub

#Region "Image Feature Data"
#End Region

    End Class

End Namespace
