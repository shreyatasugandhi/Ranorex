/*
 * Created by Ranorex
 * User: Shreyata
 * Date: 13-Dec-18
 * Time: 12:46 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace RxApp
{
    /// <summary>
    /// Description of CodeModule.
    /// </summary>
    [TestModule("5EE07961-4D01-4F10-98E8-B7EE68B0CDF1", ModuleType.UserCode, 1)]
    public class CodeModule : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CodeModule()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var repo = RxDeskTopApp.Instance;
            var enterNameTxBox = repo.RxMainFrame.RxTabIntroduction.EnterNameTxBox;
            var btnSubmitUserName = repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserName;
            
            
			enterNameTxBox.TextValue = "SS";
			btnSubmitUserName.Click();
			
			
			Host.Local.CloseApplication(repo.RxMainFrame.Self);
		
            
        }
    }
}
