using OpenQA.Selenium;
using System;

namespace PageObjectsExample
{
    internal partial class MainPage
    {
        private const string MAIN_PAGE_BASE_URL = "https://automatyzacja.benedykt.net";
        private readonly IWebDriver browser;

        private MainPage(IWebDriver browser)
        {
            this.browser = browser;
            browser.Navigate().GoToUrl(MAIN_PAGE_BASE_URL);
        }
        internal static MainPage Open()
        {
            return new MainPage(DriverFactory.Get());
        }

        internal NotePage NavigateToNewestNote()
        {
            var latestNote = browser.FindElement(By.CssSelector(".entry-title > a"));
            latestNote.Click();

            return new NotePage();
        }
    }
}