using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NunitFrameworkPageObjects.Utilities;

namespace NunitFrameworkPageObjects.Pages
{
    public static class UltimateQAAutomationPage
    {
        private static string AutomationPageTitle { get => Driver.UIDriver.Title.ToString(); }
        public static string GetAutomationPageTitle()
        {
            return AutomationPageTitle;
        }
    }
}
