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
    ///The AbrirVentanaInfo recording.
    /// </summary>
    [TestModule("1fb01ab9-8d58-4c3d-8b69-ca023ca1e03d", ModuleType.Recording, 1)]
    public partial class AbrirVentanaInfo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        /// </summary>
        public static global::IQDOC_Sanitas.IQDOC_SanitasRepository repo = global::IQDOC_Sanitas.IQDOC_SanitasRepository.Instance;

        static AbrirVentanaInfo instance = new AbrirVentanaInfo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AbrirVentanaInfo()
        {
            FolderId = "";
            Documentoid = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AbrirVentanaInfo Instance
        {
            get { return instance; }
        }

#region Variables

        string _FolderId;

        /// <summary>
        /// Gets or sets the value of variable FolderId.
        /// </summary>
        [TestVariable("6116f772-1cd7-4847-bc9e-2da3e15e80d4")]
        public string FolderId
        {
            get { return _FolderId; }
            set { _FolderId = value; }
        }

        string _Documentoid;

        /// <summary>
        /// Gets or sets the value of variable Documentoid.
        /// </summary>
        [TestVariable("ba10c8b6-a101-4171-a8f2-a608cfddb8df")]
        public string Documentoid
        {
            get { return _Documentoid; }
            set { _Documentoid = value; }
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

            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ''.", new RecordItemIndex(0));
            //Keyboard.Press("");
            //Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'MDIPrincipal.SomeContainer' at 549;102.", repo.MDIPrincipal.SomeContainerInfo, new RecordItemIndex(1));
            repo.MDIPrincipal.SomeContainer.Click(System.Windows.Forms.MouseButtons.Right, "549;102");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IQDOC.DatosImagen' at Center.", repo.IQDOC.DatosImagenInfo, new RecordItemIndex(2));
            repo.IQDOC.DatosImagen.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDatosImagen.CmdCerrar' at Center.", repo.FrmDatosImagen.CmdCerrarInfo, new RecordItemIndex(3));
            //repo.FrmDatosImagen.CmdCerrar.Click();
            //Delay.Milliseconds(0);
            
            ObtenerSolicitudId();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
