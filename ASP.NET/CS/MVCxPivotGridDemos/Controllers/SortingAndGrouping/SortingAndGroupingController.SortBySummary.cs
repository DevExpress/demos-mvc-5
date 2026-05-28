using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SortingAndGroupingController : DemoController {
        [HttpGet]
        public ActionResult SortBySummary() {
            Session["SortField"] = "Order Amount";
            return DemoView("SortBySummary", NorthwindDataProvider.GetFullInvoices());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SortBySummary([Bind]string SortByField) {
            Session["SortField"] = SortByField;
            return DemoView("SortBySummary", NorthwindDataProvider.GetFullInvoices());
        }
        public ActionResult SortBySummaryPartial() {
            return PartialView("SortBySummaryPartial", NorthwindDataProvider.GetFullInvoices());
        }
    }
}
