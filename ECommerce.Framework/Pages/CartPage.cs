using OpenQA.Selenium;

namespace ECommerce.Framework.Pages
{
    public class CartPage
    {
        private IWebDriver Driver;


        public CartPage(IWebDriver driver)
        {
            Driver = driver;
        }


        private By CheckoutButton =
            By.Id("checkout");


        public void ClickCheckout()
        {
            Driver.FindElement(CheckoutButton)
                  .Click();
        }
    }
}