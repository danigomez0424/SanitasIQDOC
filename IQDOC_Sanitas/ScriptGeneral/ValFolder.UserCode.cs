﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace IQDOC_Sanitas.ScriptGeneral
{
	public partial class ValFolder
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void ValidacionCargaDatos()
		{
			
			//	TestSuite.CurrentTestContainer.Parameters.TryGetValue("ParFolderId", out folderid);
			
			string folderid=ParFolderId,TiProducto=CBOProducto;
			
			if (SolicitudID==folderid){
				
				
				if (NFacturaOriginal==Nfactura) {
					
					
					#region CargaDatos1
					Mouse.DefaultMoveTime = 300;
					Keyboard.DefaultKeyPressTime = 20;
					Delay.SpeedFactor = 1.00;

					Init();

					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NitIPS' with focus on 'MDIPrincipal.TabMain.TXTNITIPS'.", repo.MDIPrincipal.TabMain.TXTNITIPSInfo, new RecordItemIndex(0));
					repo.MDIPrincipal.TabMain.TXTNITIPS.PressKeys(NitIPS);
					Delay.Milliseconds(0);
					
					
					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Prefijo' with focus on 'MDIPrincipal.TabMain.Prefijo'.", repo.MDIPrincipal.TabMain.PrefijoInfo, new RecordItemIndex(1));
					repo.MDIPrincipal.TabMain.Prefijo.PressKeys(Prefijo);
					Delay.Milliseconds(0);
					
					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nfactura' with focus on 'MDIPrincipal.TabMain.NumeroFactura'.", repo.MDIPrincipal.TabMain.NumeroFacturaInfo, new RecordItemIndex(1));
					repo.MDIPrincipal.TabMain.NumeroFactura.PressKeys(Nfactura);
					Delay.Milliseconds(0);
					
					
					
//					 try {
					//                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'InformacionRIPS_cof.Aceptar' at Center.", repo.InformacionRIPS_cof.AceptarInfo, new RecordItemIndex(3));
					//                repo.InformacionRIPS_cof.Aceptar.Click();
					//                Delay.Milliseconds(0);
					//            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
//
					
					Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TXTSUCURSAL' at 19;5.", repo.TXTSUCURSALInfo, new RecordItemIndex(2));
					repo.TXTSUCURSAL.Click("19;5");
					Delay.Milliseconds(0);
					
					#endregion
					
					#region CargaDatos2

					try {
						Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'InformacionRIPS_cof.Aceptar' at Center.", repo.InformacionRIPS_cof.AceptarInfo, new RecordItemIndex(0));
						repo.InformacionRIPS_cof.Aceptar.Click();
						Delay.Milliseconds(0);
					} catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
					
					//Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'List1000.CR254946CONS307CENTROMEDICOSANT'.", repo.List1000.CR254946CONS307CENTROMEDICOSANTInfo, new RecordItemIndex(1));
					//repo.List1000.CR254946CONS307CENTROMEDICOSANT.Select();
					//Delay.Milliseconds(0);
					
					//Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'MDIPrincipal.TabMain.CerrarSucursalDDL'.", repo.MDIPrincipal.TabMain.CerrarSucursalDDLInfo, new RecordItemIndex(2));
					//repo.MDIPrincipal.TabMain.CerrarSucursalDDL.Press();
					//Delay.Milliseconds(0);
					
					Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MDIPrincipal.TabMain.FechaFactura' at Center.", repo.MDIPrincipal.TabMain.FechaFacturaInfo, new RecordItemIndex(3));
					repo.MDIPrincipal.TabMain.FechaFactura.DoubleClick();
					Delay.Milliseconds(0);
					
					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FechaFactura' with focus on 'MDIPrincipal.TabMain.FechaFactura'.", repo.MDIPrincipal.TabMain.FechaFacturaInfo, new RecordItemIndex(4));
					repo.MDIPrincipal.TabMain.FechaFactura.PressKeys(FechaFactura);
					Delay.Milliseconds(0);
					
					Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MDIPrincipal.TabMain.TextArea2' at Center.", repo.MDIPrincipal.TabMain.TextArea2Info, new RecordItemIndex(5));
					repo.MDIPrincipal.TabMain.TextArea2.DoubleClick();
					Delay.Milliseconds(0);
					
					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Periodo' with focus on 'MDIPrincipal.TabMain.TextArea2'.", repo.MDIPrincipal.TabMain.TextArea2Info, new RecordItemIndex(6));
					repo.MDIPrincipal.TabMain.TextArea2.EnsureVisible();
					Keyboard.Press(Periodo);
					Delay.Milliseconds(0);
					
					if(TiProducto=="Cuentas Medicas Recobrables")
					{
						Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'yourtext' with focus on 'MDIPrincipal.TabMain.Text1001'.", repo.MDIPrincipal.TabMain.Text1001Info, new RecordItemIndex(1));
						repo.MDIPrincipal.TabMain.Text1001.PressKeys(TipoNoPbs);
						Delay.Milliseconds(0);
					}
					
					
					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipHonorario' with focus on 'MDIPrincipal.TabMain.TipoHonorarioText'.", repo.MDIPrincipal.TabMain.TipoHonorarioTextInfo, new RecordItemIndex(7));
					repo.MDIPrincipal.TabMain.TipoHonorarioText.PressKeys(TipHonorario);
					Delay.Milliseconds(0);
					
					#endregion
					
					#region CargaDatos3
					
					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'MDIPrincipal.TabMain.Producto'.", repo.MDIPrincipal.TabMain.ProductoInfo, new RecordItemIndex(0));
					repo.MDIPrincipal.TabMain.Producto.PressKeys(Producto);
					Delay.Milliseconds(0);
					
					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Plan' with focus on 'MDIPrincipal.TabMain.Plan'.", repo.MDIPrincipal.TabMain.PlanInfo, new RecordItemIndex(1));
					repo.MDIPrincipal.TabMain.Plan.PressKeys(Plan);
					Delay.Milliseconds(0);
					#endregion
					
					#region CargaDatos4
					Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MDIPrincipal.TabMain.ValorBruto' at Center.", repo.MDIPrincipal.TabMain.ValorBrutoInfo, new RecordItemIndex(0));
					repo.MDIPrincipal.TabMain.ValorBruto.DoubleClick();
					Delay.Milliseconds(0);
					
					Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ValBruto' with focus on 'MDIPrincipal.TabMain.ValorBruto'.", repo.MDIPrincipal.TabMain.ValorBrutoInfo, new RecordItemIndex(1));
					repo.MDIPrincipal.TabMain.ValorBruto.PressKeys(ValBruto);
					Delay.Milliseconds(0);
					
					#endregion
					
					#region Guardar
					try {
						Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'InformacionRIPS_cof.Aceptar' at Center.", repo.InformacionRIPS_cof.AceptarInfo, new RecordItemIndex(0));
						repo.InformacionRIPS_cof.Aceptar.Click();
						Delay.Milliseconds(0);
					} catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
					
					Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.CmdSave' at 49;5.", repo.MDIPrincipal.CmdSaveInfo, new RecordItemIndex(1));
					repo.MDIPrincipal.CmdSave.Click("49;5");
					Delay.Milliseconds(0);
					
					
					#endregion
					
					#region Screenshot
					Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(2));
					#endregion
				}
			}
			else{
				Report.Log(ReportLevel.Info,"Factura Omitida :"+SolicitudID);
			}
		}

		
	}
}
