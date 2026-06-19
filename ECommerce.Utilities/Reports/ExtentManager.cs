using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace ECommerce.Utilities.Reports
{
    public class ExtentManager
    {
        private static ExtentReports extent;

        public static ExtentReports GetExtent()
        {
            if (extent == null)
            {
                string reportPath = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "Reports",
                    "ExtentReport.html"
                );

                Directory.CreateDirectory(
                    Path.GetDirectoryName(reportPath)
                );

                var sparkReporter = new ExtentSparkReporter(reportPath);

                extent = new ExtentReports();
                extent.AttachReporter(sparkReporter);

                extent.AddSystemInfo("Application", "ECommerce");
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("Framework", "NUnit + Selenium");
            }

            return extent;
        }

        public static void Flush()
        {
            extent?.Flush();
        }
    }
}