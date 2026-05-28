using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class UICustomizationController : DemoController {
        public ActionResult TaskTemplate(GanttDemoOptions options) {
            ViewBag.GanttDemoOptions = options;
            return DemoView("TaskTemplate");
        }
        public ActionResult TaskTemplatePartial(GanttDemoOptions options) {
            ViewBag.GanttDemoOptions = options;
            return PartialView("TaskTemplatePartial");
        }
    }
}
