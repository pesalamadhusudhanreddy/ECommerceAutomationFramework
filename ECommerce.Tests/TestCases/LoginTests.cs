using NUnit.Framework;
using ECommerce.Tests.Fixtures;
using ECommerce.Framework.Pages;

namespace ECommerce.Tests.TestCases
{
    public class LoginTests : BaseTest
    {

        [TestCase("standard_user", "secret_sauce")]
        [TestCase("problem_user", "secret_sauce")]
        [Retry(2)]
        public void LoginTest(string username, string password)
        {

            LoginPage login =
                new LoginPage(Driver);


            login.EnterUsername(username);

            login.EnterPassword(password);

            login.ClickLogin();


            Assert.That(
                Driver.Url,
                Does.Contain("inventory")
            );

        }
    }
}