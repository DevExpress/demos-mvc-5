using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class HintController : DemoController {
        public ActionResult Ellipsis() {
            return DemoView("Ellipsis", NorthwindDataProvider.GetCustomers());
        }
        public ActionResult GridEllipsis() {
            return PartialView("EllipsisPartial", NorthwindDataProvider.GetCustomers());
        }
    }
}
