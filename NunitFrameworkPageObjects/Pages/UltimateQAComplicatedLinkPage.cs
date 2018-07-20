using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NunitFrameworkPageObjects.Utilities;

namespace NunitFrameworkPageObjects.Pages
{
    public static class UltimateQAComplicatedLinkPage
    {
        private static IWebElement ComplicatedPageLink { get => Driver.UIDriver.FindElement(By.LinkText("Complicated Page")); }
        public static void ClickComplicatedPageLink()
        {
            ComplicatedPageLink.Click();
        }
    }
}
