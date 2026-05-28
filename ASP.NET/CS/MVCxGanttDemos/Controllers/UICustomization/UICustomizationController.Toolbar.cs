using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class UICustomizationController : DemoController {
        public ActionResult Toolbar(GanttDemoOptions options) {
            ViewBag.GanttDemoOptions = options;
            return DemoView("Toolbar");
        }        
        public ActionResult ToolbarPartial(GanttDemoOptions options) {
            ViewBag.GanttDemoOptions = options;
            return PartialView("ToolbarPartial");
        }
    }
}
