using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ECommerce.Utilities.Reports;

namespace ECommerce.Tests.Fixtures
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver Driver;
        protected ExtentReports Extent;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            Driver = new ChromeDriver(options);

            Driver.Navigate().GoToUrl(
                "https://www.saucedemo.com/"
            );

            Extent = ExtentManager.GetExtent();
        }


        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status
                == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                TakeScreenshot();
            }

            ExtentManager.Flush();

            Dispose();
        }


        public void TakeScreenshot()
        {
            var screenshot = ((ITakesScreenshot)Driver)
                .GetScreenshot();


            var screenshotPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Screenshots",
                $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.png"
            );


            Directory.CreateDirectory(
                Path.GetDirectoryName(screenshotPath)
            );


            screenshot.SaveAsFile(screenshotPath);
        }


        public void Dispose()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }
    }
}