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
    '''The ValidacionFolder recording.
    ''' </summary>
    <TestModule("1de422d3-6c34-4bb9-86fb-80de3ace7aa3", ModuleType.Recording, 1)> _
    Partial Public Class ValidacionFolder
        Implements ITestModule
    
        ''' <summary>
        ''' Holds an instance of the Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        ''' </summary>
        Public Shared repo as Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository = Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository.Instance
    
        Shared _instance as ValidacionFolder = new ValidacionFolder()
    
        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Sub New()
            SolicitudID = "DCC8CE34-0E86-4BB4-BCB5-B84F4679941C"
            NitIPS = ""
            Nfactura = ""
            FechaFactura = ""
            Periodo = ""
            TipHonorario = ""
            Producto = ""
            Plan = ""
            ValBruto = ""
        End Sub
    
        ''' <summary>
        ''' Gets a static instance of this recording.
        ''' </summary>
        Public Shared ReadOnly Property Instance As ValidacionFolder
            Get
                Return _instance
            End Get
        End Property

#Region "Variables"
    
        Dim _SolicitudID As String
    
        ''' <summary>
        ''' Gets or sets the value of variable SolicitudID.
        ''' </summary>
        <TestVariable("478bfbc6-408f-470a-a323-609874a6d8f0")> _
        Public Property SolicitudID As String
            Get
                Return _SolicitudID
            End Get
            Set(ByVal value As String)
                _SolicitudID = value
            End Set
        End Property
    
        Dim _FechaFactura As String
    
        ''' <summary>
        ''' Gets or sets the value of variable FechaFactura.
        ''' </summary>
        <TestVariable("30ff0f56-640d-4404-83d8-7e40964d179a")> _
        Public Property FechaFactura As String
            Get
                Return _FechaFactura
            End Get
            Set(ByVal value As String)
                _FechaFactura = value
            End Set
        End Property
    
        Dim _Periodo As String
    
        ''' <summary>
        ''' Gets or sets the value of variable Periodo.
        ''' </summary>
        <TestVariable("77110777-b1c5-4678-98ee-d141f8c304ff")> _
        Public Property Periodo As String
            Get
                Return _Periodo
            End Get
            Set(ByVal value As String)
                _Periodo = value
            End Set
        End Property
    
        Dim _TipHonorario As String
    
        ''' <summary>
        ''' Gets or sets the value of variable TipHonorario.
        ''' </summary>
        <TestVariable("5b5b5b45-de4a-4983-bf46-5f4d2c10d871")> _
        Public Property TipHonorario As String
            Get
                Return _TipHonorario
            End Get
            Set(ByVal value As String)
                _TipHonorario = value
            End Set
        End Property
    
        Dim _ValBruto As String
    
        ''' <summary>
        ''' Gets or sets the value of variable ValBruto.
        ''' </summary>
        <TestVariable("59eede5d-6fda-451a-9cc7-01c79a040477")> _
        Public Property ValBruto As String
            Get
                Return _ValBruto
            End Get
            Set(ByVal value As String)
                _ValBruto = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable CodCausal.
        ''' </summary>
        <TestVariable("76573065-3087-4296-9bf6-8692000dcf32")> _
        Public Property CodCausal As String
            Get
                Return repo.CodCausal
            End Get
            Set(ByVal value As String)
                repo.CodCausal = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable NitIPS.
        ''' </summary>
        <TestVariable("0b89e05f-a20b-4c31-9389-ce5ed05e7195")> _
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
        <TestVariable("3d5a2773-8f34-4b7e-9f25-92a4b0c7a1db")> _
        Public Property Nfactura As String
            Get
                Return repo.Nfactura
            End Get
            Set(ByVal value As String)
                repo.Nfactura = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable Producto.
        ''' </summary>
        <TestVariable("bf45e292-c442-4798-af56-d4730aee2f2a")> _
        Public Property Producto As String
            Get
                Return repo.Producto
            End Get
            Set(ByVal value As String)
                repo.Producto = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable Plan.
        ''' </summary>
        <TestVariable("8a359ef7-2afa-484c-bbb2-9e74de34fd09")> _
        Public Property Plan As String
            Get
                Return repo.Plan
            End Get
            Set(ByVal value As String)
                repo.Plan = value
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
    
            CargaDatos()
            Delay.Milliseconds(0)
            
        End Sub

#Region "Image Feature Data"
#End Region

    End Class

End Namespace
