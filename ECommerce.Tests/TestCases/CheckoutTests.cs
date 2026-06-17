using ECommerce.Tests.Fixtures;
using ECommerce.Framework.Pages;

namespace ECommerce.Tests.TestCases
{
    public class CheckoutTests : BaseTest
    {

        [Test]
        public void CheckoutTest()
        {

            LoginPage login =
                new LoginPage(Driver);


            login.EnterUsername("standard_user");
            login.EnterPassword("secret_sauce");
            login.ClickLogin();


            Assert.That(
                Driver.Url,
                Does.Contain("inventory")
            );

        }

    }
}