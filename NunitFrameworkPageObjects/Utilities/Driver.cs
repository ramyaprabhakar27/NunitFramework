using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitFrameworkPageObjects.Utilities
{
    public static class Driver
    {
        private static IWebDriver uiDriver;

        public static IWebDriver UIDriver
        {
            get
            {
                return uiDriver;
            }
            set
            {
                uiDriver = value;
            }
        }

        public static void SetUp()
        {
            if (IsDriverNull())
            {
                UIDriver = new ChromeDriver();
                UIDriver.Manage().Window.Maximize();
            }
        }

        public static void GoToSite(string url)
        {
            UIDriver.Navigate().GoToUrl(url);
        }

        public static void TearDown()
        {
            try
            {
                UIDriver.Manage().Cookies.DeleteAllCookies();
                UIDriver.Dispose();
                UIDriver.Close();
                UIDriver.Quit();
                UIDriver = null;
            }
            catch(Exception)
            {

            }
        }

        public static bool IsDriverNull()
        {
            return (UIDriver == null);
        }
    }
}
