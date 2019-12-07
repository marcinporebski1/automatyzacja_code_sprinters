using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using Xunit;

namespace PageObjectsExample
{
    public class Mojtest : IDisposable
       
    {
        IWebDriver browser;
        public Mojtest()
        {
            browser = new ChromeDriver();
        }

        public void Dispose()
        {
            browser.Quit();
        }
        [Fact]
        public void add_new_note()
        {
            browser.Navigate().GoToUrl("https://automatyzacja.benedykt.net/wp-admin");
            var login = browser.FindElement(By.Id("user_login"));
            login.SendKeys("AUTOMATYZACJA");
            var password = browser.FindElement(By.Id("user_pass"));
            password.SendKeys("auto@Zima2019");
            browser.FindElement(By.Id("wp-submit")).Submit();
            var dodaj = browser.FindElement(By.ClassName("ab-label"));
            dodaj.Click();
            var title = browser.FindElement(By.Id("title"));
            title.SendKeys("costamcostam");
            var content = browser.FindElement(By.Id("content"));
            content.SendKeys("blablabla");
            var publikuj = browser.FindElement(By.Id("publish"));
            publikuj.Click();
            var wyloguj = browser.FindElement(By.Id("wp-admin-bar-logout"));
            wyloguj.Click();

            //var comments = browser.FindElements(By.XPath("http://automatyzacja.benedykt.net/uncategorized/costamcostam/"));
            //var myComments = comments
                //.Where(c => c.FindElement(By.XPath("http://automatyzacja.benedykt.net/uncategorized/costamcostam/")).Text == title);

            //Assert.Single(myComments);

        }
        
        internal void MoveToElement(By selector)
        {
            //var element = browser.FindElement(By.ClassName("ab-item");
            //MoveToElement(element);
        }
      
        internal void WaitForClickable(By selector, int seconds = 3)
        {
            var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(seconds));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(selector));
        }
        
    }
}
