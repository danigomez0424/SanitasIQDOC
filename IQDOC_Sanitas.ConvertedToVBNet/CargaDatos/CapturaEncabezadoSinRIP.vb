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
    '''The CapturaEncabezadoSinRIP recording.
    ''' </summary>
    <TestModule("981b09da-5476-4da7-9032-d8331b58e3a3", ModuleType.Recording, 1)> _
    Partial Public Class CapturaEncabezado
        Implements ITestModule
    
        ''' <summary>
        ''' Holds an instance of the Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        ''' </summary>
        Public Shared repo as Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository = Global.IQDOC_Sanitas.IQDOC_Sanitas.IQDOC_SanitasRepository.Instance
    
        Shared _instance as CapturaEncabezado = new CapturaEncabezado()
    
        ''' <summary>
        ''' Constructs a new instance.
        ''' </summary>
        Sub New()
            Periodo = "11232020"
            TipHonorario = "AB -- AMBULANCIA"
            Producto = "PAC"
            Plan = "Plan Empresarial"
            ValBruto = "10000"
            NFactura = "12345"
            NitIPS = "842000144 - ESE UBA NUESTRA SEÑORA DEL CARMEN"
            Sucursal = "AV ORINOCO CALLE 10   CUMARIBO"
        End Sub
    
        ''' <summary>
        ''' Gets a static instance of this recording.
        ''' </summary>
        Public Shared ReadOnly Property Instance As CapturaEncabezado
            Get
                Return _instance
            End Get
        End Property

#Region "Variables"
    
        Dim _Periodo As String
    
        ''' <summary>
        ''' Gets or sets the value of variable Periodo.
        ''' </summary>
        <TestVariable("ab3e21ac-d7b1-46a5-b4d0-edd465b1a899")> _
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
        <TestVariable("ca912791-c1fb-48d7-9986-c6dc866dfd04")> _
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
        <TestVariable("057dc542-147d-4bbf-9b54-38bf74f350a4")> _
        Public Property ValBruto As String
            Get
                Return _ValBruto
            End Get
            Set(ByVal value As String)
                _ValBruto = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable NitIPS.
        ''' </summary>
        <TestVariable("9c5bd106-8ee2-428e-bc23-310f5502aaca")> _
        Public Property NitIPS As String
            Get
                Return repo.NitIPS
            End Get
            Set(ByVal value As String)
                repo.NitIPS = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable Sucursal.
        ''' </summary>
        <TestVariable("f53dbe53-95a3-40e9-b9f5-2b741287451a")> _
        Public Property Sucursal As String
            Get
                Return repo.Sucursal
            End Get
            Set(ByVal value As String)
                repo.Sucursal = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable Producto.
        ''' </summary>
        <TestVariable("267a1050-4f2d-4ce5-a4d3-b9b9a7ef11a9")> _
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
        <TestVariable("df3d5c7a-418e-47a3-991e-5430f4b3928e")> _
        Public Property Plan As String
            Get
                Return repo.Plan
            End Get
            Set(ByVal value As String)
                repo.Plan = value
            End Set
        End Property
    
        ''' <summary>
        ''' Gets or sets the value of variable NFactura.
        ''' </summary>
        <TestVariable("30b23cfd-0f88-437b-afb0-8ff85e33ffcf")> _
        Public Property NFactura As String
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
    
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.CmdStart' at 95;10.", repo.MDIPrincipal.CmdStartInfo, new RecordItemIndex(0))
            repo.MDIPrincipal.CmdStart.Click("95;10")
            Delay.Milliseconds(0)
            
            Try
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)"+Chr(13)+""+Chr(10)+"Mouse Left Click item 'FrmPOPUp_cof.Btn_CerrarVentana' at Center.", repo.FrmPOPUp_cof.Btn_CerrarVentanaInfo, new RecordItemIndex(1))
                repo.FrmPOPUp_cof.Btn_CerrarVentana.Click()
                Delay.Milliseconds(0)
            Catch ex As Exception
                Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " & ex.Message, New RecordItemIndex(1))
            End Try
    
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NitIPS' with focus on 'MDIPrincipal.TabMain.TXTNITIPS'.", repo.MDIPrincipal.TabMain.TXTNITIPSInfo, new RecordItemIndex(2))
            repo.MDIPrincipal.TabMain.TXTNITIPS.PressKeys(NitIPS)
            Delay.Milliseconds(0)
            
            'Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.DDLNITIPS' at 11;10.", repo.MDIPrincipal.TabMain.DDLNITIPSInfo, new RecordItemIndex(3))
            'repo.MDIPrincipal.TabMain.DDLNITIPS.Click("11;10")
            'Delay.Milliseconds(0)
            
            'Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItem10263507ARBOLEDANARANJOLUIS' at 160;4.", repo.List1000.ListItem10263507ARBOLEDANARANJOLUISInfo, new RecordItemIndex(4))
            'repo.List1000.ListItem10263507ARBOLEDANARANJOLUIS.Click("160;4")
            'Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MDIPrincipal.TabMain.TXTNUMEROFACTURA' at Center.", repo.MDIPrincipal.TabMain.TXTNUMEROFACTURAInfo, new RecordItemIndex(5))
            repo.MDIPrincipal.TabMain.TXTNUMEROFACTURA.DoubleClick()
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NFactura' with focus on 'MDIPrincipal.TabMain.TXTNUMEROFACTURA'.", repo.MDIPrincipal.TabMain.TXTNUMEROFACTURAInfo, new RecordItemIndex(6))
            repo.MDIPrincipal.TabMain.TXTNUMEROFACTURA.PressKeys(NFactura)
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.AbrirSucursalDDL' at 6;8.", repo.MDIPrincipal.TabMain.AbrirSucursalDDLInfo, new RecordItemIndex(7))
            repo.MDIPrincipal.TabMain.AbrirSucursalDDL.Click("6;8")
            Delay.Milliseconds(0)
            
            Try
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)"+Chr(13)+""+Chr(10)+"Mouse Left Click item 'InformacionRIPS_cof.Aceptar' at Center.", repo.InformacionRIPS_cof.AceptarInfo, new RecordItemIndex(8))
                repo.InformacionRIPS_cof.Aceptar.Click()
                Delay.Milliseconds(0)
            Catch ex As Exception
                Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " & ex.Message, New RecordItemIndex(8))
            End Try
    
            'Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.AbrirSucursalDDL' at 6;8.", repo.MDIPrincipal.TabMain.AbrirSucursalDDLInfo, new RecordItemIndex(9))
            'repo.MDIPrincipal.TabMain.AbrirSucursalDDL.Click("6;8")
            'Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'List1000.CR254946CONS307CENTROMEDICOSANT'.", repo.List1000.CR254946CONS307CENTROMEDICOSANTInfo, new RecordItemIndex(10))
            repo.List1000.CR254946CONS307CENTROMEDICOSANT.Select()
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'MDIPrincipal.TabMain.CerrarSucursalDDL'.", repo.MDIPrincipal.TabMain.CerrarSucursalDDLInfo, new RecordItemIndex(11))
            repo.MDIPrincipal.TabMain.CerrarSucursalDDL.Press()
            Delay.Milliseconds(0)
            
            'Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.CR254946CONS307CENTROMEDICOSANT' at Center.", repo.List1000.CR254946CONS307CENTROMEDICOSANTInfo, new RecordItemIndex(12))
            'repo.List1000.CR254946CONS307CENTROMEDICOSANT.Click()
            'Delay.Milliseconds(0)
            
            'Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Sucursal' with focus on 'TXTSUCURSAL'.", repo.TXTSUCURSALInfo, new RecordItemIndex(13))
            'repo.TXTSUCURSAL.PressKeys(Sucursal)
            'Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MDIPrincipal.TabMain.Periodo' at Center.", repo.MDIPrincipal.TabMain.PeriodoInfo, new RecordItemIndex(14))
            repo.MDIPrincipal.TabMain.Periodo.DoubleClick()
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Periodo'.", new RecordItemIndex(15))
            Keyboard.Press(Periodo)
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipHonorario' with focus on 'MDIPrincipal.TabMain.TipoHonorarioText'.", repo.MDIPrincipal.TabMain.TipoHonorarioTextInfo, new RecordItemIndex(16))
            repo.MDIPrincipal.TabMain.TipoHonorarioText.PressKeys(TipHonorario)
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'MDIPrincipal.TabMain.Producto'.", repo.MDIPrincipal.TabMain.ProductoInfo, new RecordItemIndex(17))
            repo.MDIPrincipal.TabMain.Producto.PressKeys(Producto)
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Plan' with focus on 'MDIPrincipal.TabMain.Plan'.", repo.MDIPrincipal.TabMain.PlanInfo, new RecordItemIndex(18))
            repo.MDIPrincipal.TabMain.Plan.PressKeys(Plan)
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MDIPrincipal.TabMain.ValorBruto' at Center.", repo.MDIPrincipal.TabMain.ValorBrutoInfo, new RecordItemIndex(19))
            repo.MDIPrincipal.TabMain.ValorBruto.DoubleClick()
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ValBruto' with focus on 'MDIPrincipal.TabMain.ValorBruto'.", repo.MDIPrincipal.TabMain.ValorBrutoInfo, new RecordItemIndex(20))
            repo.MDIPrincipal.TabMain.ValorBruto.PressKeys(ValBruto)
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.CmdSave' at Center.", repo.MDIPrincipal.CmdSaveInfo, new RecordItemIndex(21))
            repo.MDIPrincipal.CmdSave.Click()
            Delay.Milliseconds(0)
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to not exist. Associated repository item: 'ControlDeValidacionDeCampos'", repo.ControlDeValidacionDeCampos.SelfInfo, new ActionTimeout(5000), new RecordItemIndex(22))
            repo.ControlDeValidacionDeCampos.SelfInfo.WaitForNotExists(5000)
            
        End Sub

#Region "Image Feature Data"
#End Region

    End Class

End Namespace
