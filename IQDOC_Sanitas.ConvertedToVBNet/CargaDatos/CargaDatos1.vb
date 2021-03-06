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
    '''The CargaDatos1 recording.
    ''' </summary>
    <TestModule("bfcefec9-b881-4f15-a319-ba9007457abe", ModuleType.Recording, 1)> _
    Partial Public Class CargaDatos1
        Implements ITestModule
    
        ''' <summary>
        ''' Holds an instance of the Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        ''' </summary>
        Public Shared repo as Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository = Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository.Instance
    
        Shared _instance as CargaDatos1 = new CargaDatos1()
    
        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Sub New()
            NitIPS = "800087565"
            Nfactura = "2FE6282"
        End Sub
    
        ''' <summary>
        ''' Gets a static instance of this recording.
        ''' </summary>
        Public Shared ReadOnly Property Instance As CargaDatos1
            Get
                Return _instance
            End Get
        End Property

#Region "Variables"
    
        ''' <summary>
        ''' Gets or sets the value of variable NitIPS.
        ''' </summary>
        <TestVariable("58f1a64b-be2e-4570-9ce4-96f2927257d5")> _
        Public Property NitIPS As String
            Get
                Return repo.NitIPS
            End Get
            Set(ByVal value As String)
                repo.NitIPS = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable Nfactura.
        ''' </summary>
        <TestVariable("fe31151f-2d2e-4895-86e5-8b26b40432eb")> _
        Public Property Nfactura As String
            Get
                Return repo.Nfactura
            End Get
            Set(ByVal value As String)
                repo.Nfactura = value
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
    
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NitIPS' with focus on 'MDIPrincipal.TabMain.TXTNITIPS'.", repo.MDIPrincipal.TabMain.TXTNITIPSInfo, new RecordItemIndex(0))
            repo.MDIPrincipal.TabMain.TXTNITIPS.PressKeys(NitIPS)
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nfactura' with focus on 'MDIPrincipal.TabMain.NumeroFactura'.", repo.MDIPrincipal.TabMain.NumeroFacturaInfo, new RecordItemIndex(1))
            repo.MDIPrincipal.TabMain.NumeroFactura.PressKeys(Nfactura)
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TXTSUCURSAL' at 19;5.", repo.TXTSUCURSALInfo, new RecordItemIndex(2))
            repo.TXTSUCURSAL.Click("19;5")
            Delay.Milliseconds(0)
            
        End Sub

#Region "Image Feature Data"
#End Region

    End Class

End Namespace
