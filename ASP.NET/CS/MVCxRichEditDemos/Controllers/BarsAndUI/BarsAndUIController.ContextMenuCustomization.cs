using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarsAndUIController : DemoController {
        public ActionResult ContextMenuCustomization() {
            return DemoView("ContextMenuCustomization", ContextMenuCustomizationDemoOptions.Current);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult ContextMenuCustomization([Bind] ContextMenuCustomizationDemoOptions options) {
            ContextMenuCustomizationDemoOptions.Current = options;
            return DemoView("ContextMenuCustomization", ContextMenuCustomizationDemoOptions.Current);
        }
        public ActionResult ContextMenuCustomizationPartial() {
            return PartialView("ContextMenuCustomizationPartial", ContextMenuCustomizationDemoOptions.Current);
        }
    }
}
