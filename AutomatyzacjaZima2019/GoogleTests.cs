using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AutomatyzacjaZima2019
{
    public class GoogleTests : IDisposable
    {
        IWebDriver browser;
        public GoogleTests()
        {
            browser = new ChromeDriver();
        }

        public void Dispose()
        {
            browser.Quit();
        }
    
        [Fact]
        public void CanGoogleWeatherForWarsaw()
        {
            browser.Navigate().GoToUrl("https://google.com");
            var queryBox = browser.FindElement(By.CssSelector(".gLFyf"));
            queryBox.SendKeys("pogoda warszawa");
            queryBox.Submit();

            var result = browser.FindElement(By.Id("wob_tm"));
            Assert.Equal("3", result.Text);
        }

    }
}

public class ArekTests : IDisposable
{
    IWebDriver browser;
    public ArekTests()
    {
        browser = new ChromeDriver();
    }

    public void Dispose()
    {
        browser.Quit();
    }

    [Fact]
    public void add_new_comment()
        private void MoveToElement(IWebElement element)
    {
        browser.Navigate().GoToUrl("https://automatyzacja.benedykt.net");
        var queryBox = browser.FindElement(By.CssSelector(".entry-header"));
        var link = queryBox.FindElement(By.TagName("a"));
        link.Click();
        var comment = browser.FindElement(By.Id("comment"));
        comment.SendKeys("Komentarz testowy");
        var sign = browser.FindElement(By.Id("author"));
        sign.SendKeys("Jan Janowski");
        var mail = browser.FindElement(By.Id("email"));
        mail.SendKeys("jan@nowak.pl");
        Action builder = new Actions(browser);
        Actions moveTo = builder.MoveToElement(element);
        moveTo.Build().Perform();
        var publiccomment = browser.FindElement(By.Id("Submit"));
        publiccomment.Click();
     
    }

}

