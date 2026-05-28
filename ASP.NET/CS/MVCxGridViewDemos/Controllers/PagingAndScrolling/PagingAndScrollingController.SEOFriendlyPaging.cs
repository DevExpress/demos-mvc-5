using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController: DemoController {
        public ActionResult SEOFriendlyPaging() {
            return DemoView("SEOFriendlyPaging", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult SEOFriendlyPagingPartial() {
            return PartialView("SEOFriendlyPagingPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
