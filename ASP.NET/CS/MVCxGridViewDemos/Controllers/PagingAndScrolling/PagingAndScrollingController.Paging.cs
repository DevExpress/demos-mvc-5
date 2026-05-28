using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController: DemoController {
        public ActionResult Paging() {
            return DemoView("Paging", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult PagingPartial() {
            return PartialView("PagingPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
