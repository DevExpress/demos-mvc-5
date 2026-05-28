using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SummaryController : DemoController {
        public ActionResult Summary() {
            return DemoView("Summary", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult SummaryPartial() {
            return PartialView("SummaryPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
