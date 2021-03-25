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
    ///The Clasificacion recording.
    /// </summary>
    [TestModule("9cd5143d-47fd-4f5d-b2c0-3eacfdde5e7f", ModuleType.Recording, 1)]
    public partial class Clasificacion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        /// </summary>
        public static global::IQDOC_Sanitas.IQDOC_SanitasRepository repo = global::IQDOC_Sanitas.IQDOC_SanitasRepository.Instance;

        static Clasificacion instance = new Clasificacion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Clasificacion()
        {
            SolicitudId = "";
            ParFolderId = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Clasificacion Instance
        {
            get { return instance; }
        }

#region Variables

        string _SolicitudId;

        /// <summary>
        /// Gets or sets the value of variable SolicitudId.
        /// </summary>
        [TestVariable("e8873185-6762-4130-aece-e3296621a0f7")]
        public string SolicitudId
        {
            get { return _SolicitudId; }
            set { _SolicitudId = value; }
        }

        string _ParFolderId;

        /// <summary>
        /// Gets or sets the value of variable ParFolderId.
        /// </summary>
        [TestVariable("1e2770af-b7e7-4750-ba97-e481aa69e956")]
        public string ParFolderId
        {
            get { return _ParFolderId; }
            set { _ParFolderId = value; }
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

            Clasificar();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.Copy_of_Btn_GuadarClasi' at Center.", repo.MDIPrincipal.Copy_of_Btn_GuadarClasiInfo, new RecordItemIndex(1));
            repo.MDIPrincipal.Copy_of_Btn_GuadarClasi.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MDIPrincipal.FrmclasiffierSura.Btn_Salir' at Center.", repo.MDIPrincipal.FrmclasiffierSura.Btn_SalirInfo, new RecordItemIndex(2));
            repo.MDIPrincipal.FrmclasiffierSura.Btn_Salir.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
