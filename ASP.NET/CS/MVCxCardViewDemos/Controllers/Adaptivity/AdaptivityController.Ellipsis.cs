using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AdaptivityController: DemoController {
        public ActionResult Ellipsis() {
            Session["EnableEllipsis"] = true;
            return DemoView("Ellipsis", NorthwindDataProvider.GetEmployees());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ellipsis(bool enableEllipsis) {
            Session["EnableEllipsis"] = enableEllipsis;
            return DemoView("Ellipsis", NorthwindDataProvider.GetEmployees());
        }
        public ActionResult EllipsisPartial() {
            return PartialView("EllipsisPartial", NorthwindDataProvider.GetEmployees());
        }
    }
}
