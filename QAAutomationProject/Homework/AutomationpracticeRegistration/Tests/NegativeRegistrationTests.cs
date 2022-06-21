using Homework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;


namespace Homework.Tests
{
    [TestFixture]
    public class NegativeRegistrationTests : BaseTest
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private RegistrationUser _user;

        [SetUp]
        public void ClassInit()
        {
            _loginPage = new LoginPage(Driver);
            _regPage = new RegistrationPage(Driver);
            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void FillRegistrationFormWithoutFirstName()
        {
            _user.FirstName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("firstname is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutLastName()
        {
            _user.LastName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("lastname is required.");
        }


        [Test]
        public void FillRegistrationFormWithoutPassword()
        {
            _user.Password = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("passwd is required.");
        }


        [Test]
        public void FillRegistrationFormWithoutCity()
        {
            _user.City = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("city is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutFirstAndLastName()
        {
            _user.FirstName = "";
            _user.LastName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessageFirstAndLastname("firstname is required.","lastname is required.");
        }

        [TearDown]
        public void CleanUp()
        {
            var name = TestContext.CurrentContext.Test.Name;
            var result = TestContext.CurrentContext.Result.Outcome;

            if (result != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var fullPath = Path.GetFullPath("..\\..\\..\\Screenshots\\");
                screenshot.SaveAsFile(fullPath + name + ".png", ScreenshotImageFormat.Png);
            }
        }
    }
}
