using System;
using OpenQA.Selenium;

namespace PageObjectsExample
{
    internal class AdminPage
    {
        private const string ADMIN_PAGE_BASE_URL = "https://automatyzacja.benedykt.net/wp-admin";
        private readonly IWebDriver _browser;

        private AdminPage(IWebDriver browser)
        {
            _browser = browser;
            browser.Navigate().GoToUrl(ADMIN_PAGE_BASE_URL);
            var login = _browser.FindElement(By.Id("user_login"));
            login.SendKeys("AUTOMATYZACJA");
            var password = _browser.FindElement(By.Id("user_pass"));
            password.SendKeys("auto@Zima2019");
        }

        internal static AdminPage Open(IWebDriver webDriver)
        {
            return  new AdminPage(webDriver);
        }
    }
}