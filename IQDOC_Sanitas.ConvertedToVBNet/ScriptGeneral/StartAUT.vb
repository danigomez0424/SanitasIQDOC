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
    '''The StartAUT recording.
    ''' </summary>
    <TestModule("3232176a-0082-4e37-8bf1-1a1522285d1b", ModuleType.Recording, 1)> _
    Partial Public Class StartAUT
        Implements ITestModule
    
        ''' <summary>
        ''' Holds an instance of the Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        ''' </summary>
        Public Shared repo as Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository = Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository.Instance
    
        Shared _instance as StartAUT = new StartAUT()
    
        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Sub New()
            StartAutProcessIDVar = ""
        End Sub
    
        ''' <summary>
        ''' Gets a static instance of this recording.
        ''' </summary>
        Public Shared ReadOnly Property Instance As StartAUT
            Get
                Return _instance
            End Get
        End Property

#Region "Variables"
    
        Dim _StartAutProcessIDVar As String
    
        ''' <summary>
        ''' Gets or sets the value of variable StartAutProcessIDVar.
        ''' </summary>
        <TestVariable("734dc1c9-e2a9-44bd-95d5-081b813e29ff")> _
        Public Property StartAutProcessIDVar As String
            Get
                Return _StartAutProcessIDVar
            End Get
            Set(ByVal value As String)
                _StartAutProcessIDVar = value
            End Set
        End Property

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
    
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\Compartido\IQDOC\IQDOC.exe' in normal mode.", new RecordItemIndex(0))
            Host.Local.RunApplication("C:\Compartido\IQDOC\IQDOC.exe", "", "C:\Compartido\IQDOC", False)
            Delay.Milliseconds(0)
            
        End Sub

#Region "Image Feature Data"
#End Region

    End Class

End Namespace
