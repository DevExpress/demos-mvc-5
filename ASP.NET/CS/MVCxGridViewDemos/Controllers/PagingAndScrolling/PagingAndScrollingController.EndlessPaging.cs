using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController: DemoController {
        public ActionResult EndlessPaging() {
            return DemoView("EndlessPaging", NorthwindDataProvider.GetOrders());
        }
        public ActionResult EndlessPagingPartial() {
            return PartialView("EndlessPagingPartial", NorthwindDataProvider.GetOrders());
        }
    }
}
