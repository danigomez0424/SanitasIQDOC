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
    ///The CargaDatos2 recording.
    /// </summary>
    [TestModule("efdb6eb4-334f-4ba0-8203-3ff7442ffb76", ModuleType.Recording, 1)]
    public partial class CargaDatos2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        /// </summary>
        public static global::IQDOC_Sanitas.IQDOC_SanitasRepository repo = global::IQDOC_Sanitas.IQDOC_SanitasRepository.Instance;

        static CargaDatos2 instance = new CargaDatos2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CargaDatos2()
        {
            Periodo = "11232020";
            TipHonorario = "AB -- AMBULANCIA";
            ValBruto = "10000";
            FechaFactura = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CargaDatos2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Periodo;

        /// <summary>
        /// Gets or sets the value of variable Periodo.
        /// </summary>
        [TestVariable("58f0b3fc-0aa6-4084-ac4d-8ab0bbee953c")]
        public string Periodo
        {
            get { return _Periodo; }
            set { _Periodo = value; }
        }

        string _TipHonorario;

        /// <summary>
        /// Gets or sets the value of variable TipHonorario.
        /// </summary>
        [TestVariable("c9faf717-5d29-4506-9df5-5364aaca970c")]
        public string TipHonorario
        {
            get { return _TipHonorario; }
            set { _TipHonorario = value; }
        }

        string _ValBruto;

        /// <summary>
        /// Gets or sets the value of variable ValBruto.
        /// </summary>
        [TestVariable("cead99af-3eab-475b-97e7-d07c7a21639e")]
        public string ValBruto
        {
            get { return _ValBruto; }
            set { _ValBruto = value; }
        }

        string _FechaFactura;

        /// <summary>
        /// Gets or sets the value of variable FechaFactura.
        /// </summary>
        [TestVariable("8567d7f2-1d5a-45cd-822f-89131332097e")]
        public string FechaFactura
        {
            get { return _FechaFactura; }
            set { _FechaFactura = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Sucursal.
        /// </summary>
        [TestVariable("f53dbe53-95a3-40e9-b9f5-2b741287451a")]
        public string Sucursal
        {
            get { return repo.Sucursal; }
            set { repo.Sucursal = value; }
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
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipHonorario' with focus on 'MDIPrincipal.TabMain.TipoHonorarioText'.", repo.MDIPrincipal.TabMain.TipoHonorarioTextInfo, new RecordItemIndex(7));
            repo.MDIPrincipal.TabMain.TipoHonorarioText.PressKeys(TipHonorario);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
