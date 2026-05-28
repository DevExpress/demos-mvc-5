using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class BarsAndUIController : DemoController {
        public ActionResult RibbonCustomization() {
            return DemoView("RibbonCustomization", RibbonCustomizationDemoOptions.Current);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult RibbonCustomization([Bind] RibbonCustomizationDemoOptions options) {
            RibbonCustomizationDemoOptions.Current = options;
            return DemoView("RibbonCustomization", RibbonCustomizationDemoOptions.Current);
        }
        public ActionResult RibbonCustomizationPartial() {
            return PartialView("RibbonCustomizationPartial", RibbonCustomizationDemoOptions.Current);
        }
    }
}
