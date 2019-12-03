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

        [Fact]
        public void add_new_comment()
        {
            browser.Navigate().GoToUrl("https://automatyzacja.benedykt.net");
            var queryBox = browser.FindElement(By.CssSelector(".entry-header"));
            var link = queryBox.FindElement(By.TagName("a"));
            link.Click();
            var comment = browser.FindElement(By.Id("comment"));
            var exampleText = Faker.Lorem.Paragraph();
            comment.SendKeys(exampleText);
            var sign = browser.FindElement(By.Id("author"));
            var ExampleAuthor = Faker.Name.FullName();
            sign.SendKeys(ExampleAuthor);
            var mail = browser.FindElement(By.Id("email"));
            var exampleEmail = Faker.Internet.Email();
            mail.SendKeys(exampleEmail);

            MoveToElement(browser.FindElement(By.CssSelector("div.nav-links")));
            browser.FindElement(By.Id("submit")).Submit();

            var comments = browser.FindElements(By.CssSelector("article.comment-body"));
            var myComments = comments
                .Where(c => c.FindElement(By.CssSelector(".fn")).Text == ExampleAuthor)
                .Where(c => c.FindElement(By.CssSelector(".comment-content > p")).Text == exampleText);

            Assert.Single(myComments);

        }
        private void MoveToElement(IWebElement element)
        {
            Actions builder = new Actions(browser);
            Actions moveTo = builder.MoveToElement(element);
            moveTo.Build().Perform();
        }
    }
}

//public class ArekTests : IDisposable
//{
//    IWebDriver browser;
//    public ArekTests()
//    {
//        browser = new ChromeDriver();
//    }

//    public void Dispose()
//    {
//        browser.Quit();
//    }


//}