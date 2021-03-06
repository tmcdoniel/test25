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

namespace Demo3DS.Stephanie
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddRecordB recording.
    /// </summary>
    [TestModule("b9ef56f4-9f8b-4a9c-805f-d1937eed8a68", ModuleType.Recording, 1)]
    public partial class AddRecordB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Demo3DS.Demo3DSRepository repository.
        /// </summary>
        public static global::Demo3DS.Demo3DSRepository repo = global::Demo3DS.Demo3DSRepository.Instance;

        static AddRecordB instance = new AddRecordB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddRecordB()
        {
            varname = "null";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddRecordB Instance
        {
            get { return instance; }
        }

#region Variables

        string _varname;

        /// <summary>
        /// Gets or sets the value of variable varname.
        /// </summary>
        [TestVariable("efcead42-a551-48e6-8df7-e7bcccd631a0")]
        public string varname
        {
            get { return _varname; }
            set { _varname = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddEntry.FirstNameField' at Center.", repo.AddEntry.FirstNameFieldInfo, new RecordItemIndex(0));
            //repo.AddEntry.FirstNameField.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'John' with focus on 'AddEntry.FirstNameField'.", repo.AddEntry.FirstNameFieldInfo, new RecordItemIndex(1));
            //repo.AddEntry.FirstNameField.PressKeys("John");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", varname, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'John' on item 'AddEntry.FirstNameField'.", repo.AddEntry.FirstNameFieldInfo, new RecordItemIndex(3));
            repo.AddEntry.FirstNameField.Element.SetAttributeValue("Text", "John");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'AddEntry.FirstNameField' and assigning its value to variable 'varname'.", repo.AddEntry.FirstNameFieldInfo, new RecordItemIndex(4));
            varname = repo.AddEntry.FirstNameField.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", varname, new RecordItemIndex(5));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddEntry.LastNameField' at Center.", repo.AddEntry.LastNameFieldInfo, new RecordItemIndex(6));
            //repo.AddEntry.LastNameField.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Doe' with focus on 'AddEntry.LastNameField'.", repo.AddEntry.LastNameFieldInfo, new RecordItemIndex(7));
            //repo.AddEntry.LastNameField.PressKeys("Doe");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'Doe' on item 'AddEntry.LastNameField'.", repo.AddEntry.LastNameFieldInfo, new RecordItemIndex(8));
            repo.AddEntry.LastNameField.Element.SetAttributeValue("Text", "Doe");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddEntry.AgeField' at Center.", repo.AddEntry.AgeFieldInfo, new RecordItemIndex(9));
            //repo.AddEntry.AgeField.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '44' with focus on 'AddEntry.AgeField'.", repo.AddEntry.AgeFieldInfo, new RecordItemIndex(10));
            //repo.AddEntry.AgeField.PressKeys("44");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '44' on item 'AddEntry.AgeField'.", repo.AddEntry.AgeFieldInfo, new RecordItemIndex(11));
            repo.AddEntry.AgeField.Element.SetAttributeValue("Text", "44");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddEntry.AddPersonBtn' at Center.", repo.AddEntry.AddPersonBtnInfo, new RecordItemIndex(12));
            //repo.AddEntry.AddPersonBtn.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Press() on item 'AddEntry.AddPersonBtn'.", repo.AddEntry.AddPersonBtnInfo, new RecordItemIndex(13));
            repo.AddEntry.AddPersonBtn.Press();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
