using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ECommerce.Utilities.Reports;

namespace ECommerce.Tests.Fixtures
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            Driver = new ChromeDriver(options);
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            ExtentManager.GetExtent();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                var screenshotPath = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "Screenshots",
                    $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.png"
                );

                Directory.CreateDirectory(Path.GetDirectoryName(screenshotPath));
                screenshot.SaveAsFile(screenshotPath);
            }

            Dispose();
        }

        public void Dispose()
        {
            Driver?.Dispose();
            Driver?.Quit();
        }
    }
}