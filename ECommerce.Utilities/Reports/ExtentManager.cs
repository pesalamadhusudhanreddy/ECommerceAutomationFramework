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
                string reportFolder = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Reports"
                );

                Directory.CreateDirectory(reportFolder);

                string reportPath = Path.Combine(
                    reportFolder,
                    "ExtentReport.html"
                );

                var sparkReporter = new ExtentSparkReporter(reportPath);

                extent = new ExtentReports();
                extent.AttachReporter(sparkReporter);
            }

            return extent;
        }
    }
}