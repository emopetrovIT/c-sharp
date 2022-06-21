﻿using Homework.Pages;
using NUnit.Framework;


namespace Homework.Tests
{
    [TestFixture]
    public class GoogleTests : BaseTest
    {
        private GooglePage _googlePage;

        [SetUp]
        public void ClassInit()
        {
            _googlePage = new GooglePage(Driver);
        }

        [Test]
        public void GoogleSearchSeleniumPage()
        {
            _googlePage.Navigate(_googlePage);
            _googlePage.SearchGoogle("Selenium");
            _googlePage.VerifyTitleSeleniumPage("Selenium - Web Browser Automation");
        }
    }
}
