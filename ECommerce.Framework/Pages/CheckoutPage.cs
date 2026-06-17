using OpenQA.Selenium;

namespace ECommerce.Framework.Pages
{
    public class CheckoutPage
    {
        private IWebDriver Driver;


        public CheckoutPage(IWebDriver driver)
        {
            Driver = driver;
        }


        private By FirstName =
            By.Id("first-name");


        private By LastName =
            By.Id("last-name");


        private By PostalCode =
            By.Id("postal-code");


        private By ContinueButton =
            By.Id("continue");



        public void EnterFirstName(string firstName)
        {
            Driver.FindElement(FirstName)
                  .SendKeys(firstName);
        }


        public void EnterLastName(string lastName)
        {
            Driver.FindElement(LastName)
                  .SendKeys(lastName);
        }


        public void EnterPostalCode(string code)
        {
            Driver.FindElement(PostalCode)
                  .SendKeys(code);
        }


        public void ClickContinue()
        {
            Driver.FindElement(ContinueButton)
                  .Click();
        }
    }
}