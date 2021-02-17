﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace IQDOC_Sanitas.CargaDatos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CapturaDatosRIPS recording.
    /// </summary>
    [TestModule("850ea7ed-60bf-46d4-904c-12c11675d774", ModuleType.Recording, 1)]
    public partial class CapturaDatosRIPS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        /// </summary>
        public static global::IQDOC_Sanitas.IQDOC_SanitasRepository repo = global::IQDOC_Sanitas.IQDOC_SanitasRepository.Instance;

        static CapturaDatosRIPS instance = new CapturaDatosRIPS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CapturaDatosRIPS()
        {
            Nit = "800087565";
            Factura = "2FE6282";
            Plan = "Plan Contributivo";
            Producto = "POS";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CapturaDatosRIPS Instance
        {
            get { return instance; }
        }

#region Variables

        string _Nit;

        /// <summary>
        /// Gets or sets the value of variable Nit.
        /// </summary>
        [TestVariable("d6f5c8e4-610a-4d22-a6b4-e7037e7a8f33")]
        public string Nit
        {
            get { return _Nit; }
            set { _Nit = value; }
        }

        string _Factura;

        /// <summary>
        /// Gets or sets the value of variable Factura.
        /// </summary>
        [TestVariable("223adbff-81d6-4f60-af95-bfdd4ebb6b90")]
        public string Factura
        {
            get { return _Factura; }
            set { _Factura = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Plan.
        /// </summary>
        [TestVariable("a83760ed-2563-4961-bfd5-73a19392375c")]
        public string Plan
        {
            get { return repo.Plan; }
            set { repo.Plan = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Producto.
        /// </summary>
        [TestVariable("c7fdc079-df7f-4b42-ae31-341aa7952bf2")]
        public string Producto
        {
            get { return repo.Producto; }
            set { repo.Producto = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.TXTNITIPS' at 18;6.", repo.MDIPrincipal.TabMain.TXTNITIPSInfo, new RecordItemIndex(0));
            //repo.MDIPrincipal.TabMain.TXTNITIPS.Click("18;6");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nit' with focus on 'MDIPrincipal.TabMain.TXTNITIPS'.", repo.MDIPrincipal.TabMain.TXTNITIPSInfo, new RecordItemIndex(1));
            repo.MDIPrincipal.TabMain.TXTNITIPS.PressKeys(Nit);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.NumeroFactura' at 8;13.", repo.MDIPrincipal.TabMain.NumeroFacturaInfo, new RecordItemIndex(2));
            //repo.MDIPrincipal.TabMain.NumeroFactura.Click("8;13");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Factura' with focus on 'MDIPrincipal.TabMain.NumeroFactura'.", repo.MDIPrincipal.TabMain.NumeroFacturaInfo, new RecordItemIndex(3));
            repo.MDIPrincipal.TabMain.NumeroFactura.PressKeys(Factura);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TXTSUCURSAL' at 19;5.", repo.TXTSUCURSALInfo, new RecordItemIndex(4));
            repo.TXTSUCURSAL.Click("19;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'MDIPrincipal.TabMain.Producto'.", repo.MDIPrincipal.TabMain.ProductoInfo, new RecordItemIndex(5));
            repo.MDIPrincipal.TabMain.Producto.PressKeys(Producto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Plan' with focus on 'MDIPrincipal.TabMain.Plan'.", repo.MDIPrincipal.TabMain.PlanInfo, new RecordItemIndex(6));
            repo.MDIPrincipal.TabMain.Plan.PressKeys(Plan);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.TextArea1' at 281;-55.", repo.MDIPrincipal.TabMain.TextArea1Info, new RecordItemIndex(7));
            //repo.MDIPrincipal.TabMain.TextArea1.Click("281;-55");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.Cerrar1' at -161;24.", repo.MDIPrincipal.TabMain.Cerrar1Info, new RecordItemIndex(8));
            //repo.MDIPrincipal.TabMain.Cerrar1.Click("-161;24");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.Abrir2' at 9;5.", repo.MDIPrincipal.TabMain.Abrir2Info, new RecordItemIndex(9));
            //repo.MDIPrincipal.TabMain.Abrir2.Click("9;5");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.TabMain.Cerrar2' at -125;25.", repo.MDIPrincipal.TabMain.Cerrar2Info, new RecordItemIndex(10));
            //repo.MDIPrincipal.TabMain.Cerrar2.Click("-125;25");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.CmdSave' at 49;5.", repo.MDIPrincipal.CmdSaveInfo, new RecordItemIndex(11));
            repo.MDIPrincipal.CmdSave.Click("49;5");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
