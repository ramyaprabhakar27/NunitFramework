using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitFrameworkPageObjects.Pages;
using NunitFrameworkPageObjects.Utilities;
using NunitFrameworkTests.Utilities;
using NLog;

namespace NunitFrameworkTests.Tests
{
    [TestFixture]
    public static class UltimateQATest
    {
        private static Logger logger = LogManager.GetLogger("ComplicatedPage");
        [SetUp]
        public static void SetUp()
        {
            Driver.SetUp();
        }
        [Test]
        public static void ComplicatedPageTest()
        {
            Driver.GoToSite(URL.ultimateQAUrl);            
            UltimateQAHomePage.ClickSearchButton();
            UltimateQAHomePage.EnterSearchText("Complicated Page");
            UltimateQAComplicatedLinkPage.ClickComplicatedPageLink();
            if(!(UltimateQAComplicatedPage.GetComplicatedPageTitle()).Equals("Complicated Page - Ultimate QA"))
            {
                logger.Info("Actual Text did not match Expected Text");
            }
            UltimateQAComplicatedPage.EnterSearchText("Automation Testing");
            UltimateQAComplicatedPage.ClickSearchButton();
            Assert.IsTrue(UltimateQAAutomationPage.GetAutomationPageTitle().Contains("You searched for Automation Testing - Ultimate QA"));
        }

        [Test]
        public static void FillFormAndSubmit()
        {
            Driver.GoToSite(URL.ComplicatedPageUrl);
            UltimateQAComplicatedPage.EnterName("Ramya");
            UltimateQAComplicatedPage.EnterEmail("ramya@gmail.com");
            UltimateQAComplicatedPage.EnterMessage("Fill the form");
            UltimateQAComplicatedPage.EnterCaptchaResult();
            UltimateQAComplicatedPage.SubmitForm();
        }

        [TearDown]
        public static void TearDown()
        {
            Driver.TearDown();
        }
    }
}
