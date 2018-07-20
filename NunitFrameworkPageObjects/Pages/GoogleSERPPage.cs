using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NunitFrameworkPageObjects.Utilities;
using System.Threading;

namespace NunitFrameworkPageObjects.Pages
{
    public static class GoogleSERPPage
    {
        private static IWebElement SearchLink { get => Driver.UIDriver.FindElement(By.LinkText("Selenium WebDriver")); }
        public static void ClickSearchLink()
        {              
            SearchLink.Click();           
        }
    }
}
