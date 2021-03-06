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

namespace IQDOC_Sanitas.ScriptGeneral
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Login recording.
    /// </summary>
    [TestModule("2ba9adbb-a40f-4ce1-93a5-6ce1377abf3c", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::IQDOC_Sanitas.IQDOC_SanitasRepository repository.
        /// </summary>
        public static global::IQDOC_Sanitas.IQDOC_SanitasRepository repo = global::IQDOC_Sanitas.IQDOC_SanitasRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            Usuario = "PruebasAuto";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _Usuario;

        /// <summary>
        /// Gets or sets the value of variable Usuario.
        /// </summary>
        [TestVariable("07e8eff5-4ed2-47d1-964f-1542d38d635e")]
        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Compania.
        /// </summary>
        [TestVariable("6dfb5aab-fc5e-4822-a9f1-b097fc71ce1d")]
        public string Compania
        {
            get { return repo.Compania; }
            set { repo.Compania = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Linea.
        /// </summary>
        [TestVariable("33494307-537b-4d10-a8c0-dbb1c23a5194")]
        public string Linea
        {
            get { return repo.Linea; }
            set { repo.Linea = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmLogin.TxtLogin' at 18;12.", repo.FrmLogin.TxtLoginInfo, new RecordItemIndex(0));
            repo.FrmLogin.TxtLogin.Click("18;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Usuario' with focus on 'FrmLogin.TxtLogin'.", repo.FrmLogin.TxtLoginInfo, new RecordItemIndex(1));
            repo.FrmLogin.TxtLogin.PressKeys(Usuario);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmLogin.TxtPassword' at 33;5.", repo.FrmLogin.TxtPasswordInfo, new RecordItemIndex(2));
            repo.FrmLogin.TxtPassword.Click("33;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test.2021' with focus on 'FrmLogin.TxtPassword'.", repo.FrmLogin.TxtPasswordInfo, new RecordItemIndex(3));
            repo.FrmLogin.TxtPassword.PressKeys("Test.2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmLogin.CmbCompania' at 66;16.", repo.FrmLogin.CmbCompaniaInfo, new RecordItemIndex(4));
            repo.FrmLogin.CmbCompania.Click("66;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Select() on item 'List1000.DdlCompania'.", repo.List1000.DdlCompaniaInfo, new RecordItemIndex(5));
            repo.List1000.DdlCompania.Select();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.DdlCompania' at Center.", repo.List1000.DdlCompaniaInfo, new RecordItemIndex(6));
            repo.List1000.DdlCompania.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(7));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmLogin.CmbLinea' at 47;5.", repo.FrmLogin.CmbLineaInfo, new RecordItemIndex(8));
            repo.FrmLogin.CmbLinea.Click("47;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.CuentasMedicas' at 36;8.", repo.List1000.CuentasMedicasInfo, new RecordItemIndex(9));
            repo.List1000.CuentasMedicas.Click("36;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmLogin.CmdAceptar' at 21;9.", repo.FrmLogin.CmdAceptarInfo, new RecordItemIndex(10));
            repo.FrmLogin.CmdAceptar.Click("21;9");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
