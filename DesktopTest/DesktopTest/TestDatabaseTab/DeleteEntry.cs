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

namespace DesktopTest.TestDatabaseTab
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DeleteEntry recording.
    /// </summary>
    [TestModule("ad8feb3a-e2dd-4eeb-bae8-6aea4fc9774f", ModuleType.Recording, 1)]
    public partial class DeleteEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::DesktopTest.DesktopTestRepository repository.
        /// </summary>
        public static global::DesktopTest.DesktopTestRepository repo = global::DesktopTest.DesktopTestRepository.Instance;

        static DeleteEntry instance = new DeleteEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteEntry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteEntry Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabStandard.ShreyataSugandhiFemale20Testing' at 128;11.", repo.ApplicationUnderTest.RxTabStandard.ShreyataSugandhiFemale20TestingInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.RxTabStandard.ShreyataSugandhiFemale20Testing.Click("128;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabStandard.BtnDeletePerson' at 23;12.", repo.ApplicationUnderTest.RxTabStandard.BtnDeletePersonInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.RxTabStandard.BtnDeletePerson.Click("23;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabStandard.AgeTextBox' at 70;11.", repo.ApplicationUnderTest.RxTabStandard.AgeTextBoxInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.RxTabStandard.AgeTextBox.Click("70;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName='0') on item 'ApplicationUnderTest.RxTabStandard.List0'.", repo.ApplicationUnderTest.RxTabStandard.List0Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.RxTabStandard.List0Info, "AccessibleName", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeNotEqual (Text!='Shreyata Sugandhi (female, 20) Testing') on item 'ApplicationUnderTest.RxTabStandard.ShreyataSugandhiFemale20Testing'.", repo.ApplicationUnderTest.RxTabStandard.ShreyataSugandhiFemale20TestingInfo, new RecordItemIndex(4));
            Validate.AttributeNotEqual(repo.ApplicationUnderTest.RxTabStandard.ShreyataSugandhiFemale20TestingInfo, "Text", "Shreyata Sugandhi (female, 20) Testing");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
