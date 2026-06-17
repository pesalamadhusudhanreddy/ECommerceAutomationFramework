using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace ECommerce.Utilities.Reports
{
    public class ExtentManager
    {
        public static ExtentReports Extent;

        public static ExtentReports GetExtent()
        {
            if (Extent == null)
            {
                string path = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "Reports",
                    "index.html"
                );

                Directory.CreateDirectory(
                    Path.GetDirectoryName(path)
                );

                var reporter =
                    new ExtentSparkReporter(path);

                Extent = new ExtentReports();

                Extent.AttachReporter(reporter);
            }

            return Extent;
        }
    }
}