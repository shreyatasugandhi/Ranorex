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

namespace WebAppTest.BookAFlight
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PurchaseAFlight recording.
    /// </summary>
    [TestModule("beb6db72-138f-4600-b93a-2e9b550dad6a", ModuleType.Recording, 1)]
    public partial class PurchaseAFlight : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::WebAppTest.WebAppTestRepository repository.
        /// </summary>
        public static global::WebAppTest.WebAppTestRepository repo = global::WebAppTest.WebAppTestRepository.Instance;

        static PurchaseAFlight instance = new PurchaseAFlight();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PurchaseAFlight()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PurchaseAFlight Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.PassFirst0' at 103;13.", repo.ApplicationUnderTest.SomeTableTag.PassFirst0Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SomeTableTag.PassFirst0.Click("103;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Shreyata' with focus on 'ApplicationUnderTest.SomeTableTag.PassFirst0'.", repo.ApplicationUnderTest.SomeTableTag.PassFirst0Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.SomeTableTag.PassFirst0.PressKeys("Shreyata");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.PassLast0' at 37;6.", repo.ApplicationUnderTest.SomeTableTag.PassLast0Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SomeTableTag.PassLast0.Click("37;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Sugandhi' with focus on 'ApplicationUnderTest.SomeTableTag.PassLast0'.", repo.ApplicationUnderTest.SomeTableTag.PassLast0Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.SomeTableTag.PassLast0.PressKeys("Sugandhi");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.Pass0Meal' at 108;12.", repo.ApplicationUnderTest.SomeTableTag.Pass0MealInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.SomeTableTag.Pass0Meal.Click("108;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Selectbox.Hindu' at 69;9.", repo.Selectbox.HinduInfo, new RecordItemIndex(5));
            repo.Selectbox.Hindu.MoveTo("69;9");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Selectbox.Hindu' at 69;9.", repo.Selectbox.HinduInfo, new RecordItemIndex(6));
            repo.Selectbox.Hindu.MoveTo("69;9");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.PassFirst1' at 86;7.", repo.ApplicationUnderTest.SomeTableTag.PassFirst1Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.SomeTableTag.PassFirst1.Click("86;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'S' with focus on 'ApplicationUnderTest.SomeTableTag.PassFirst1'.", repo.ApplicationUnderTest.SomeTableTag.PassFirst1Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.SomeTableTag.PassFirst1.PressKeys("S");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.PassLast1' at 24;14.", repo.ApplicationUnderTest.SomeTableTag.PassLast1Info, new RecordItemIndex(9));
            repo.ApplicationUnderTest.SomeTableTag.PassLast1.Click("24;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'SS' with focus on 'ApplicationUnderTest.SomeTableTag.PassLast1'.", repo.ApplicationUnderTest.SomeTableTag.PassLast1Info, new RecordItemIndex(10));
            repo.ApplicationUnderTest.SomeTableTag.PassLast1.PressKeys("SS");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'DBML' on item 'ApplicationUnderTest.SomeTableTag.Pass1Meal'.", repo.ApplicationUnderTest.SomeTableTag.Pass1MealInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.SomeTableTag.Pass1Meal.Element.SetAttributeValue("TagValue", "DBML");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.PassFirst2' at 54;11.", repo.ApplicationUnderTest.SomeTableTag.PassFirst2Info, new RecordItemIndex(12));
            repo.ApplicationUnderTest.SomeTableTag.PassFirst2.Click("54;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'S' with focus on 'ApplicationUnderTest.SomeTableTag.PassFirst2'.", repo.ApplicationUnderTest.SomeTableTag.PassFirst2Info, new RecordItemIndex(13));
            repo.ApplicationUnderTest.SomeTableTag.PassFirst2.PressKeys("S");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.PassLast2' at 36;15.", repo.ApplicationUnderTest.SomeTableTag.PassLast2Info, new RecordItemIndex(14));
            repo.ApplicationUnderTest.SomeTableTag.PassLast2.Click("36;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'S' with focus on 'ApplicationUnderTest.SomeTableTag.PassLast2'.", repo.ApplicationUnderTest.SomeTableTag.PassLast2Info, new RecordItemIndex(15));
            repo.ApplicationUnderTest.SomeTableTag.PassLast2.PressKeys("S");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'LCML' on item 'ApplicationUnderTest.SomeTableTag.Pass2Meal'.", repo.ApplicationUnderTest.SomeTableTag.Pass2MealInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.SomeTableTag.Pass2Meal.Element.SetAttributeValue("TagValue", "LCML");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.Creditnumber' at 78;12.", repo.ApplicationUnderTest.SomeTableTag.CreditnumberInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.SomeTableTag.Creditnumber.Click("78;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '123456789' with focus on 'ApplicationUnderTest.SomeTableTag.Creditnumber'.", repo.ApplicationUnderTest.SomeTableTag.CreditnumberInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.SomeTableTag.Creditnumber.PressKeys("123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -660 units.", new RecordItemIndex(19));
            Mouse.ScrollWheel(-660);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeTableTag.BuyFlights' at 75;10.", repo.ApplicationUnderTest.SomeTableTag.BuyFlightsInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.SomeTableTag.BuyFlights.Click("75;10");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}