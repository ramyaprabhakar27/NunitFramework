using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using NunitFrameworkPageObjects.Utilities;

namespace NunitFrameworkPageObjects.Pages
{
    public static class UltimateQAHomePage
    {
        private static IWebElement SearchButton { get => Driver.UIDriver.FindElement(By.CssSelector("#et_top_search")); }
        private static IWebElement SearchText { get => Driver.UIDriver.FindElement(By.CssSelector(".et-search-field")); }
        public static void ClickSearchButton()
        {            
            SearchButton.Click();
        }
        public static void EnterSearchText(string text)
        {
            SearchText.SendKeys(text);
            SearchText.SendKeys(Keys.Enter);
        }
    }
}
