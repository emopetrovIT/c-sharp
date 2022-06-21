using NUnit.Framework;

namespace Homework.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public void AssertURL(string pageUrl)
        {
            {
                string url = Driver.Url;
                Assert.IsTrue(url.Equals(pageUrl));
            }
        }
    }
}
