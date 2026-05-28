using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AppearanceController : DemoController {
        public ActionResult Templates() {
            return DemoView("Templates", NorthwindDataProvider.GetProductReports());
        }
        public ActionResult TemplatesPartial() {
            return PartialView("TemplatesPartial", NorthwindDataProvider.GetProductReports());
        }
    }
}
