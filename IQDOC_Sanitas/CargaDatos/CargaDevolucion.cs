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
    ///The CargaDevolucion recording.
    /// </summary>
    [TestModule("350af07b-c0bc-4558-ac35-9ca5dc87b773", ModuleType.Recording, 1)]
    public partial class CargaDevolucion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        /// </summary>
        public static global::IQDOC_Sanitas.IQDOC_SanitasRepository repo = global::IQDOC_Sanitas.IQDOC_SanitasRepository.Instance;

        static CargaDevolucion instance = new CargaDevolucion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CargaDevolucion()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CargaDevolucion Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CodCausal.
        /// </summary>
        [TestVariable("76573065-3087-4296-9bf6-8692000dcf32")]
        public string CodCausal
        {
            get { return repo.CodCausal; }
            set { repo.CodCausal = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F7}' with focus on 'MDIPrincipal.TabMain.NumeroFactura'.", repo.MDIPrincipal.TabMain.NumeroFacturaInfo, new RecordItemIndex(0));
            repo.MDIPrincipal.TabMain.NumeroFactura.PressKeys("{F7}");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'FrmControllerCapturer.CodigoCausal'.", repo.FrmControllerCapturer.CodigoCausalInfo, new RecordItemIndex(1));
            //repo.FrmControllerCapturer.CodigoCausal.Focus();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ' ' with focus on 'FrmControllerCapturer.CodigoCausal'.", repo.FrmControllerCapturer.CodigoCausalInfo, new RecordItemIndex(2));
            repo.FrmControllerCapturer.CodigoCausal.PressKeys(" ");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmControllerCapturer.CodigoCausal' at 46;8.", repo.FrmControllerCapturer.CodigoCausalInfo, new RecordItemIndex(3));
            //repo.FrmControllerCapturer.CodigoCausal.Click("46;8");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmControllerCapturer.Text' at 50;27.", repo.FrmControllerCapturer.TextInfo, new RecordItemIndex(4));
            repo.FrmControllerCapturer.Text.Click("50;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'devoluciones Prueba' with focus on 'FrmControllerCapturer.Text'.", repo.FrmControllerCapturer.TextInfo, new RecordItemIndex(5));
            repo.FrmControllerCapturer.Text.PressKeys("devoluciones Prueba");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmControllerCapturer.Text' at 144;161.", repo.FrmControllerCapturer.TextInfo, new RecordItemIndex(6));
            //repo.FrmControllerCapturer.Text.Click("144;161");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmControllerCapturer.BtnSalirCausal' at Center.", repo.FrmControllerCapturer.BtnSalirCausalInfo, new RecordItemIndex(7));
            repo.FrmControllerCapturer.BtnSalirCausal.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MDIPrincipal.TabMain.NumeroFactura'.", repo.MDIPrincipal.TabMain.NumeroFacturaInfo, new RecordItemIndex(8));
            //repo.MDIPrincipal.TabMain.NumeroFactura.PressKeys("{Tab}");
            //Delay.Milliseconds(0);
            
            try {
                //Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'InformacionRIPS_cof.Aceptar' at Center.", repo.InformacionRIPS_cof.AceptarInfo, new RecordItemIndex(9));
                //repo.InformacionRIPS_cof.Aceptar.Click();
                //Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(10));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
