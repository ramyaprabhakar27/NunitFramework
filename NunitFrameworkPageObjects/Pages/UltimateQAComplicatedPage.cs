using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NunitFrameworkPageObjects.Utilities;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace NunitFrameworkPageObjects.Pages
{
    public static class UltimateQAComplicatedPage
    {
        private static Actions builder = new Actions(Driver.UIDriver);
        private static string ComplicatedPageTitle { get => Driver.UIDriver.Title.ToString(); }
        private static IWebElement SearchText { get => Driver.UIDriver.FindElement(By.Id("s")); }
        private static IWebElement SearchButton { get => Driver.UIDriver.FindElement(By.Id("searchsubmit")); }
        private static IWebElement Form { get => Driver.UIDriver.FindElements(By.CssSelector(".et_pb_contact_form.clearfix"))[0]; }
        private static IWebElement Name { get => Driver.UIDriver.FindElements(By.Id("et_pb_contact_name_1"))[0]; }
        private static IWebElement Email { get => Driver.UIDriver.FindElements(By.Id("et_pb_contact_email_1"))[0]; }
        private static IWebElement Message { get => Driver.UIDriver.FindElements(By.Id("et_pb_contact_message_1"))[0]; }
        private static IWebElement CaptchaQuestion { get => Driver.UIDriver.FindElements(By.ClassName("et_pb_contact_captcha_question"))[0]; }
        private static IWebElement CaptchaResult { get => Driver.UIDriver.FindElements(By.CssSelector(".input.et_pb_contact_captcha"))[0]; }
        private static IWebElement Submit { get => Driver.UIDriver.FindElements(By.CssSelector(".et_pb_contact_submit.et_pb_button"))[0]; }


        public static string GetComplicatedPageTitle()
        {
            return ComplicatedPageTitle;
        }
        public static void EnterSearchText(string text)
        {
            ScrollToView();
            SearchText.SendKeys(text);
        }
        public static void ClickSearchButton()
        {
            SearchButton.Click();
        }
        public static void ScrollToView()
        {                    
            builder.MoveToElement(SearchText).Build().Perform();
            Thread.Sleep(2000);
        }
        public static void EnterName(string name)
        {
            builder.MoveToElement(Form).Build().Perform();
            Name.SendKeys(name);
        }
        public static void EnterEmail(string email)
        {            
            Email.SendKeys(email);
        }
        public static void EnterMessage(string message)
        {
            Message.SendKeys(message);
        }
        public static void EnterCaptchaResult()
        {
            var split = CaptchaQuestion.Text.Split(' ');
            int result = int.Parse(split[0]) + int.Parse(split[2]);
            CaptchaResult.SendKeys(result.ToString());
        }
        public static void SubmitForm()
        {
            Submit.Click();
        }
    }
}
