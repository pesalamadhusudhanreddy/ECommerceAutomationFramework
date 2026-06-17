using AventStack.ExtentReports;
namespace ECommerce.Utilities.Reports
{
    public class ExtentManager
    {
        public static object Extent { get; set; }

        public static object GetExtent()
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

                Extent = new object();
            }

            return Extent;
        }
    }
}