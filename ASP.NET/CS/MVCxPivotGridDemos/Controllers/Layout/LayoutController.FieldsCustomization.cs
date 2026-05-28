using System.Web.Mvc;
using DevExpress.Web.Demos.Mvc;

namespace DevExpress.Web.Demos {
    public partial class LayoutController : DemoController {
        [HttpGet]
        public ActionResult FieldsCustomization() {
            return DemoView("FieldsCustomization", new PivotGridFieldsCustomizationDemoOptions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FieldsCustomization([Bind]PivotGridFieldsCustomizationDemoOptions options) {
            return DemoView("FieldsCustomization", options);
        }

        public ActionResult FieldsCustomizationPartial(PivotGridFieldsCustomizationDemoOptions options) {
            return PartialView("FieldsCustomizationPartial", options);
        }
    }
}
