using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult Compliance() {
            return DemoView("Compliance", new CustomerInfo());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Compliance([Bind] CustomerInfo model) {
            return DemoView("Compliance", model);
        }
    }
}
