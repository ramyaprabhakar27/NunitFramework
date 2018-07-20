using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NunitFrameworkPageObjects.Utilities;

namespace NunitFrameworkPageObjects.Pages
{
    public static class GoogleHomePage
    {
        private static IWebElement SearchText { get => Driver.UIDriver.FindElement(By.CssSelector("#lst-ib")); }

        public static void EnterSearchText(string searchData)
        {                                        
                SearchText.SendKeys(searchData);
                SearchText.SendKeys(Keys.Enter);           
        }
    }
}
