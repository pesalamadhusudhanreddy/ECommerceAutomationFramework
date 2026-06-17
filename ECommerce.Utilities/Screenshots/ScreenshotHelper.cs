using OpenQA.Selenium;

namespace ECommerce.Utilities.Screenshots
{
    public class ScreenshotHelper
    {

        public static string CaptureScreenshot(
            IWebDriver driver,
            string testName)
        {

            ITakesScreenshot screenshotDriver =
                (ITakesScreenshot)driver;


            Screenshot screenshot =
                screenshotDriver.GetScreenshot();


            string folderPath =
                Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "Screenshots"
                );


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }


            string fileName =
                testName + "_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss")
                + ".png";


            string filePath =
                Path.Combine(
                    folderPath,
                    fileName
                );


            screenshot.SaveAsFile(filePath);


            return filePath;
        }

    }
}