using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        [HttpGet]
        public ActionResult Compliance() {
            return DemoView("Compliance", NorthwindDataProvider.GetEmployees());
        }

        public ActionResult CompliancePartial() {
            return PartialView("CompliancePartial", NorthwindDataProvider.GetEmployees());
        }
    }
}
