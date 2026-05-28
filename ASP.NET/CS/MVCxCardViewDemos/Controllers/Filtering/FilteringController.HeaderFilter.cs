using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FilteringController: DemoController {
        public ActionResult HeaderFilter() {
            Session["EnableCheckedListMode"] = true;
            return DemoView("HeaderFilter", NorthwindDataProvider.GetInvoices());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HeaderFilter(bool enableCheckedListMode) {
            Session["EnableCheckedListMode"] = enableCheckedListMode;
            return DemoView("HeaderFilter", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult HeaderFilterPartial() {
            return PartialView("HeaderFilterPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}
