using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ECommerce.Framework.Drivers
{
    public class BrowserFactory
    {
        public static IWebDriver CreateBrowser()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--start-maximized");

            IWebDriver driver = new ChromeDriver(options);

            return driver;
        }
    }
}