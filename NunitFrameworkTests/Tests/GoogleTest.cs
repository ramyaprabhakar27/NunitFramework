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
    public static class GoogleTest
    {
        private static Logger logger = LogManager.GetLogger("GoogleSearch");
        [SetUp]
        public static void SetUp()
        {
            Driver.SetUp();
        }
        [Test]
        public static void GoogleHomePageTest()
        {
            Driver.GoToSite(URL.googleUrl);
            GoogleHomePage.EnterSearchText("Selenium Webdriver");
            GoogleSERPPage.ClickSearchLink();
            string expctedData = "Selenium is a suite of tools";
            string actualData = GoogleSearchResultPage.GetActualData();    
            if(!expctedData.Equals(actualData))
            {
                logger.Info($"Expected Text : {expctedData}    Actual Output : {actualData}");
            }
            Assert.AreEqual(expctedData, actualData);
        }

        [TearDown]
        public static void TearDown()
        {
            Driver.TearDown();
        }
    }
}
