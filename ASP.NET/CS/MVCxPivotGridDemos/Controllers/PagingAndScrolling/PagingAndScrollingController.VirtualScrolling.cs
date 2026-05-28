using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController: DemoController {
        public ActionResult VirtualScrolling() {
            return DemoView("VirtualScrolling", NorthwindDataProvider.GetProductReports());
        }
        public ActionResult VirtualScrollingPartial() {
            return PartialView("VirtualScrollingPartial", NorthwindDataProvider.GetProductReports());
        }
    }
}
