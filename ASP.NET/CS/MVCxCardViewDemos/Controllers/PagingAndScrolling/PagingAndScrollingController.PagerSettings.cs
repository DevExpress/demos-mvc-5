using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PagingAndScrollingController : DemoController {
        public ActionResult PagerSettings() {
            return DemoView("PagerSettings", NorthwindDataProvider.GetCustomers());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PagerSettings([Bind] PagerDemoOptions options) {
            PagerDemoHelper.Options = options;
            return DemoView("PagerSettings", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult PagerSettingsPartial() {
            return PartialView("PagerSettingsPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
