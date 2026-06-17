using OpenQA.Selenium;

namespace ECommerce.Framework.Pages
{
    public class InventoryPage
    {
        private IWebDriver Driver;


        public InventoryPage(IWebDriver driver)
        {
            Driver = driver;
        }


        private By Title =
            By.ClassName("title");


        public string GetTitle()
        {
            return Driver.FindElement(Title)
                         .Text;
        }
    }
}