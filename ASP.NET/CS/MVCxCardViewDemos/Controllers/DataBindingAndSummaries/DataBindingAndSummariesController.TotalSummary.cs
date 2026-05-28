using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class DataBindingAndSummariesController: DemoController {
        public ActionResult TotalSummary() {
            return DemoView("TotalSummary", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult TotalSummaryPartial() {
            return PartialView("TotalSummaryPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
