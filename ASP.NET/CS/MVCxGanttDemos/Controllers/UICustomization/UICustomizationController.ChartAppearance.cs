using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class UICustomizationController : DemoController {
        public ActionResult ChartAppearance(GanttDemoOptions options) {
            ViewBag.GanttDemoOptions = options;
            return DemoView("ChartAppearance");
        }
        public ActionResult ChartAppearancePartial(GanttDemoOptions options) {
            ViewBag.GanttDemoOptions = options;
            return PartialView("ChartAppearancePartial");
        }
    }
}
