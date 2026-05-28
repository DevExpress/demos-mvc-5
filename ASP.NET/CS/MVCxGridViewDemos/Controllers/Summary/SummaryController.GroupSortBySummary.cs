using System.Web.Mvc;
using DevExpress.Data;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class SummaryController: DemoController {
        public ActionResult GroupSortBySummary() {
            return DemoView("GroupSortBySummary", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult GroupSortBySummaryPartial(string GroupInfoSortState) {
            ViewData["GroupSummarySortState"] = GroupInfoSortState;
            return PartialView("GroupSortBySummaryPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
