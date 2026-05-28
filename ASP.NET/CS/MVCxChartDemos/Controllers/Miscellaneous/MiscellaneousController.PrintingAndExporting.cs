using System.Web.Mvc;

namespace DevExpress.Web.Demos.Charts {
    public partial class MiscellaneousController : DemoController {
        public ActionResult PrintingAndExporting() {
            return DemoView("PrintingAndExporting", MicrosoftAnnualRevenueProvider.GetMicrosoftAnnualRevenue());
        }
        public ActionResult PrintingAndExportingPartial() {
            return PartialView("PrintingAndExportingPartial", MicrosoftAnnualRevenueProvider.GetMicrosoftAnnualRevenue());
        }
    }
}
