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
    '''The CloseAUT recording.
    ''' </summary>
    <TestModule("e1558c17-c348-4dd3-a444-53982418bbe6", ModuleType.Recording, 1)> _
    Partial Public Class CloseAUT
        Implements ITestModule
    
        ''' <summary>
        ''' Holds an instance of the Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        ''' </summary>
        Public Shared repo as Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository = Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository.Instance
    
        Shared _instance as CloseAUT = new CloseAUT()
    
        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Sub New()
            CloseAutProcessIDVar = "-1"
        End Sub
    
        ''' <summary>
        ''' Gets a static instance of this recording.
        ''' </summary>
        Public Shared ReadOnly Property Instance As CloseAUT
            Get
                Return _instance
            End Get
        End Property

#Region "Variables"
    
        Dim _CloseAutProcessIDVar As String
    
        ''' <summary>
        ''' Gets or sets the value of variable CloseAutProcessIDVar.
        ''' </summary>
        <TestVariable("e7daa91d-d177-4a08-b3b9-13dc53b05be9")> _
        Public Property CloseAutProcessIDVar As String
            Get
                Return _CloseAutProcessIDVar
            End Get
            Set(ByVal value As String)
                _CloseAutProcessIDVar = value
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
    
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'FrmLogin'.", repo.FrmLogin.SelfInfo, new RecordItemIndex(0))
            Host.Current.CloseApplication(repo.FrmLogin.Self, 500)
            Delay.Milliseconds(0)
            
        End Sub

#Region "Image Feature Data"
#End Region

    End Class

End Namespace
