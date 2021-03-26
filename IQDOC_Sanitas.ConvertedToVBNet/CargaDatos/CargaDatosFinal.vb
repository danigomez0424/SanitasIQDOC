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

Namespace IQDOC_Sanitas.CargaDatos
    ''' <summary>
    '''The CargaDatosFinal recording.
    ''' </summary>
    <TestModule("1082ab58-4f54-48fc-b87c-c199e87779ab", ModuleType.Recording, 1)> _
    Partial Public Class CargaDatosFinal
        Implements ITestModule
    
        ''' <summary>
        ''' Holds an instance of the Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        ''' </summary>
        Public Shared repo as Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository = Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository.Instance
    
        Shared _instance as CargaDatosFinal = new CargaDatosFinal()
    
        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Sub New()
        End Sub
    
        ''' <summary>
        ''' Gets a static instance of this recording.
        ''' </summary>
        Public Shared ReadOnly Property Instance As CargaDatosFinal
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
    
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.CmdSave' at 49;5.", repo.MDIPrincipal.CmdSaveInfo, new RecordItemIndex(0))
            repo.MDIPrincipal.CmdSave.Click("49;5")
            Delay.Milliseconds(0)
            
        End Sub

#Region "Image Feature Data"
#End Region

    End Class

End Namespace
