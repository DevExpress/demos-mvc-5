using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController: DemoController {
        public ActionResult Scrolling() {
            return DemoView("Scrolling", NorthwindDataProvider.GetOrders());
        }
        public ActionResult ScrollingPartial() {
            return PartialView("ScrollingPartial", NorthwindDataProvider.GetOrders());
        }
    }
}
