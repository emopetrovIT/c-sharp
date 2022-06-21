using NUnit.Framework;

namespace Homework.Pages
{
    public partial class LoginPage
    {
        public void VerifyHomeIconIsDisplayed(LoginPage loginPage)
        {
            {
                Assert.IsTrue(HomeIcon.Displayed);
            }
        }
    }
}
