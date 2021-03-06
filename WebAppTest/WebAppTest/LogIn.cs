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

namespace WebAppTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LogIn recording.
    /// </summary>
    [TestModule("51d6d200-95c4-45b6-9619-6dce7ea84b95", ModuleType.Recording, 1)]
    public partial class LogIn : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WebAppTestRepository repository.
        /// </summary>
        public static WebAppTestRepository repo = WebAppTestRepository.Instance;

        static LogIn instance = new LogIn();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogIn()
        {
            userid = "shreyata";
            userpassword = "shreyata1234";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogIn Instance
        {
            get { return instance; }
        }

#region Variables

        string _userid;

        /// <summary>
        /// Gets or sets the value of variable userid.
        /// </summary>
        [TestVariable("a2b5fd56-01ec-48ea-8f89-0e569f4ce0b8")]
        public string userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

        string _userpassword;

        /// <summary>
        /// Gets or sets the value of variable userpassword.
        /// </summary>
        [TestVariable("5f777c50-9af1-4b3a-95f1-6b81dcfe62bc")]
        public string userpassword
        {
            get { return _userpassword; }
            set { _userpassword = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.UserName' at 45;16.", repo.ApplicationUnderTest.SomeTableTag.UserNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SomeTableTag.UserName.Click("45;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$userid' with focus on 'ApplicationUnderTest.SomeTableTag.UserName'.", repo.ApplicationUnderTest.SomeTableTag.UserNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.SomeTableTag.UserName.PressKeys(userid);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.Password' at 53;11.", repo.ApplicationUnderTest.SomeTableTag.PasswordInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SomeTableTag.Password.Click("53;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$userpassword' with focus on 'ApplicationUnderTest.SomeTableTag.Password'.", repo.ApplicationUnderTest.SomeTableTag.PasswordInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.SomeTableTag.Password.PressKeys(userpassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.Login' at 15;12.", repo.ApplicationUnderTest.SomeTableTag.LoginInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.SomeTableTag.Login.Click("15;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://newtours.demoaut.com/images/masts/mast_flightfinder.gif') on item 'ApplicationUnderTest.SomeTableTag.HttpNewtoursDemoautComImagesMasts'.", repo.ApplicationUnderTest.SomeTableTag.HttpNewtoursDemoautComImagesMastsInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.SomeTableTag.HttpNewtoursDemoautComImagesMastsInfo, "Src", "http://newtours.demoaut.com/images/masts/mast_flightfinder.gif");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
