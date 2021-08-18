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

namespace Demo3DS.Connor
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FileUpload recording.
    /// </summary>
    [TestModule("71f6db88-4186-428e-9b3f-6e548b596b4d", ModuleType.Recording, 1)]
    public partial class FileUpload : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Demo3DS.Demo3DSRepository repository.
        /// </summary>
        public static global::Demo3DS.Demo3DSRepository repo = global::Demo3DS.Demo3DSRepository.Instance;

        static FileUpload instance = new FileUpload();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FileUpload()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FileUpload Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Users\\Timothy McDoniel\\Documents\\Demo\\FileUpload.exe' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Users\\Timothy McDoniel\\Documents\\Demo\\FileUpload.exe", "", "C:\\Users\\Timothy McDoniel\\Documents\\Demo", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.Button1' at Center.", repo.Form1.Button1Info, new RecordItemIndex(1));
            repo.Form1.Button1.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.LbFinished' at Center.", repo.Form1.LbFinishedInfo, new RecordItemIndex(2));
            //repo.Form1.LbFinished.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 9s.", new RecordItemIndex(3));
            //Delay.Duration(9000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Form1.LbProgress'", repo.Form1.LbProgressInfo, new ActionTimeout(10000), new RecordItemIndex(4));
            repo.Form1.LbProgressInfo.WaitForExists(10000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.Form1.Self, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form1.BtResetUI' at Center.", repo.Form1.BtResetUIInfo, new RecordItemIndex(6));
            repo.Form1.BtResetUI.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'Form1'.", repo.Form1.SelfInfo, new RecordItemIndex(7));
            Host.Current.CloseApplication(repo.Form1.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
