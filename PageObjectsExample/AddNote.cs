using OpenQA.Selenium;

namespace PageObjectsExample
{
    internal class AddNote
    {
        private IWebDriver _browser;

        public AddNote(IWebDriver browser)
        {
            _browser = browser;
        }

    }  
}