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
    ///The CargaDatos4 recording.
    /// </summary>
    [TestModule("447d2d85-1269-425b-bf56-108d6d5926a5", ModuleType.Recording, 1)]
    public partial class CargaDatos4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        /// </summary>
        public static global::IQDOC_Sanitas.IQDOC_SanitasRepository repo = global::IQDOC_Sanitas.IQDOC_SanitasRepository.Instance;

        static CargaDatos4 instance = new CargaDatos4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CargaDatos4()
        {
            ValBruto = "10000";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CargaDatos4 Instance
        {
            get { return instance; }
        }

#region Variables

        string _ValBruto;

        /// <summary>
        /// Gets or sets the value of variable ValBruto.
        /// </summary>
        [TestVariable("193a8434-a58d-49bc-b9fb-b3ec2b843aa3")]
        public string ValBruto
        {
            get { return _ValBruto; }
            set { _ValBruto = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MDIPrincipal.TabMain.ValorBruto' at Center.", repo.MDIPrincipal.TabMain.ValorBrutoInfo, new RecordItemIndex(0));
            repo.MDIPrincipal.TabMain.ValorBruto.DoubleClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ValBruto' with focus on 'MDIPrincipal.TabMain.ValorBruto'.", repo.MDIPrincipal.TabMain.ValorBrutoInfo, new RecordItemIndex(1));
            repo.MDIPrincipal.TabMain.ValorBruto.PressKeys(ValBruto);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(2));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
