using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ECommerce.Utilities.Common
{
    public class WaitHelper
    {
        private IWebDriver Driver;

        public WaitHelper(IWebDriver driver)
        {
            Driver = driver;
        }


        public IWebElement WaitForClickable(By locator)
        {
            WebDriverWait wait =
                new WebDriverWait(
                    Driver,
                    TimeSpan.FromSeconds(10)
                );

            return wait.Until(
                ExpectedConditions.ElementToBeClickable(locator)
            );
        }


        public IWebElement WaitForVisible(By locator)
        {
            WebDriverWait wait =
                new WebDriverWait(
                    Driver,
                    TimeSpan.FromSeconds(10)
                );

            return wait.Until(
                ExpectedConditions.ElementIsVisible(locator)
            );
        }
    }
}