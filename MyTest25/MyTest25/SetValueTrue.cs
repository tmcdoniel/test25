///////////////////////////////////////////////////////////////////////////////
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

namespace MyTest25
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SetValueTrue recording.
    /// </summary>
    [TestModule("7690ee11-494c-47cc-9584-810dea749267", ModuleType.Recording, 1)]
    public partial class SetValueTrue : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest25Repository repository.
        /// </summary>
        public static MyTest25Repository repo = MyTest25Repository.Instance;

        static SetValueTrue instance = new SetValueTrue();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetValueTrue()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetValueTrue Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.ChkShowImage' at 7;8.", repo.RxMainFrame.ChkShowImageInfo, new RecordItemIndex(0));
            //repo.RxMainFrame.ChkShowImage.Click("7;8");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'RxMainFrame.ChkShowImage'.", repo.RxMainFrame.ChkShowImageInfo, new RecordItemIndex(1));
            //repo.RxMainFrame.ChkShowImage.Element.SetAttributeValue("Checked", "True");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Check() on item 'RxMainFrame.ChkShowImage'.", repo.RxMainFrame.ChkShowImageInfo, new RecordItemIndex(2));
            repo.RxMainFrame.ChkShowImage.Check();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxMainFrame.Self, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Uncheck() on item 'RxMainFrame.ChkShowImage'.", repo.RxMainFrame.ChkShowImageInfo, new RecordItemIndex(4));
            repo.RxMainFrame.ChkShowImage.Uncheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxMainFrame.Self, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F12 156}' with focus on 'RxMainFrame'.", repo.RxMainFrame.SelfInfo, new RecordItemIndex(7));
            repo.RxMainFrame.Self.EnsureVisible();
            Keyboard.Press("{F12 156}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F12 58}' with focus on 'RxMainFrame'.", repo.RxMainFrame.SelfInfo, new RecordItemIndex(8));
            repo.RxMainFrame.Self.EnsureVisible();
            Keyboard.Press("{F12 58}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
