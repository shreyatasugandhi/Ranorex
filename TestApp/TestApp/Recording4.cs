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

namespace TestApp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording4 recording.
    /// </summary>
    [TestModule("b15ab227-5e42-4f4b-acd9-879652bab16e", ModuleType.Recording, 1)]
    public partial class Recording4 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestAppRepository repository.
        /// </summary>
        public static TestAppRepository repo = TestAppRepository.Instance;

        static Recording4 instance = new Recording4();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording4()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording4 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabImageBased.ChkShowImage' at 4;4.", repo.ApplicationUnderTest.RxTabImageBased.ChkShowImageInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.RxTabImageBased.ChkShowImage.Click(new Location(ChkShowImage_Screenshot1, "4;4", ChkShowImage_Screenshot1_Options));
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RxTabImageBased.MonthCalendar1' at 8;6.", repo.ApplicationUnderTest.RxTabImageBased.MonthCalendar1Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.RxTabImageBased.MonthCalendar1.Click(new Location(MonthCalendar1_Screenshot1, "8;6", MonthCalendar1_Screenshot1_Options));
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.RxTabImageBased.TheCat'.", repo.ApplicationUnderTest.RxTabImageBased.TheCatInfo, new RecordItemIndex(2));
            Validate.Exists(repo.ApplicationUnderTest.RxTabImageBased.TheCatInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage ChkShowImage_Screenshot1
        { get { return repo.ApplicationUnderTest.RxTabImageBased.ChkShowImageInfo.GetScreenshot1(new Rectangle(2, 4, 8, 8)); } }

        Imaging.FindOptions ChkShowImage_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage MonthCalendar1_Screenshot1
        { get { return repo.ApplicationUnderTest.RxTabImageBased.MonthCalendar1Info.GetScreenshot1(new Rectangle(96, 82, 12, 11)); } }

        Imaging.FindOptions MonthCalendar1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
