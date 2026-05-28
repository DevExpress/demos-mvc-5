using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ToolbarsAndUIController : DemoController {
        public ActionResult ReadingViewMode() {
            return DemoView("ReadingViewMode");
        }

        public ActionResult ReadingViewModePartial() {
            return PartialView("ReadingViewModePartial");
        }
    }
}
