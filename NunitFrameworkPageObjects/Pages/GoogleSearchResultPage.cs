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
    public static class GoogleSearchResultPage
    {
        private static IWebElement ActualData { get => Driver.UIDriver.FindElement(By.CssSelector("#sidebar>p>strong")); }
        public static string GetActualData()
        {
             return ActualData.Text.ToString();           
        }
    }
}
