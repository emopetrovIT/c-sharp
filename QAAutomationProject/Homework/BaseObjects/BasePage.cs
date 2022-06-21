using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Homework.Pages
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        public virtual void Navigate(string url)
        {
            Driver.Url = url;
        }
    }
}
