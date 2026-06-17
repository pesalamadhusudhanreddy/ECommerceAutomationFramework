using OpenQA.Selenium;

namespace ECommerce.Framework.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver;


        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }


        // Locators

        private By Username =
            By.Id("user-name");


        private By Password =
            By.Id("password");


        private By LoginButton =
            By.Id("login-button");



        // Methods


        public void EnterUsername(string username)
        {
            Driver.FindElement(Username)
                  .SendKeys(username);
        }


        public void EnterPassword(string password)
        {
            Driver.FindElement(Password)
                  .SendKeys(password);
        }


        public void ClickLogin()
        {
            Driver.FindElement(LoginButton)
                  .Click();
        }
    }
}