using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class AccessibilityController : DemoController {
        public ActionResult KeyboardSupport() {
            return DemoView("KeyboardSupport", NorthwindDataProvider.GetProducts());
        }
        public ActionResult KeyboardSupportPartial() {
            return PartialView("KeyboardSupportPartial", NorthwindDataProvider.GetProducts());
        }
    }
}
