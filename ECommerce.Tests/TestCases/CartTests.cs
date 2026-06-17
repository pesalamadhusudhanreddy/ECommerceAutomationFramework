using ECommerce.Tests.Fixtures;
using ECommerce.Framework.Pages;

namespace ECommerce.Tests.TestCases
{
    public class CartTests : BaseTest
    {

        [Test]
        public void OpenCart()
        {

            LoginPage login =
                new LoginPage(Driver);


            login.EnterUsername("standard_user");
            login.EnterPassword("secret_sauce");
            login.ClickLogin();


            InventoryPage inventory =
                new InventoryPage(Driver);


            Assert.That(
                inventory.GetTitle(),
                Is.EqualTo("Products")
            );

        }

    }
}