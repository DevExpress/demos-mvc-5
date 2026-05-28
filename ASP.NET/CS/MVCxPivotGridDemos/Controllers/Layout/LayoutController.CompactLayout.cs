using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class LayoutController : DemoController {
        public ActionResult CompactLayout() {
            return DemoView("CompactLayout", NorthwindDataProvider.GetSalesPerson());
        }
        public ActionResult CompactLayoutPartial() {
            return PartialView("CompactLayoutPartial", NorthwindDataProvider.GetSalesPerson());
        }
    }
}
